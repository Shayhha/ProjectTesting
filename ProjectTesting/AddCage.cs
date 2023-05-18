using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectTesting
{
    // This class is responsible for adding cages into the data base. This class has helper functions that help us determin
    // whether or not the information about the cage is correct or not (the info entered by the user)

    /// <summary>
    /// This class is responsible for adding cages into the data base. This class has helper functions that help us determin 
    /// whether or not the information about the cage is correct or not (the info entered by the user).
    /// </summary>
    public partial class AddCage : UserControl
    {
        // Constructor
        public AddCage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getting all of the information that the user has enters into the textboxes on the screen.
        /// Creates a Cage object and give the constructor all of the data from the text box.
        /// </summary>
        /// <returns>A Cage object that holds all of the data the user has entered</returns>
        private Cage getTextFromUi()
        {
            Cage cageInfo = new Cage(new string[]
            {
                idBox.Texts.ToString(),
                lengthBox.Texts.ToString(),
                widthBox.Texts.ToString(),
                heightBox.Texts.ToString(),
                materialBox.Texts.ToString()
            });

            return cageInfo;
        }

        /// <summary>
        /// 
        /// !!! We can take all of the simple input checks and place them inside the Cage class, so that the constructor, or another function
        /// !!! will call it and tell us here in this function if there was a wrong input, that way the code will be easier to read.
        /// 
        /// This is the main function of the AddCage class. It is responsible for actually adding new cages into the database and checking 
        /// their validity in the proccess. This function uses a few helper functions to perform all of the necessary tests.
        /// </summary>
        /// <param name="cage">Is the object we want to check and add to the database</param>
        /// <param name="edited">A boolean parameter that tells the function wheter or not the cage we want to add is a new cage or an existing cage.
        /// edited = true -> means that the cage we want to add already exists in the database.</param>
        /// <returns>true if the cage has correct parameters and was successfuly added to the database, false otherwise</returns>
        public bool getInfoFromUser(Cage cage, bool edited = false, string oldCageId = "")
        {
            // Variables:
            string[] cageInfo = cage.ToStringArray(); //convert the given cage into a string array
            int flag = 0, currentCageRow = 0;
            string errorMessage = "";
            string idPattern = "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$"; // checks for atleast one letter AND atleast one number

            // Checking that the user has inputed all of the fields, else show a message box with error
            for (int j = 0; j < 5; j++)
            {
                if (cageInfo[j] == "")
                {
                    errorMessage = "Please enter all of the information into the form.";
                    flag = 1;
                }
            }

            // Next if it is we change it to all capital letters because our database works with capital values for material
            if (cageInfo[4] == "Wood" || cageInfo[4] == "wood") { cageInfo[4] = "WOOD"; }
            else if (cageInfo[4] == "Metal" || cageInfo[4] == "metal") { cageInfo[4] = "METAL"; }
            else if (cageInfo[4] == "Plastic" || cageInfo[4] == "plastic") { cageInfo[4] = "PLASTIC"; }

            // If there where no errors up untill now, we need to perform some more checks
            if (flag == 0)
            {
                // Checking if the cage id matches the allowed pattern
                if (!(Regex.IsMatch(cageInfo[0], idPattern)))
                {
                    errorMessage = "The cage id must contain letters and numbers.";
                    flag = 1;
                }
                // Checking if the dimentions of the cage are correct
                else if (!checkDimentions(cageInfo))
                {
                    return false;
                }
                // Checking if the material of the cage is correct
                else if (cageInfo[4] != "WOOD" && cageInfo[4] != "METAL" && cageInfo[4] != "PLASTIC")
                {
                    errorMessage = "Cage can only be made out of WOOD, METAL or PLASTIC.";
                    flag = 1;
                }
            }

            // If there was an error, then flag will be 1, if it is then we show a message box with the error message and then return false. 
            if (flag == 1)
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }

            // If everything went well and there where no errors, we the open the database excel file,
            // add the new cage to the excel, sort the excel and then close it.
            LogIn.DataBaseExcel = new Excel("database", MainWindow.UserSheet); //open DataBaseExcel

            // If the cage is not edited, meaning its a new cage that the user wants to add
            // to the database we need to check if the ID of the new cage does not already exit in the database.
            if (!edited)
            {
                // Checking if the cage ID is unique
                if (!checkCageId(cageInfo[0]))
                {
                    CustomMessageBox.Show("The cage you are trying to add already exists in the database, try a different id.", "Error");
                    return false;
                }
                LogIn.DataBaseExcel.WriteRange(LogIn.DataBaseExcel.GetLastRow(), 1, 5, cageInfo); //add cage to database excel
                MainWindow.HashTable.AddCageToHashtable(new Cage(cageInfo)); //add cage to hashtable
                ((MainWindow)this.Parent.Parent).setCagesLabel((LogIn.DataBaseExcel.GetLastRow() - 1).ToString());
            }
            else // if this cage is edited, means it already exists, we need to find the row in the database and change its values
            {
                List<Bird> tempBird = null;
                List<Cage> currentCage = MainWindow.HashTable.SearchCageHashtable(oldCageId); //get current cage

                if (cageInfo[0].Equals(oldCageId))
                {
                    for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(1); i++)
                    {
                        if (LogIn.DataBaseExcel.ReadCell("A" + i) == oldCageId)
                        {
                            currentCageRow = i;
                            break;
                        }
                    }
                }
                else if (!(cageInfo[0].Equals(oldCageId))) // the id of the cage was changed in the edit
                {
                    // if the cage id was changed we need to find all the birds from that cage and change their cage id
                    // in the database and the hashtable.
                    for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(1); i++)
                    {
                        // first we find the current cage in the database inorder to get it's row number
                        if (LogIn.DataBaseExcel.ReadCell("A" + i).Equals(oldCageId))
                        {
                            currentCageRow = i; // saveing the row number of the current cage

                            // if this cage has birds, then we will look for them, the runtime here will be O(n+m) where n is number of cages and m is number of birds
                            if (currentCage[0].BirdList.Count != 0)
                            {
                                int count = 0;
                                // this loop will run only once, and only if the bird has offsprings, runtime O(m) where m is num of birds in database
                                for (int j = 1; j < LogIn.DataBaseExcel.GetLastRow(7); j++)
                                {
                                    if (LogIn.DataBaseExcel.ReadCell("L" + j).Equals(oldCageId)) // checking if the currend bird belongs to the current cage
                                    {
                                        LogIn.DataBaseExcel.WriteCell("L" + j, cageInfo[0]); // change the birds cage id
                                        tempBird = MainWindow.HashTable.SearchBirdHashtable(LogIn.DataBaseExcel.ReadCell("G" + j)); // find the bird in the hashtable
                                        tempBird[0].CageId = cageInfo[0]; // change the cage id in the hashtable
                                        count++;
                                    }

                                    if (count == currentCage[0].BirdList.Count)
                                        break; // if we found all of the birds for this cage we break the inner loop because we dont need to search anymore
                                }
                            }
                            break; // if we have found the cage, and edited the cage id for his birds we now can exit the loop because we dont need to search for the cage anymore
                        }
                    }
                }

                // adding the cage to the database
                LogIn.DataBaseExcel.WriteRange(currentCageRow, 1, 5, cageInfo);

                // updating the cage in the hashtable, currentCage[0] is the cage we are editing, we search for it in the code above
                currentCage[0].EditFields(cageInfo);
                if (cageInfo[0] != oldCageId) //if we changed id of cage we need to remove old hash code and add new id with new hash code
                {
                    MainWindow.HashTable.RemoveCageFromHashtable(oldCageId); //remove old cage id from cage hashtable
                    MainWindow.HashTable.AddCageIdToHashtable(currentCage[0], oldCageId); //adds the cage id back to cage hashtable
                }
            }

            // we want to sort the database only if the user adds a new cage OR the user modifies the cage id of an existing cage
            if (!(LogIn.DataBaseExcel.ReadCell("A2").Equals(""))) //checks if new user (doesn't need sort at begining)
            {
                if (edited)
                {
                    if (!(cageInfo[0].Equals(oldCageId)))
                    {
                        if (currentCageRow == 1
                            && LogIn.DataBaseExcel.ReadCell("A" + (currentCageRow + 1)).CompareTo(cageInfo[0]) < 0)
                        {//if we try to edit the first cage in database we cant find the cage before!!
                            MainWindow.SortExcel("cage"); //calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();
                            MainWindow.InitHashtable();
                        }
                        else if ((currentCageRow == LogIn.DataBaseExcel.GetLastRow() - 1)
                            && LogIn.DataBaseExcel.ReadCell("A" + (currentCageRow - 1)).CompareTo(cageInfo[0]) > 0)
                        {
                            MainWindow.SortExcel("cage"); //calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();
                            MainWindow.InitHashtable();
                        }
                        else if (currentCageRow != 1 && (currentCageRow != LogIn.DataBaseExcel.GetLastRow() - 1)
                            && (LogIn.DataBaseExcel.ReadCell("A" + (currentCageRow - 1)).CompareTo(cageInfo[0]) > 0
                            || LogIn.DataBaseExcel.ReadCell("A" + (currentCageRow + 1)).CompareTo(cageInfo[0]) < 0))
                        {
                            MainWindow.SortExcel("cage"); //calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();
                            MainWindow.InitHashtable();
                        }
                    }
                }
                else
                {
                    // if the id of the new cage we added to the database has an id smaller than the last cage in the database, need to sort 
                    if (LogIn.DataBaseExcel.ReadCell("A" + (LogIn.DataBaseExcel.GetLastRow(1) - 2)).CompareTo((cageInfo[0])) > 0)
                    {
                        MainWindow.SortExcel("cage"); //calls SortExcel from MainWindow
                        MainWindow.HashTable.ClearBirdCageHashtable();
                        MainWindow.InitHashtable();
                    }
                }
            }

            LogIn.DataBaseExcel.Quit(); //close excel

            return true;
        }

        /// <summary>
        /// Cleaning the text from the screen
        /// </summary>
        public void cleanTextBoxes()
        {
            idBox.Texts = "";
            lengthBox.Texts = "";
            widthBox.Texts = "";
            heightBox.Texts = "";
            materialBox.Texts = "";
        }

        /// <summary>
        /// Checking that the dimentions of the cage are numeric and are positive, if not show and error message
        /// </summary>
        /// <param name="info"></param>
        /// <returns>true if the dimentios are valid, false otherwise</returns>
        private bool checkDimentions(string[] info)
        {
            int flag = 0;
            int lengthVal, widthVal, heightVal;
            string errorMessage = "";

            if (!(int.TryParse(info[1], out lengthVal)))
            {
                errorMessage = "Invalid Length, try agian.";
                flag = 1;
            }
            else if (!(int.TryParse(info[2], out widthVal)))
            {
                errorMessage = "Invalid Width, try agian.";
                flag = 1;
            }
            else if (!(int.TryParse(info[3], out heightVal)))
            {
                errorMessage = "Invalid Height, try agian.";
                flag = 1;
            }
            else if (lengthVal <= 0 || widthVal <= 0 || heightVal <= 0)
            {
                errorMessage = "Oops, You have entered incorrect dimentions, try again.";
                flag = 1;
            }

            if (flag == 1)
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checking if the id of the cage exists in the database by checking if it exists in the hash table
        /// </summary>
        /// <param name="cageId"></param>
        /// <returns>true if the cage id is unique and false if it exists in the database</returns>
        public bool checkCageId(string cageId) // with hashtable (works)
        {
            List<Cage> cages = MainWindow.HashTable.SearchCageHashtable(cageId); //search cageId in hashtable
            if (cages.Count != 0) // if given list is empty we know that the cageId doesnt exists
                return false; //returns false if the cageId is already in database
            return true; // else we dont have that cageId so we return true
        }

        /// <summary>
        /// When clicking the "Add Cage" button, we take all of the info from the screen, test it, and if its correct
        /// we insert it into the database and the hashtable and return the user to the homepage screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (getInfoFromUser(getTextFromUi()))
            {
                cleanTextBoxes();
                ((MainWindow)this.Parent.Parent).homePage1.Show();
                setWelcome_lable(false);
                this.Hide();
            }
        }

        /// <summary>
        /// If the user decided not to add a cage then we just reset the textboxes to be empty for the next attempt and go back to the homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            ((MainWindow)this.Parent.Parent).homePage1.Show();
            setWelcome_lable(false);
            this.Hide();
        }

        /// <summary>
        /// Setting a welcome label for the user, this is done when the user has opened a new account, we want him to 
        /// immediatly add a cage, if that happens we want him to see a welcome message, in any other subsecuent addition of
        /// a new cage we dont want to show the welcome label
        /// </summary>
        /// <param name="temp"></param>
        public void setWelcome_lable(bool temp) //sets the welcome lable to visible/hidden
        {
            if (temp == true)
            {
                Welcome_label.Show();
                cancelButton.Hide();
            }
            else
            {
                Welcome_label.Hide();
                cancelButton.Show();
            }
        }
    }
}

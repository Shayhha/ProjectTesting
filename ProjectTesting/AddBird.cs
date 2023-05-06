using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTesting
{
    public partial class AddBird : UserControl
    {
        public AddBird()
        {
            InitializeComponent();
        }

        private Bird getTextFromUi(bool isOffspring)
        {
            string resultOffspring = "";
            if (isOffspring)
                resultOffspring = "yes";
            else
                resultOffspring = "no";

            Bird birdInfo = new Bird(new string[] {
                idBox.Text.ToString(),
                typeBox.Text.ToString(),
                subTypeBox.Text.ToString(),
                dateBox.Text.ToString(),
                genderBox.Text.ToString(),
                cageIdBox.Text.ToString(),
                dadBox.Text.ToString(),
                momBox.Text.ToString(),
                resultOffspring}
            );

            return birdInfo;
        }

        public bool getInfoFromUser(Bird bird, bool edited = false, string oldBirdId = "")
        {
            string[] birdInfo = bird.ToStringArray(); //convert bird to string array
            int currentBirdRow = 0 ; //index of current bird
            Bird newBird = null; // bird object for the new bird (shared with everyone) 
            int flag = 0;
            string errorMessage = "";
            string idPattern = "^[0-9]+$";

            for (int j = 0; j < 6; j++)
            {
                if (birdInfo[j] == "")
                {
                    errorMessage = "Please enter all of the information into the form. (dad's id and mom's id are optional)";
                    flag = 1;
                }
            }

            if (!edited)
            {
                if (dadBox.Text == "") { birdInfo[6] = "0"; }
                if (momBox.Text == "") { birdInfo[7] = "0"; }
            }

            if (birdInfo[4] == "m" || birdInfo[4] == "male")
            {
                birdInfo[4] = "Male";
            }
            else if (birdInfo[4] == "f" || birdInfo[4] == "female")
            {
                birdInfo[4] = "Female";
            }

            if (flag == 0)
            {
                if (!(Regex.IsMatch(birdInfo[0], idPattern)))
                {
                    errorMessage = "The bird id must ONLY contain numbers.";
                    flag = 1;
                }
                else if (!checkType(birdInfo[1]) || !checkSubType(birdInfo[1], birdInfo[2]) || !checkGender(birdInfo[4])) { ((MainWindow)this.Parent.Parent).moreDetails1.progressBarPanel.Visible = false; return false; }
                else if (((MainWindow)this.Parent.Parent).addCage1.checkCageId(birdInfo[5]))
                {
                    ((MainWindow)this.Parent.Parent).moreDetails1.progressBarPanel.Visible = false;
                    CustomMessageBox.Show("The cage id you have typed does not belong to you or does not exist.\nYou can try one of these: " + findValidCageIds(), "Error");
                    return false;
                }
                else if (errorMessage != "")
                { 
                    ((MainWindow)this.Parent.Parent).moreDetails1.progressBar.Value = 50;
                }

                if (!edited) // edited will be true only if the user is adding a new bird, when the user edits an existing bird it will be false
                {
                    if (!checkBirdId(birdInfo[0], birdInfo[6], birdInfo[7])) { ((MainWindow)this.Parent.Parent).moreDetails1.progressBarPanel.Visible = false; return false; }
                }
                
                if (birdInfo[6] != "")
                {
                    if (!(Regex.IsMatch(birdInfo[6], idPattern)))
                    {
                        errorMessage = "The dad's id must ONLY contain numbers.";
                        flag = 1;
                    }
                    else if (birdInfo[6] == birdInfo[0])
                    {
                        errorMessage = "The bird's id and dad's id must be different.";
                        flag = 1;
                    }
                }
                
                if (birdInfo[7] != "")
                {
                    if (!(Regex.IsMatch(birdInfo[7], idPattern)))
                    {
                        errorMessage = "The mom's id must ONLY contain numbers.";
                        flag = 1;
                    }
                    else if (birdInfo[7] == birdInfo[0])
                    {
                        errorMessage = "The bird's id and mom's id must be different.";
                        flag = 1;
                    }
                }
            }

            ((MainWindow)this.Parent.Parent).moreDetails1.progressBar.Value = 75;

            if (flag == 1)
            {
                ((MainWindow)this.Parent.Parent).moreDetails1.progressBarPanel.Visible = false; 
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }
            else //else means all parameters are correct so we add/edit the bird
            {
                LogIn.DataBaseExcel = new Excel("database", MainWindow.UserSheet); //open DataBaseExcel
                int count = 0; //count for loop break
                List<Bird> dad = null; //for use in offspring
                List<Bird> mom = null; //for use in offspring
                if(!edited) //if we adding new bird we initialize the bird object
                    newBird = new Bird(birdInfo);  //initializing new bird object

                if (birdInfo[8] == "yes") //if bird is offspring we search in hashtable the parents
                {
                    //searching the parents in hashtable and add the offspring to them
                    dad = MainWindow.HashTable.SearchBirdHashtable(birdInfo[6]);
                    mom = MainWindow.HashTable.SearchBirdHashtable(birdInfo[7]);
                    if (!edited) //we add the offspring only when we know wern't editing
                    {
                        dad[0].AddOffspring(newBird); //add offspirng to dad 
                        mom[0].AddOffspring(newBird); //add offspring to mom
                    }
                }

                for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(7); i++) //goes through database to find index / parents of offspring
                {
                    if (edited && LogIn.DataBaseExcel.ReadCell("G" + i) == oldBirdId) //only when we need to edit
                    {
                        currentBirdRow = i; //finds birds row in database
                        count++;
                    }
                    if(edited && birdInfo[8] == "no" && oldBirdId != birdInfo[0]) //means birds id has been changed(regular bird)
                    {
                        if(LogIn.DataBaseExcel.ReadCell("M" + i) == oldBirdId) //checks dadId and if we found oldBirdId we change to new one
                        {
                            LogIn.DataBaseExcel.WriteCell("M" + i, birdInfo[0]);
                            count++;
                        }
                        else if(LogIn.DataBaseExcel.ReadCell("N" + i) == oldBirdId)//checks momId and if we found oldBirdId we change to new one
                        {
                            LogIn.DataBaseExcel.WriteCell("N" + i, birdInfo[0]);
                            count++;
                        }
                    }
                    ///we need to regard a situation where we change id of offspring, we need to change that in parents///
                    if (dad != null && mom != null) //if not null means we add/edit offspring
                    {
                        if (LogIn.DataBaseExcel.ReadCell("G" + i) == dad[0].Id)
                        {
                            if ((LogIn.DataBaseExcel.ReadCell("P" + i)) == "none") //if dad doesnt have offsprings yet
                                LogIn.DataBaseExcel.WriteCell("P" + i, birdInfo[0] + ","); //add offspring id to dad
                            else //if dad has offsprings we add another one to existing list of offspring ids
                                LogIn.DataBaseExcel.WriteCell("P" + i, (LogIn.DataBaseExcel.ReadCell("P" + i)) + birdInfo[0] + ","); //add offspring id to dad
                            count++;
                        }

                        else if (LogIn.DataBaseExcel.ReadCell("G" + i) == mom[0].Id)
                        {
                            if ((LogIn.DataBaseExcel.ReadCell("P" + i)) == "none") //if mom doesnt have offsprings yet
                                LogIn.DataBaseExcel.WriteCell("P" + i, birdInfo[0] + ","); //add offspring id to mom
                            else //if mom has offsprings we add another one to existing list of offspring ids
                                LogIn.DataBaseExcel.WriteCell("P" + i, (LogIn.DataBaseExcel.ReadCell("P" + i)) + birdInfo[0] + ","); //add offspring id to mom
                            count++;
                        }
                    }
                    if (birdInfo[8] == "no") //break if we have regular bird
                    {
                        List<Bird> oldBird = MainWindow.HashTable.SearchBirdHashtable(oldBirdId); //search old bird
                        if (!edited) //if we dont edit we break 
                            break;
                        //if id has been changed, if we changed the id in all offsprings(in list) + 1 for current index we break
                        else if (edited && oldBirdId != birdInfo[0] && count == oldBird[0].OffspringList.Count + 1)
                            break;
                        else if (edited && oldBirdId == birdInfo[0] && count == 1)  //if we edit, we search currect index in database and then break
                            break;
                    }
                    if (birdInfo[8] == "yes") //break if we have offspring
                    {
                        if (!edited && count == 2) //if we already found mom and dad inside the database we break (adding a new bird)
                            break;
                        else if (edited && count == 3) //if we found dad, mom and the current offspring we break (editing existing bird)
                            break;
                    }
                }

                if (!edited) //means we add the bird/offspring
                {
                    LogIn.DataBaseExcel.WriteRange(LogIn.DataBaseExcel.GetLastRow(7), 7, 16, birdInfo); //add bird to database
                    MainWindow.HashTable.AddBirdToHashtable(newBird); //add bird to hashtable
                    ((MainWindow)this.Parent.Parent).setBirdsLabel((LogIn.DataBaseExcel.GetLastRow(7) - 1).ToString());
                    List<Cage> cage = MainWindow.HashTable.SearchCageHashtable(birdInfo[5]); //find the cage we need to add the new bird to
                    cage[0].AddBird(newBird); //add bird to cage object
                    /// here we need to build hashtable again if new id isnt in sorted order of id's ///
                    if (oldBirdId != birdInfo[0])
                    {
                        if (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (LogIn.DataBaseExcel.GetLastRow(7) - 1))) > int.Parse(birdInfo[0]))
                        {
                            MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                            MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                        }
                    }
                }
                else //means we edit the current bird so we add new info to current index in database
                {
                    MessageBox.Show(currentBirdRow.ToString());
                    LogIn.DataBaseExcel.WriteRange(currentBirdRow, 7, 16, birdInfo); //add new info to current bird
                    List<Bird> currentBird = MainWindow.HashTable.SearchBirdHashtable(oldBirdId); 
                    currentBird[0].EditFields(birdInfo); //edit the bird in hashtable
                    /// here we need to build hashtable again if new id isnt in sorted order of id's ///
                    if (oldBirdId != birdInfo[0])
                    {
                        if (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow - 1))) > int.Parse(birdInfo[0])
                            || int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow + 1))) < int.Parse(birdInfo[0]))
                        {
                            MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                            MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                        }
                    }
                }
                LogIn.DataBaseExcel.Quit();//close excel
                return true;
            }
        }

        private void cleanTextBoxes()
        {
            idBox.Text = "";
            typeBox.Text = "";
            subTypeBox.Text = "";
            dateBox.Text = "";
            genderBox.Text = "";
            cageIdBox.Text = "";
            dadBox.Text = "";
            momBox.Text = "";
        }

        public bool checkBirdId(string birdId, string dadId = "", string momId = "")
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow(7);
            string idValue;

            for (int i = 1; i < row; i++)
            {
                idValue = ex.ReadCell("G" + i);
                if (idValue == birdId)
                {
                    CustomMessageBox.Show("The bird you are trying to add already exists in the database, try a different id.", "Error");
                    ex.Quit();
                    return false;
                }
                else if (dadId != "" && momId != "")
                {
                    if (idValue == dadId || idValue == momId)
                    {
                        if (ex.ReadCell("O" + i.ToString()) == "yes")
                        {
                            CustomMessageBox.Show("Dad's id is an id of a fledgiling, he cannot yet be a dad.", "Dad Id Error");
                            ex.Quit();
                            return false;
                        } 
                    }
                }
            }
            ex.Quit();
            return true;

        }

        private bool checkType(string type)
        {
            if (type != "American Gouldian" && type != "European Gouldian" && type != "Australian Gouldian")
            {
                CustomMessageBox.Show("Error, the bird's type is incorrect, try again.", "Error");
                return false;
            }
            return true;
        }

        private bool checkSubType(string type, string subType)
        {
            if (
                (type == "American Gouldian" &&
                    (subType != "North America" && subType != "Center America" && subType != "South America")) ||
                (type == "Europe Gouldian" &&
                    (subType != "East European" && subType != "West European")) ||
                (type == "Australian Gouldian" &&
                    (subType != "Center Australia" && subType != "Coastal Cities"))
                )
            {
                CustomMessageBox.Show("Error, the sub type is incorrect. It must match the main type of the bird.", "Error");
                return false;
            }

            return true;
        }

        private bool checkGender(string gender)
        {
            if (gender != "Male" && gender != "Female")
            {
                CustomMessageBox.Show("Error, gender is incorrect.", "Error");
                return false;
                
            }
            return true;
        }

        private string findValidCageIds()
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow();
            string returnString = "";

            for (int i = 1; i < row; i++)
            {
                returnString += ex.ReadCell("A" + i.ToString()).ToString();
                if (i < row - 1)
                    returnString += ", ";
                else
                    returnString += ".";
            }
            ex.Quit();
            return returnString;
        }

        private bool CheckParent()
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = ex.GetLastRow(7);
            string parentType="";
            string parentGender, parentBox;
            string errorMessage = "";

            if (idBox.Text == momBox.Text || idBox.Text==dadBox.Text) //checks if we entered a parent id
            {
                CustomMessageBox.Show("You can't have parent's ID!", "ID Error");
                ex.Quit();
                return false;
            }

            if (momBox.Text == dadBox.Text)
            {
                CustomMessageBox.Show("Parent's can't have same ID!", "ID Error");
                ex.Quit();
                return false;
            }
            //now we want to know which parent's id we need to check
            if (dadBox.ReadOnly == true)//if dad is locked, we know we need to check moms id
            {
                parentType = "mom";
                parentBox = momBox.Text;
                parentGender = "Female";
            }

            else if (momBox.ReadOnly == true)
            {
                parentType = "dad";
                parentBox = dadBox.Text;
                parentGender = "Male";
            }
            else // we have an undefined error
            {
                ex.Quit();
                return false;
            }

            for (int i = 1; i < size; i++) //cage id, first id, gender, types
            {
                string[] temp = ex.ReadRange(i, 7, 15);


                if (temp[0] == parentBox)//means we need to find female bird
                {
                    errorMessage = "-1";
                    if (temp[4] != parentGender)
                    {
                        errorMessage = "Other parent must me " + parentGender.ToLower() + "!";
                    }

                    else if (temp[5] != cageIdBox.Text)
                    {
                        errorMessage = "Parents must be in the same cage!";
                    }
                    else if (temp[1] != typeBox.Text)
                    {
                        errorMessage = "Parents must have same type!";
                    }
                    else if (temp[7] == "yes")
                    {
                        errorMessage = "Parents must be adults!";
                    }
                    //else if (temp[2] != subTypeBox.Text)
                    //{
                    //    errorMessage = "Parents must have same subtype!";
                    //}
                    break;
                }
            }
            ex.Quit();
            if (errorMessage == "")
            {
                CustomMessageBox.Show("id not found", "Error");
                return false;
            }
            else if (errorMessage != "-1")
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }
            else
                return true;
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            bool isOffspring = false; //default is no for addBird
            int flag = 0;

            if (AddBird_label.Text == "Add an Offspring:")//if we add offspring we change it to yes
            { 
                isOffspring = true;
                if (CheckParent() == false)
                    flag = 1;
            }
            if (flag == 0)
            {
                if (getInfoFromUser(getTextFromUi(isOffspring)))
                {
                    cleanTextBoxes();
                    ((MainWindow)this.Parent.Parent).homePage1.Show();
                    this.Hide();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (AddBird_label.Text == "Add an Offspring:")
            {
                ((MainWindow)this.Parent.Parent).showBackBtn();
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();
                AddBird_label.Text = "Add a Bird:";
                ((MainWindow)this.Parent.Parent).addBird1.typeBox.ReadOnly = false;
                ((MainWindow)this.Parent.Parent).addBird1.subTypeBox.ReadOnly = false;
                ((MainWindow)this.Parent.Parent).addBird1.cageIdBox.ReadOnly = false;

                if (((MainWindow)this.Parent.Parent).addBird1.dadBox.ReadOnly == true)
                    ((MainWindow)this.Parent.Parent).addBird1.dadBox.ReadOnly = false;
                else
                    ((MainWindow)this.Parent.Parent).addBird1.momBox.ReadOnly = false;
            }
            else
            {
                ((MainWindow)this.Parent.Parent).homePage1.Show();
            }
            cleanTextBoxes();
            this.Hide();
        }

        
    }
}

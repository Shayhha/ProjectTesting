using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            int currentBirdRow = 0; //index of current bird
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
                else if (!checkType(birdInfo[1]) || !checkSubType(birdInfo[1], birdInfo[2]) || !checkGender(birdInfo[4])) { return false; }
                else if (((MainWindow)this.Parent.Parent).addCage1.checkCageId(birdInfo[5]))
                {

                    CustomMessageBox.Show("The cage id you have typed does not belong to you or does not exist.\nYou can try the following: " + findValidCageIds(), "Cage Id Error");
                    return false;
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
                    else if (!checkDadId(birdInfo[6]))
                        return false;

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
                    else if (!checkMomId(birdInfo[7]))
                    {
                        return false;
                    }
                }

                if (birdInfo[8] == "yes")
                {
                    // searching for the dad and mom birds in the hashtable inorder to check their date of birth
                    List<Bird> dad = MainWindow.HashTable.SearchBirdHashtable(birdInfo[6]);
                    List<Bird> mom = MainWindow.HashTable.SearchBirdHashtable(birdInfo[7]);

                    // turn into data object and check the dates. including the date of birth of the current bird (the offspring)
                    DateTime date1 = DateTime.ParseExact(birdInfo[3], "dd/MM/yyyy", null);
                    DateTime date2 = DateTime.ParseExact(dad[0].DateOfBirth, "dd/MM/yyyy", null);
                    DateTime date3 = DateTime.ParseExact(mom[0].DateOfBirth, "dd/MM/yyyy", null);

                    // if the date of birth of the offspring is before his parent's date of birth then return false and show error message
                    if (date1 < date2 && date1 < date3)
                    {
                        CustomMessageBox.Show("The offspring's date of birth must proceed the date of birth of his parents", "Date Error");
                        return false;
                    }
                }
                else if (edited && birdInfo[8] == "no" && birdInfo[9] != "none")
                {
                    // searching for the bird in the hashtable, using old id incase the id was changed in the edit
                    List<Bird> currentBird = MainWindow.HashTable.SearchBirdHashtable(oldBirdId);

                    // checking the date of birth of the current bird before and after the edit
                    DateTime date1 = DateTime.ParseExact(currentBird[0].DateOfBirth, "dd/MM/yyyy", null);
                    DateTime date2 = DateTime.ParseExact(birdInfo[3], "dd/MM/yyyy", null);

                    // if the new date (after the edit) is after the original date of birth then we give an error message because there might be offsprings born before the new date
                    if (date1 < date2)
                    {
                        CustomMessageBox.Show("The date of birth for parents cannot proceed the date of birth of his offsprings", "Date Error");
                        return false;
                    }
                }

                if (!edited) // if the user is adding a new bird we also want to check if that bird already exists in the database
                {
                    if (!checkBirdId(birdInfo[0]))
                    {
                        return false;
                    }
                }
            }


            if (flag == 1)
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }
            else //else means all parameters are correct so we add/edit the bird
            {
                LogIn.DataBaseExcel = new Excel("database", MainWindow.UserSheet); //open DataBaseExcel
                int count = 0; //count for loop break
                List<Bird> dad = null; //for use in offspring
                List<Bird> mom = null; //for use in offspring
                if (!edited) //if we adding new bird we initialize the bird object
                    newBird = new Bird(birdInfo);  //initializing new bird object

                if (birdInfo[8].Equals("yes")) //if bird is offspring we search in hashtable the parents
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
                    if (edited && LogIn.DataBaseExcel.ReadCell("G" + i).Equals(oldBirdId)) //only when we need to edit
                    {
                        currentBirdRow = i; //finds birds row in database
                        count++;
                    }
                    if (edited && birdInfo[8].Equals("no") && !(oldBirdId.Equals(birdInfo[0]))) //means birds id has been changed(regular bird)
                    {
                        if (LogIn.DataBaseExcel.ReadCell("M" + i).Equals(oldBirdId)) //checks dadId and if we found oldBirdId we change to new one
                        {
                            LogIn.DataBaseExcel.WriteCell("M" + i, birdInfo[0]);
                            count++;
                        }
                        else if (LogIn.DataBaseExcel.ReadCell("N" + i).Equals(oldBirdId))//checks momId and if we found oldBirdId we change to new one
                        {
                            LogIn.DataBaseExcel.WriteCell("N" + i, birdInfo[0]);
                            count++;
                        }
                    }
                    ///we need to regard a situation where we change id of offspring, we need to change that in parents///
                    if (dad != null && mom != null) //if not null means we add/edit offspring
                    {
                        if (LogIn.DataBaseExcel.ReadCell("G" + i).Equals(dad[0].Id))
                        {
                            if (edited && !(oldBirdId.Equals(birdInfo[0]))) //if we changed offspring id we need to update dad's list
                            {
                                string offspringList = (LogIn.DataBaseExcel.ReadCell("P" + i)); //save old string in parameter
                                offspringList = UpdateOffspringParents(offspringList, birdInfo[0], oldBirdId); //send the string list to UpdateOffspringList
                                LogIn.DataBaseExcel.WriteCell("P" + i, offspringList); //update database with new offspring list
                                count++;
                            }
                            else if (!edited)
                            {
                                if ((LogIn.DataBaseExcel.ReadCell("P" + i)).Equals("none")) //if dad doesnt have offsprings yet
                                    LogIn.DataBaseExcel.WriteCell("P" + i, birdInfo[0]); //add offspring id to dad
                                else
                                {//if dad has offsprings we add another one to existing list of offspring ids
                                    string offspringList = LogIn.DataBaseExcel.ReadCell("P" + i) + "|" + birdInfo[0];//add offspring id to dad
                                    offspringList = SortOffspringList(offspringList); //sorts the string if necessary
                                    LogIn.DataBaseExcel.WriteCell("P" + i, offspringList); //add offspring id to dad in database
                                }
                                count++;
                            }
                        }

                        else if (LogIn.DataBaseExcel.ReadCell("G" + i).Equals(mom[0].Id))
                        {
                            if (edited && !(oldBirdId.Equals(birdInfo[0]))) //if we changed offspring id we need to update mom's list
                            {
                                string offspringList = (LogIn.DataBaseExcel.ReadCell("P" + i)); //save old string in parameter
                                offspringList = UpdateOffspringParents(offspringList, birdInfo[0], oldBirdId); //send the string list to UpdateOffspringList
                                LogIn.DataBaseExcel.WriteCell("P" + i, offspringList); //update database with new offspring list
                                count++;
                            }
                            else if (!edited) {
                                if ((LogIn.DataBaseExcel.ReadCell("P" + i)).Equals("none")) //if mom doesnt have offsprings yet
                                    LogIn.DataBaseExcel.WriteCell("P" + i, birdInfo[0]); //add offspring id to mom
                                else
                                {//if mom has offsprings we add another one to existing list of offspring ids
                                    string offspringList = LogIn.DataBaseExcel.ReadCell("P" + i) + "|" + birdInfo[0];//add offspring id to mom
                                    offspringList = SortOffspringList(offspringList); //sorts the string if necessary
                                    LogIn.DataBaseExcel.WriteCell("P" + i, offspringList); //add offspring id to mom in database
                                }
                                count++;
                            }
                        }
                    }
                    if (birdInfo[8].Equals("no")) //break if we have regular bird
                    {
                        List<Bird> oldBird = MainWindow.HashTable.SearchBirdHashtable(oldBirdId); //search old bird
                        if (!edited) //if we dont edit we break 
                            break;
                        //if id has been changed, if we changed the id in all offsprings(in list) + 1 for current index we break
                        else if (edited && !(oldBirdId.Equals(birdInfo[0])) && count == oldBird[0].OffspringList.Count + 1)
                            break;
                        else if (edited && oldBirdId.Equals(birdInfo[0]) && count == 1)  //if we edit, we search currect index in database and then break
                            break;
                    }
                    if (birdInfo[8].Equals("yes")) //break if we have offspring
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
                    MainWindow.HashTable.AddBirdToHashtable(newBird); //add bird to hashtable (addes the bird to cage as well because of refernce)
                    ((MainWindow)this.Parent.Parent).setBirdsLabel((LogIn.DataBaseExcel.GetLastRow(7) - 1).ToString());
                    if (!(LogIn.DataBaseExcel.ReadCell("G2").Equals("")))//if we have only one bird we dont need sort
                    {
                        /// here we need to build hashtable again if new id isnt in sorted order of id's ///
                        if (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (LogIn.DataBaseExcel.GetLastRow(7) - 2))) > int.Parse(birdInfo[0]))
                        {
                            MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                            MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                            MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                        }
                    }
                }
                else //means we edit the current bird so we add new info to current index in database
                {
                    LogIn.DataBaseExcel.WriteRange(currentBirdRow, 7, 16, birdInfo); //add new info to current bird
                    List<Bird> currentBird = MainWindow.HashTable.SearchBirdHashtable(oldBirdId);
                    currentBird[0].EditFields(birdInfo); //edit the bird in hashtable
                    /// here we need to build hashtable again if new id isn't in sorted order of id's ///
                    if (!(oldBirdId.Equals(birdInfo[0])))
                    {
                        MainWindow.HashTable.RemoveBirdFromHashtable(oldBirdId); //remove old bird id hashcode from hashtable
                        MainWindow.HashTable.AddBirdIdToHashtable(currentBird[0]); //add the updated bird id to hashtable
                        if (currentBird[0].OffspringList.Count != 0) //if bird has offsprings we change the id in all of them
                        {
                            foreach (Bird b in currentBird[0].OffspringList) //goes through all offsprings and updating the id
                            {
                                if (b.DadId.Equals(oldBirdId))
                                    b.DadId = birdInfo[0];
                                else if (b.MomId.Equals(oldBirdId))
                                    b.MomId = birdInfo[0];
                            }
                        }
                        if (!(LogIn.DataBaseExcel.ReadCell("G2").Equals("")))//if we have only one bird we dont need sort
                        {
                            if ((currentBirdRow == 1)
                            && (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow + 1))) < int.Parse(birdInfo[0])))
                            {
                                MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                                MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                                MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                            }
                            else if ((currentBirdRow == (LogIn.DataBaseExcel.GetLastRow(7) - 1))
                            && (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow - 1))) > int.Parse(birdInfo[0])))
                            {
                                MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                                MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                                MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                            }
                            else if (currentBirdRow != 1 && (currentBirdRow != LogIn.DataBaseExcel.GetLastRow(7) - 1)
                            && ((int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow - 1))) > int.Parse(birdInfo[0]))
                            || (int.Parse(LogIn.DataBaseExcel.ReadCell("G" + (currentBirdRow + 1))) < int.Parse(birdInfo[0]))))
                            {
                                MainWindow.SortExcel("bird");//calls SortExcel from MainWindow
                                MainWindow.HashTable.ClearBirdCageHashtable();//clear the hashtables of bird and cage
                                MainWindow.InitHashtable(); //calling initHashtable for bird and cage hashtables
                            }
                        }
                    }
                }
            }
            LogIn.DataBaseExcel.Quit();//close excel
            return true;
        }
    

        public string SortOffspringList(string offspringList) //method to sort the offspringList in database if necessary
        {
            string[] splittedList = offspringList.Split('|'); //splits the string 
            //checks if we need to sort, if last element is smaller then previous. if not it does nothing
            if (int.Parse(splittedList[splittedList.Length - 1]) < int.Parse(splittedList[splittedList.Length - 2]))
            {
                Array.Sort(splittedList, (x, y) => int.Parse(x).CompareTo(int.Parse(y)));
                offspringList = string.Join("|", splittedList);
            }
            return offspringList; //retuens new sorted string
        }

        public string UpdateOffspringParents(string offspringList, string newBirdId, string oldBirdId)
        {
            string[] splittedList = offspringList.Split('|'); //splits the string 
            int index = Array.IndexOf(splittedList, oldBirdId); //get the index of old id in string array
            if (index > -1) //if index found we change to new id and sort if necessary
            {
                splittedList[index] = newBirdId; //insets the new id to old id position in array
                //if the new id isn't in sorted order of array we sort 
                if (splittedList.Length > 1)
                {
                    if (index == 0 && (int.Parse(splittedList[index]) > int.Parse(splittedList[index + 1])))
                    {
                        Array.Sort(splittedList, (x, y) => int.Parse(x).CompareTo(int.Parse(y))); //sorts the string
                    }
                    else if(index == (splittedList.Length - 1) && (int.Parse(splittedList[index]) < int.Parse(splittedList[index - 1])))
                    {
                        Array.Sort(splittedList, (x, y) => int.Parse(x).CompareTo(int.Parse(y))); //sorts the string
                    }
                    else if (index != 0 && index != (splittedList.Length - 1) && ((int.Parse(splittedList[index]) < int.Parse(splittedList[index - 1]))
                    || (int.Parse(splittedList[index]) > int.Parse(splittedList[index + 1]))))
                    {
                        Array.Sort(splittedList, (x, y) => int.Parse(x).CompareTo(int.Parse(y))); //sorts the string
                    }
                }
                offspringList = string.Join("|", splittedList);
            }
            return offspringList; //retuens new sorted string
        }

        public void cleanTextBoxes()
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

        public bool checkDadId(string dadId)
        {
            List<Bird> dadBird = MainWindow.HashTable.SearchBirdHashtable(dadId); 
            if (dadBird.Count != 0)
            {
                if (dadBird[0].isOffspring)
                {
                    CustomMessageBox.Show("Dad's id is an id of a fledgiling, he cannot yet be a dad.", "Dad Id Error");
                    return false;
                }
                else if (dadBird[0].Gender == "Female")
                {
                    CustomMessageBox.Show("Dad's id must be an id of a Male bird!", "Dad Id Error");
                    return false;
                }
            }

            return true;
        }

        public bool checkMomId(string momId)
        {
            List<Bird> momBird = MainWindow.HashTable.SearchBirdHashtable(momId);
            if (momBird.Count != 0)
            {
                if (momBird[0].isOffspring)
                {
                    CustomMessageBox.Show("Mom's id is an id of a fledgiling, she cannot yet be a Mom.", "Mom Id Error");
                    return false;
                }
                else if (momBird[0].Gender == "Male")
                {
                    CustomMessageBox.Show("Mom's id must be an id of a Female bird!", "Mom Id Error");
                    return false;
                }
            }

            return true;
        }

        public bool checkBirdId(string birdId)
        {
            List<Bird> currentBird = MainWindow.HashTable.SearchBirdHashtable(birdId);
            if (currentBird.Count != 0)
            {
                CustomMessageBox.Show("The bird you are trying to add already exists in the database, try a different id.", "Error");
                return false;
            }

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
            List<Cage> SomeCagesList = MainWindow.HashTable.SearchCageHashtable("WOOD");
            if (SomeCagesList.Count != 0)
                return SomeCagesList[0].Id;
            else
            {
                SomeCagesList = MainWindow.HashTable.SearchCageHashtable("METAL");
                if (SomeCagesList.Count != 0)
                    return SomeCagesList[0].Id;
                else
                {
                    SomeCagesList = MainWindow.HashTable.SearchCageHashtable("PLASTIC");
                    return SomeCagesList[0].Id;
                }
            }
        }

        /// <summary>
        /// When adding an offspring to an existing bird we need to define which parent the user needs to 
        /// add, if we are adding an offspring to a male bird then the other parent needs to be a female.
        /// This function performs all of the nessecary checks to ensure we can later add the bird into
        /// the database safely.
        /// </summary>
        /// <returns>true is the parents details are correct, false otherwise</returns>
        private bool CheckParent()
        {
            string parentType = "", errorMessage = "-1", parentGender, parentId;

            // we want to know which parent's id we need to check
            if (dadBox.ReadOnly == true)//if dad is locked, we know we need to check moms id
            {
                parentType = "mom";
                parentId = momBox.Text;
                parentGender = "Female";
            }

            else if (momBox.ReadOnly == true)
            {
                parentType = "dad";
                parentId = dadBox.Text;
                parentGender = "Male";
            }
            else // we have an undefined error
            {
                return false;
            }

            List<Bird> parentBird = MainWindow.HashTable.SearchBirdHashtable(parentId);

            if (parentBird.Count != 0)
            {
                if (parentBird[0].Gender != parentGender)
                {
                    errorMessage = "Other parent must be " + parentGender.ToLower() + "!";
                }
                else if (parentBird[0].CageId != cageIdBox.Text)
                {
                    errorMessage = "Parents must be in the same cage!";
                }
                else if (parentBird[0].Type != typeBox.Text)
                {
                    errorMessage = "Parents must have same type!";
                }
                else if (parentBird[0].isOffspring)
                {
                    errorMessage = "Parents must be adults!";
                }
            }
            else
                errorMessage = "There is no bird that is a " + parentGender + " with that id, try again.";
            

            if (errorMessage != "-1")
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

            if (AddBird_label.Text == "Add an Offspring:")//if we add offspring we change it to yes
            { 
                isOffspring = true;
                if (CheckParent() == false)
                    return;
            }

            if (getInfoFromUser(getTextFromUi(isOffspring)))
            {
                cleanTextBoxes();
                makeNotReadOnly();
                ((MainWindow)this.Parent.Parent).homePage1.Show();
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (AddBird_label.Text == "Add an Offspring:")
            {
                ((MainWindow)this.Parent.Parent).showBackBtn();
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();

                makeNotReadOnly();
            }
            else
            {
                ((MainWindow)this.Parent.Parent).homePage1.Show();
            }
            cleanTextBoxes();
            this.Hide();
        }

        public void makeReadOnly(string type, string subType, string cageId, string gender, string parentId)
        {
            AddBird_label.Text = "Add an Offspring:";

            typeBox.Text = type;
            typeBox.ReadOnly = true;

            subTypeBox.Text = subType;
            subTypeBox.ReadOnly = true;

            cageIdBox.Text = cageId;
            cageIdBox.ReadOnly = true;

            if (gender == "Male")
            {
                dadBox.Text = parentId;
                dadBox.ReadOnly = true;
            }
            else
            {
                momBox.Text = parentId;
                momBox.ReadOnly = true;
            }
        }

        public void makeNotReadOnly()
        {
            AddBird_label.Text = "Add a Bird:";
            typeBox.ReadOnly = false;
            subTypeBox.ReadOnly = false;
            cageIdBox.ReadOnly = false;

            if (dadBox.ReadOnly == true)
                dadBox.ReadOnly = false;
            else
                momBox.ReadOnly = false;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private string[] getTextFromUi()
        {
            string[] birdInfo = new string[9];

            birdInfo[0] = idBox.Text.ToString();
            birdInfo[1] = typeBox.Text.ToString();
            birdInfo[2] = subTypeBox.Text.ToString();
            birdInfo[3] = dateBox.Text.ToString();
            birdInfo[4] = genderBox.Text.ToString();
            birdInfo[5] = cageIdBox.Text.ToString();
            birdInfo[6] = dadBox.Text.ToString();
            birdInfo[7] = momBox.Text.ToString();

            return birdInfo;
        }

        public bool getInfoFromUser(string[] birdInfo, string isOffspring, bool edited = false)
        {
            birdInfo[8] = isOffspring; // can be "yes" or "no"

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
            else
            {
                Excel ex = new Excel("database", MainWindow.UserSheet);
                ex.WriteRange(ex.GetLastRow(7), 7, 15, birdInfo);
                if (!edited)
                    ((MainWindow)this.Parent.Parent).setBirdsLabel((ex.GetLastRow(7) - 1).ToString());
                ex.Quit();
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
            string isOffspring = "no"; //default is no for addBird
            int flag = 0;

            if (AddBird_label.Text == "Add an Offspring:")//if we add offspring we change it to yes
            { 
                isOffspring = "yes";
                if (CheckParent() == false)
                    flag = 1;
            }
            if (flag == 0)
            {
                if (getInfoFromUser(getTextFromUi(), isOffspring))
                {
                    MainWindow.SortExcel("bird");//! here I call my sorting method!///
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

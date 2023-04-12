using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class AddBird : UserControl
    {
        public AddBird()
        {
            InitializeComponent();
        }

        private bool getInfoFromUser()
        {

            string[] birdInfo = new string[8];

            birdInfo[0] = idBox.Text.ToString();
            birdInfo[1] = typeBox.Text.ToString();
            birdInfo[2] = subTypeBox.Text.ToString();
            birdInfo[3] = dateBox.Text.ToString();
            birdInfo[4] = genderBox.Text.ToString();
            birdInfo[5] = cageIdBox.Text.ToString();
            birdInfo[6] = dadBox.Text.ToString();
            birdInfo[7] = momBox.Text.ToString();

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

            if (birdInfo[4] == "m" || birdInfo[4] == "male")
            {
                birdInfo[4] = "Male";
            } else if (birdInfo[4] == "f" || birdInfo[4] == "female")
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
                    CustomMessageBox.Show("The cage id you have typed does not belong to you, enter a cage id that you own.","Error");
                    return false;
                }
                else if (!checkBirdId(birdInfo[0])) { return false; }
                //else if (!checkDateOfBirth()) { return false; } //add this function
                else if (birdInfo[6] != "")
                {
                    if (!(Regex.IsMatch(birdInfo[6], idPattern)))
                    {
                        errorMessage = "The dad's id must ONLY contain numbers.";
                        flag = 1;
                    }
                }
                else if (birdInfo[7] != "")
                {
                    if (!(Regex.IsMatch(birdInfo[7], idPattern)))
                    {
                        errorMessage = "The mom's id must ONLY contain numbers.";
                        flag = 1;
                    }
                }
            }

            if (flag == 1)
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            } else 
            {
                Excel ex = new Excel("database", MainWindow.UserSheet);
                ex.WriteRange(ex.GetLastRow(7), 7, 14, birdInfo);
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

        private bool checkBirdId(string birdId)
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
            }
            ex.Quit();
            return true;

        }

        private bool checkType(string type)
        {
            if (type != "American Gouldian" && type != "European Gouldian" && type != "Australian Gouldian") 
            { 
                CustomMessageBox.Show("Error, the bird's type is incorrect, try again.","Error");
                return false;
            }
            return true;
        }

        private bool checkSubType(string type, string subType)
        {
            if (
                ( type == "American Gouldian" && 
                    (subType != "North America" && subType != "Center America" && subType != "South America") ) ||
                ( type == "Europe Gouldian" &&
                    (subType != "East European" && subType != "West European") ) ||
                ( type == "Australian Gouldian" && 
                    (subType != "Center Australia" && subType != "Coastal Cities") ) 
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (getInfoFromUser())
            {
                cleanTextBoxes();
                ((MainWindow)this.Parent.Parent).homePage1.Show();
                this.Hide();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            ((MainWindow)this.Parent.Parent).homePage1.Show();
            this.Hide();
        }
    }
}

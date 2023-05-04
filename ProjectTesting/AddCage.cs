using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectTesting
{
    public partial class AddCage : UserControl
    {
        public AddCage()
        {
            InitializeComponent();
        }

        private Cage getTextFromUi()
        {
            Cage cageInfo = new Cage(new string[]
            {
                idBox.Text.ToString(),
                lengthBox.Text.ToString(),
                widthBox.Text.ToString(),
                heightBox.Text.ToString(),
                materialBox.Text.ToString()
            });

            return cageInfo;
        }

        public bool getInfoFromUser(Cage cage, bool edited = false)
        {
            string[] cageInfo = cage.ToStringArray(); //convert cage to string array
            int flag = 0;
            string errorMessage = "";
            string idPattern = "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$"; // checks for atleast one letter AND atleast one number

            for (int j = 0; j < 5; j++)
            {
                if (cageInfo[j] == "")
                {
                    errorMessage = "Please enter all of the information into the form.";
                    flag = 1;
                }
            }

            if (cageInfo[4] == "Wood" || cageInfo[4] == "wood") { cageInfo[4] = "WOOD"; }
            else if (cageInfo[4] == "Metal" || cageInfo[4] == "metal") { cageInfo[4] = "METAL"; }
            else if (cageInfo[4] == "Plastic" || cageInfo[4] == "plastic") { cageInfo[4] = "PLASTIC"; }

            if (flag == 0)
            {
                if (!(Regex.IsMatch(cageInfo[0], idPattern)))
                {
                    errorMessage = "The cage id must contain letters and numbers.";
                    flag = 1;
                }
                else if (!checkDimentions(cageInfo))
                {
                    return false;
                }
                else if (cageInfo[4] != "WOOD" && cageInfo[4] != "METAL" && cageInfo[4] != "PLASTIC")
                {
                    errorMessage = "Cage can only be made out of WOOD, METAL or PLASTIC.";
                    flag = 1;
                }
            }

            if (flag == 1)
            {
                CustomMessageBox.Show(errorMessage, "Error");
                return false;
            }

            if (!edited)
            {
                if (!checkCageId(cageInfo[0]))
                {
                    CustomMessageBox.Show("The cage you are trying to add already exists in the database, try a different id.", "Error");
                    return false;
                }
            }

            
            Excel ex = new Excel("database", MainWindow.UserSheet);
            ex.WriteRange(ex.GetLastRow(), 1, 5, cageInfo);
            if (!edited)
                ((MainWindow)this.Parent.Parent).setCagesLabel((ex.GetLastRow() - 1).ToString());
            ex.Quit();
            

            return true;
            
        }

        private void cleanTextBoxes()
        {
            idBox.Text = "";
            lengthBox.Text = "";
            widthBox.Text = "";
            heightBox.Text = "";
            materialBox.Text = "";
        }

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

        public bool checkCageId(string cageId)
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow();
            string idValue;
            for (int i = 1; i < row; i++)
            {
                idValue = ex.ReadCell("A" + i);
                if (idValue == cageId)
                {
                    ex.Quit();
                    return false;
                }
            }

            ex.Quit();
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (getInfoFromUser(getTextFromUi()))
            {
                MainWindow.SortExcel("cage"); //calls out function from addBird
                cleanTextBoxes();
                ((MainWindow)this.Parent.Parent).homePage1.Show();
                setWelcome_lable(false);
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            ((MainWindow)this.Parent.Parent).homePage1.Show();
            setWelcome_lable(false);
            this.Hide();
        }

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

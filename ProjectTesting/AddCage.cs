﻿using Microsoft.Office.Interop.Excel;
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

        private bool getInfoFromUser()
        {

            string[] cageInfo = new string[5];

            cageInfo[0] = idBox.Text.ToString();
            cageInfo[1] = lengthBox.Text.ToString();
            cageInfo[2] = widthBox.Text.ToString();
            cageInfo[3] = heightBox.Text.ToString();
            cageInfo[4] = materialBox.Text.ToString();

            int flag = 0;
            string idValue, errorMessage = "";
            string idPattern = "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$"; // checks for atleast one letter AND atleast one number

            for (int j = 0; j < 5; j++)
            {
                if (cageInfo[j] == "")
                {
                    errorMessage = "Please enter all of the information into the form.";
                    flag = 1;
                }
            }

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
                else if (cageInfo[4] != "Wood" && cageInfo[4] != "Metal" && cageInfo[4] != "Plastic")
                {
                    errorMessage = "Cage can only be made out of Wood, Metal or Plastic.";
                    flag = 1;
                }
            }

            if (flag == 1)
            {
                MessageBox.Show(errorMessage);
                return false;
            }

            if (!checkCageId(cageInfo[0])) 
            {
                MessageBox.Show("The cage you are trying to add already exists in the database, try a different id.");
                return false; 
            }
            else
            {
                Excel ex = new Excel("database", MainWindow.UserSheet);
                ex.WriteRange(ex.GetLastRow(), 1, 5, cageInfo);
                ex.Quit();
            }

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
                MessageBox.Show(errorMessage);
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

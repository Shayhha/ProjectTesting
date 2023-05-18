using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\parrot.ico");
            Text = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void initDash()
        {
            clearDash();
            LogIn.DataBaseExcel = new Excel("database", MainWindow.UserSheet);
            string[] temp;
            string newStr;

            usernameLabel.Text = "Hello " + MainWindow.UserSheet;
            birdsLabel.Text = "You have " + (LogIn.DataBaseExcel.GetLastRow(7) - 1).ToString() + " birds:";
            cagesLabel.Text = "You have " + (LogIn.DataBaseExcel.GetLastRow(0) - 1).ToString() + " cages:";

            for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(); i++)
            {
                temp = LogIn.DataBaseExcel.ReadRange(i, 1, 5);
                newStr = "Cage ID: " + temp[0] + " , Length: " + temp[1] + " , Width: " + temp[2] + " , Height: " + temp[3] + " , Material: " + temp[4];
                cagesList.Items.Add(newStr);
            }

            for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(7); i++)
            {
                temp = LogIn.DataBaseExcel.ReadRange(i, 7, 15);
                newStr = "Bird ID: " + temp[0] + " , Type: " + temp[1] + " , Gender: " + temp[4] + " , Cage ID: " + temp[5] + " , fledgling: " + temp[8];
                birdsList.Items.Add(newStr);
            }

            LogIn.DataBaseExcel.Quit();
        }

        public void clearDash()
        {
            cagesList.Items.Clear();
            birdsList.Items.Clear();
        }
    }
}

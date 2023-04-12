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
        }

        public void initDash()
        {
            clearDash();
            Excel ex = new Excel("database", MainWindow.UserSheet);
            string[] temp;
            string newStr;

            usernameLabel.Text = MainWindow.UserSheet;
            birdsLabel.Text = "You have " + (ex.GetLastRow(7) - 1).ToString() + " birds:";
            cagesLabel.Text = "You have " + (ex.GetLastRow(0) - 1).ToString() + " birds:";

            for (int i = 1; i < ex.GetLastRow(); i++)
            {
                temp = ex.ReadRange(i, 1, 5);
                newStr = "Cage ID: " + temp[0] + " , Length: " + temp[1] + " , Width: " + temp[2] + " , Height: " + temp[3] + " , Material: " + temp[4];
                cagesList.Items.Add(newStr);
            }

            for (int i = 1; i < ex.GetLastRow(7); i++)
            {
                temp = ex.ReadRange(i, 7, 15);
                newStr = "Bird ID: " + temp[0] + " , Type: " + temp[1] + " , Gender: " + temp[4] + " , Cage ID: " + temp[5] + " , Adult: " + temp[8];
                birdsList.Items.Add(newStr);
            }

            ex.Quit();
        }

        public void clearDash()
        {
            cagesList.Items.Clear();
            birdsList.Items.Clear();
        }
    }
}

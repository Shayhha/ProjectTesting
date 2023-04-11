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
    public partial class SearchBird : UserControl
    {
        public SearchBird()
        {
            InitializeComponent();//
        }



        public void Search(string name)
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = ex.GetLastRow(7);
            string[] temp = null;
            int flag = 0;
            birdList.Items.Clear(); // deleting all of the previous items from the list

            for (int i = 1; i < size; i++)
            {
                temp = ex.ReadRange(i, 7, 14);
                if (temp.Contains(name))
                {
                    string newStr = "Bird ID: " + temp[0] + " , Type: " + temp[1] + " , Gender: " + temp[4] + " , Cage ID: " + temp[5] + " | Click for more details";
                    birdList.Items.Add(newStr);
                    flag = 1;
                }
            }
            ex.Quit();
            if (flag == 0)
            {
                MessageBox.Show("Error, no matching results for " + name);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ClearList();
            Search(name);
        }
        public void ClearList() //clears all items in list 
        {
            birdList.Items.Clear();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((MainWindow)this.Parent).homePage1.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Search_textbox.Text = "";
            this.Hide();
            //MainWindow.homePage1.Show();
            ((MainWindow)this.Parent).homePage1.Show();
        }
    }
}

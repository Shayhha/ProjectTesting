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
            InitializeComponent();
        }



        public bool Search(string name, string combo)
        {
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = 0;
            string[] temp = null;
            int flag = 0;
            birdList.Items.Clear(); // deleting all of the previous items from the list
            if (combo == "" && name == "")
            {
                CustomMessageBox.Show("Error, You have to write somthing in search box and choose search type!", "Search Error");
                ex.Quit();
                return false;
            }
            else if (combo == "")
            {
                CustomMessageBox.Show("Error, choose search type!", "Type Error");
                ex.Quit();
                return false;
            }
            else
            {
                if (combo == "Bird")
                {
                    size = ex.GetLastRow(7);
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
                }
                else if (combo == "Cage")
                {
                    size = ex.GetLastRow(1);
                    for (int i = 1; i < size; i++)
                    {
                        temp = ex.ReadRange(i, 1, 5);
                        if (temp.Contains(name))
                        {
                            string newStr = "Cage ID: " + temp[0] + " , Length: " + temp[1] + " , Width: " + temp[2] + " , Height: " + temp[3] + " , Material: " + temp[4] + " | Click for more details";
                            birdList.Items.Add(newStr);
                            flag = 1;
                        }
                    }
                }
            }

            if (flag == 0)
            {
                CustomMessageBox.Show("Error, no matching results for " + name, "Search Error");
                ex.Quit();
                return false;
            }
            ex.Quit();
            return true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ClearList();
            string combo = comboBox.Text;
            Search(name, combo);
        }
        public void ClearList() //clears all items in list 
        {
            birdList.Items.Clear();
        }

    }
}

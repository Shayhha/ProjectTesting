using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTesting
{
    public partial class SearchBird : UserControl
    {
        public SearchBird()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            string text = "( search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id )";
            System.Windows.Forms.ToolTip SearchRequirementsToolTip = new System.Windows.Forms.ToolTip();
            SearchRequirementsToolTip.InitialDelay = 0; // Set the delay before the ToolTip appears
            SearchRequirementsToolTip.OwnerDraw = true; // Enable owner drawing of the ToolTip
            SearchRequirementsToolTip.Draw += SearchRequirementsToolTip_Draw; // Handle the Draw event to draw the ToolTip
            SearchRequirementsToolTip.Popup += SearchRequirementsToolTip_Popup;
            SearchRequirementsToolTip.SetToolTip(Search_textbox, text);
        }

        private void SearchRequirementsToolTip_Draw(object sender, DrawToolTipEventArgs e) //sets font size of ToolTip and the background
        {
            // Set the font size of the text in the ToolTip
            Font font = new Font(e.Font.FontFamily, 12);

            // Draw the background and border of the ToolTip
            e.DrawBackground();
            e.DrawBorder();

            // Draw the text in the ToolTip using the specified font
            e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, e.Bounds);
        }

        private void SearchRequirementsToolTip_Popup(object sender, PopupEventArgs e) //sets size of ToolTip
        {
            e.ToolTipSize = new Size(400, 85);
        }



        public int Search(string name, string combo) //remeber this method was boolean
        {
            birdList.Hide();
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = 0;
            string[] temp = null;
            int flag = 0;
            birdList.Items.Clear(); // deleting all of the previous items from the list
            string[] DefaultCombo = { "Bird", "Cage" };//we will use this array to check combo
            if (combo == "" && name == "")
            {
                CustomMessageBox.Show("You have to write somthing in search box and choose search type!", "Search Error");
                ex.Quit();
                return -1;
            }
            else if (combo == "")
            {
                CustomMessageBox.Show("Choose search type!", "Type Error");
                ex.Quit();
                return -1;
            }
            else if (name == "")
            {
                CustomMessageBox.Show("Search field empty!", "Search Error");
                ex.Quit();
                return -1;
            }
            else if (!DefaultCombo.Contains(combo))
            {
                CustomMessageBox.Show("There's no search type named \"" + combo + "\" \n(Please choose a search type from the box with the arrow)", "Error");
                ex.Quit();
                return -1;
            }
            else
            {
                if (combo == "Bird")
                {
                    size = ex.GetLastRow(7);
                    if (name == "m" || name == "M" || name == "male")
                        name = "Male";
                    else if (name == "f" || name == "F" || name == "female")
                        name = "Female";

                    for (int i = 1; i < size; i++)
                    {
                        temp = ex.ReadRange(i, 7, 12);
                        string[] searchTemp = { temp[0], temp[1], temp[2], temp[3], temp[4] };//only searching specific things
                        if (searchTemp.Contains(name))
                        {
                            string newStr = "Bird ID: " + temp[0] + " , Type: " + temp[1] + " , Gender: " + temp[4] + " , Cage ID: " + temp[5] + " | Click for more details";
                            birdList.Items.Add(newStr);
                            flag++;
                        }
                    }
                }
                else if (combo == "Cage")
                {
                    size = ex.GetLastRow(1);
                    if (name.ToUpper() == "WOOD")
                        name = "WOOD";
                    else if (name.ToUpper() == "METAL")
                        name = "METAL";
                    else if (name.ToUpper() == "PLASTIC")
                        name = "PLASTIC";

                    for (int i = 1; i < size; i++)
                    {
                        temp = ex.ReadRange(i, 1, 5);
                        string[] searchTemp = { temp[0], temp[4] }; //only searching specific things
                        if (searchTemp.Contains(name))
                        {
                            string newStr = "Cage ID: " + temp[0] + " , Length: " + temp[1] + " , Width: " + temp[2] + " , Height: " + temp[3] + " , Material: " + temp[4] + " | Click for more details";
                            birdList.Items.Add(newStr);
                            flag++;
                        }
                    }
                }
            }

            if (flag == 0)
            {
                CustomMessageBox.Show("No matching results for \"" + name + "\"", "Search Error");
                ex.Quit();
                return -1;
            }
            else if (flag == 1)
            {
                //if we have only one search result
                ex.Quit();
                return 1;
            }
            else
            {
                birdList.Show();
            }
            ex.Quit();
            return 0;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ClearList();
            string combo = comboBox.Text;
            int SearchResult = Search(name, combo);
            if (SearchResult == 1)
            {
                string text = birdList.Items[0].ToString(); //gets text in selected index
                ItemSelected(text);
                ClearList();
            }
            
        }
        public void ClearList() //clears all items in list 
        {
            birdList.Items.Clear();
        }

        private void birdList_SelectedIndexChanged(object sender, EventArgs e) //this method handles items in list
        {
            string text = birdList.Items[birdList.SelectedIndex].ToString(); //gets text in selected index
            ItemSelected(text);
        }

        public void ItemSelected(string text)
        {
            if (text.Split(",")[0].Split(" ")[0] == "Bird")
            {
                string birdId = text.Split(",")[0].Split(" ")[2].ToString(); //gets the bird id using split method
                ((MainWindow)this.Parent.Parent).moreDetails1.initLabels(birdId);
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();
                this.Hide();
            }
            else if (text.Split(",")[0].Split(" ")[0] == "Cage")
            {
                string cageId = text.Split(",")[0].Split(" ")[2].ToString(); //gets the bird id using split method
                ((MainWindow)this.Parent.Parent).moreDetails1.initLabels(cageId, "cage");
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();
                this.Hide();
            }
        }

    }
}

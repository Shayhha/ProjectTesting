﻿
namespace ProjectTesting
{
    public partial class SearchBird : UserControl
    {
        public SearchBird()
        {
            InitializeComponent();
            searchBySwitch.Checked = false;
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



        public int Search(string name, bool combo) //remeber this method was boolean
        {
            birdList.Hide();
            int flag = 0;
            birdList.Items.Clear(); // deleting all of the previous items from the list
            if (name == "")
            {
                CustomMessageBox.Show("Search field is empty!", "Search Error");
                return -1;
            }
            else
            {
                if (combo == false) // false is searching for birds
                {
                    if (name == "m" || name == "M" || name == "male")
                        name = "Male";
                    else if (name == "f" || name == "F" || name == "female")
                        name = "Female";

                    List<Bird> birds = MainWindow.HashTable.SearchBirdHashtable(name);
                    foreach (Bird bird in birds)
                    {
                        string newStr = "Bird ID: " + bird.Id + " , Type: " + bird.Type + " , Gender: " + bird.Gender + " , Cage ID: " + bird.CageId + " | Click for more details";
                        birdList.Items.Add(newStr);
                        flag++;
                    }
                }
                else if (combo == true) // true is searching for cages
                {
                    if (name.ToUpper() == "WOOD")
                        name = "WOOD";
                    else if (name.ToUpper() == "METAL")
                        name = "METAL";
                    else if (name.ToUpper() == "PLASTIC")
                        name = "PLASTIC";

                    List<Cage> cages = MainWindow.HashTable.SearchCageHashtable(name);
                    foreach (Cage cage in cages)
                    {
                        string newStr = "Cage ID: " + cage.Id + " , Length: " + cage.Length + " , Width: " + cage.Width + " , Height: " + cage.Height + " , Material: " + cage.Material + " | Click for more details";
                        birdList.Items.Add(newStr);
                        flag++;
                    }
                }
            }

            if (flag == 0)
            {
                CustomMessageBox.Show("No matching results for \"" + name + "\"", "Search Error");
                return -1;
            }
            else if (flag == 1)
            {
                //if we have only one search result
                return 1;
            }
            else
            {
                birdList.Show();
            }
            return 0;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ClearList();
            bool searchSwitch = searchBySwitch.Checked;
            int SearchResult = Search(name, searchSwitch);
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
            // if the user were to click on a blank space in the list, the program would crash, thats why we
            // need to check if the selected index is not -1, -1 is a non existing index and is used to catch errors
            if (birdList.SelectedIndex != -1)
            {
                string text = birdList.Items[birdList.SelectedIndex].ToString(); //gets text in selected index
                ItemSelected(text);
            }
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

        public void cleanTextboxAndList()
        {
            ClearList();
            Search_textbox.Text = "";
        }

        public void setTextAndSwitch(string text, bool option) // this function transfers the text and search switch position from homepage to searchBird window 
        {
            Search_textbox.Text = text;
            searchBySwitch.Checked = option;
        }
    }
}

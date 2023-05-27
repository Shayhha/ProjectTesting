
namespace ProjectTesting
{
    /// <summary>
    /// This class is a UserControl and it shows the user the results of his search. It has a seach-bar, a search button and a list
    /// of potential results, it also has a switch to switch between searching for birds and cages.
    /// </summary>
    public partial class SearchWindow : UserControl
    {
        public SearchWindow()
        {
            InitializeComponent();
            searchBySwitch.Checked = false;

            // This ToolTip helps the user know what he can search for and what he cant
            string text = "search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id.";
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


        /// <summary>
        /// This is the main seach function of our program, it is used both in the MainWindow and in the SearchWindow.
        /// It searches for the users input in the hashtables that we create from the database when the user logs into the application.
        /// Our hashtables allow us to search via a few different parameters, for example the bird's id, the gender, the type, subtype and date of bird. 
        /// And for the cages its cage id or cage material.
        /// </summary>
        /// <param name="name">the text that the user inputed to search by</param>
        /// <param name="combo">the users choosen search catagory, if false then search for birds, if true search for cages</param>
        /// <returns></returns>
        public int Search(string name, bool combo) //remeber this method was boolean
        {
            birdList.Hide();
            int flag = 0;
            birdList.Items.Clear(); // deleting all of the previous items from the list
            if (name == "") // checking that the search field was not empty
            {
                CustomMessageBox.Show("Search field is empty!", "Search Error");
                return -1;
            }
            else
            {
                if (combo == false) // false is searching for birds
                {
                    // we wanted to allow the user to quickly search by gender using one letter, m for male and f for female, but our
                    // hashtables are working with Male and Female, so we need to do a convertion here befor seaching the hashtable
                    if (name == "m" || name == "M" || name == "male")
                        name = "Male";
                    else if (name == "f" || name == "F" || name == "female")
                        name = "Female";

                    List<Bird> birds = MainWindow.HashTable.SearchBirdHashtable(name); // searching for the bird in the hashtable
                    foreach (Bird bird in birds) // displaying all of the found birds into the list of birds
                    {
                        string newStr = "Bird ID: " + bird.Id + " , Type: " + bird.Type + " , Gender: " + bird.Gender + " , Cage ID: " + bird.CageId + " | Click for more details";
                        birdList.Items.Add(newStr);
                        flag++;
                    }
                }
                else if (combo == true) // true is searching for cages
                {
                    // we wanted to allow the user to seach for material using wood, metal and plastic, without having to write in capslock, 
                    // our hashtable works with capslock names for materials, thats why we need to convert the search string into capslock.
                    if (name.ToUpper() == "WOOD")
                        name = "WOOD";
                    else if (name.ToUpper() == "METAL")
                        name = "METAL";
                    else if (name.ToUpper() == "PLASTIC")
                        name = "PLASTIC";

                    List<Cage> cages = MainWindow.HashTable.SearchCageHashtable(name); // searching for the cage in the hashtable
                    foreach (Cage cage in cages)
                    {
                        string newStr = "Cage ID: " + cage.Id + " , Length: " + cage.Length + " , Width: " + cage.Width + " , Height: " + cage.Height + " , Material: " + cage.Material + " | Click for more details";
                        birdList.Items.Add(newStr);
                        flag++;
                    }
                }
            }

            if (flag == 0) // if flag is 0 it means that we didnt find what the user was looking for, so we show an error message
            {
                CustomMessageBox.Show("No matching results for \"" + name + "\"", "Search Error");
                return -1;
            }
            else if (flag == 1) // in the case of flag == 1 we know that we only found one item in the hashtable, this means that we need to open the MoreDetails window
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

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ClearList();
            bool searchSwitch = searchBySwitch.Checked;
            int SearchResult = Search(name, searchSwitch);
            if (SearchResult == 1) // search results will be one only if the Search function found exactly ONE search result, in this case we want to open the MoreDetails window
            {
                string text = birdList.Items[0].ToString(); //gets text in selected index
                ItemSelected(text); // opens the MoreDetails window with correct information
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

        /// <summary>
        /// Gets a string of the text in the list of birds/cages, gets the id form the given string, searches for the stirng in the hashtable
        /// and then opens the MoreDetails window and inputs the correct information into it.
        /// </summary>
        /// <param name="text">the string from the list item that was clicked</param>
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

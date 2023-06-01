
namespace ProjectTesting
{
    /// <summary>
    /// This class is a UserControl that is used in our app to show additional information about a bird OR a cage.
    /// This UserControl has two sides that so that only one is visable to the user, that way we can re-use our code and keep the
    /// file system a little bit cleaner. When the user clicks a bird from a list he will see the full information about the bird and
    /// when he clicks a cage he will see full information about the cage. 
    /// This page also allows the user to modify the bird's or cage's info but with some limitations because of logic constraints, for 
    /// example a user cannot edit a bird's gender if this bird already has offsprings, how even a regular adult bird can have its gender 
    /// changed because there might have been an input error by the user.
    /// </summary>
    public partial class MoreDetails : UserControl
    {
        // these objects will be used later in this class to see what information the user edited
        private Bird infoFromDatabaseBird;
        private Cage infoFromDatabaseCage;

        public MoreDetails()
        {
            InitializeComponent();
        }

        public void setImages() // setting the image of the bird to a random image of a bird from our files.
        {
            this.mainPic.Image = getRandomImage();
        }

        private Image getRandomImage() // taking a random image from the files and returning it as an Image object
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 19);
            Image temp = Image.FromFile(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\" + randomNumber.ToString() + ".jpg");
            return temp;
        }

        public void setCageTypeCombobox() // Setting the options into the ComboBox with cage material options
        {
            string[] typeOptions = { "WOOD", "METAL", "PLASTIC" };
            materialValue.Items.Clear();
            materialValue.Items.AddRange(typeOptions);
            materialValue.SelectedItem = "WOOD";
        }

        private void setSubTypeCombobox() // setting subtypes for birds based on the selected type
        {
            subTypeLabel.Items.Clear();

            if (typeLabel.SelectedItem.ToString() == "American Gouldian")
            {
                string[] subTypeOptions = { "North America", "Center America", "South America" };
                subTypeLabel.Items.AddRange(subTypeOptions);
                subTypeLabel.SelectedItem = "North America"; // default value
            }
            else if (typeLabel.SelectedItem.ToString() == "European Gouldian")
            {
                string[] subTypeOptions = { "East Europe", "West Europe" };
                subTypeLabel.Items.AddRange(subTypeOptions);
                subTypeLabel.SelectedItem = "East Europe"; // default value
            }
            else if (typeLabel.SelectedItem.ToString() == "Australian Gouldian")
            {
                string[] subTypeOptions = { "Center Australia", "Coastal Cities" };
                subTypeLabel.Items.AddRange(subTypeOptions);
                subTypeLabel.SelectedItem = "Center Australia"; // default value
            }
        }

        /// <summary>
        /// This function is perponsible for inputing all of the information into the MoreDetails page.
        /// The function has two halfs, the top half is when the user clicked a bird in the list, and the bottom one is when the user
        /// clicked a cage in the list.
        /// </summary>
        /// <param name="id">can be a bird id or a cage id, we will search for it in the hashtables and put the information onto the screen</param>
        /// <param name="birdOrCage">by default is bird, but we pass in cage when we need to search for a cage</param>
        public void initLabels(string id, string birdOrCage = "bird")
        {
            cleanLabels();// needs to recive a param and clean based on that param

            if (birdOrCage.Equals("bird")) //if bird we initialize the brid's info
            {
                cagePanel.Visible = false;
                editBirdButton.Show();
                saveBirdButton.Hide();
                setImages();

                // input the bird types into the combobox
                string[] typeOptions = { "American Gouldian", "European Gouldian", "Australian Gouldian" };
                typeLabel.Items.Clear();
                typeLabel.Items.AddRange(typeOptions);

                // searching for the bird in the hashtable 
                List<Bird> birdInfo = MainWindow.HashTable.SearchBirdHashtable(id); //search bird in hashtable
                infoFromDatabaseBird = birdInfo[0];//save the bird for later use

                //initializing the fields
                idLabel.Texts = birdInfo[0].Id;
                typeLabel.SelectedItem = birdInfo[0].Type;
                setSubTypeCombobox(); // init the subtype combobox
                subTypeLabel.SelectedItem = birdInfo[0].SubType;
                string[] date = birdInfo[0].DateOfBirth.Split("/");
                int d = int.Parse(date[0]), m = int.Parse(date[1]), y = int.Parse(date[2]);
                datePicker.Value = new DateTime(y, m, d); //the date is in the following format: yyyy,mm,dd
                genderLabel.Texts = birdInfo[0].Gender;
                cageIdLabel.Texts = birdInfo[0].CageId;
                dadIdLabel.Texts = birdInfo[0].DadId;
                momIdLabel.Texts = birdInfo[0].MomId;

                //checks if offspring, if not we show a list of offsprings
                if (birdInfo[0].isOffspring)
                {
                    offspringsPanel.Hide();
                    fledglingLabel.Show();
                }
                else if (!birdInfo[0].isOffspring)
                {
                    offspringsPanel.Show();
                    fledglingLabel.Hide();
                }

                foreach (Bird offspring in birdInfo[0].OffspringList) //adding offsprings to list 
                {
                    string newStr = "Bird ID: " + offspring.Id + " , Type: " + offspring.Type + " , Gender: " + offspring.Gender + " , Cage ID: " + offspring.CageId;
                    offspringList.Items.Add(newStr);
                }

            }
            else if (birdOrCage.Equals("cage")) //else we initialize cage's info
            {
                setCageTypeCombobox(); //inputing the cage types into the combobox
                cagePanel.Visible = true;
                List<Cage> cageInfo = MainWindow.HashTable.SearchCageHashtable(id); //search cage in hashtable
                infoFromDatabaseCage = cageInfo[0]; //saving cage for later use

                //filling the fields for cage
                cageValue.Texts = cageInfo[0].Id;
                lengthValue.Texts = cageInfo[0].Length;
                widthValue.Texts = cageInfo[0].Width;
                heightValue.Texts = cageInfo[0].Height;
                materialValue.SelectedItem = cageInfo[0].Material;

                foreach (Bird bird in cageInfo[0].BirdList) //adding birds to list 
                {
                    string newStr = "Bird ID: " + bird.Id + " , Type: " + bird.Type + " , Gender: " + bird.Gender + " , Cage ID: " + bird.CageId;
                    birdList.Items.Add(newStr);
                }

            }
        }

        private void cleanLabels()
        {
            idLabel.Texts = "";
            genderLabel.Texts = "";
            cageIdLabel.Texts = "";
            dadIdLabel.Texts = "";
            momIdLabel.Texts = "";

            cageValue.Texts = "";
            lengthValue.Texts = "";
            widthValue.Texts = "";
            heightValue.Texts = "";
            birdList.Items.Clear();
            offspringList.Items.Clear();
        }

        private void addOffspring_Button_Click(object sender, EventArgs e) //changed to add offspring page
        {
            restoreInfo(); // inputing old information incase the user edited the bird but did not save before clicking away
            setUnedited(); // set the textboxes to the un-edited mode
            ((MainWindow)this.Parent.Parent).addBird1.setTypeCombobox();
            ((MainWindow)this.Parent.Parent).addBird1.setSubTypeCombobox();
            ((MainWindow)this.Parent.Parent).addBird1.makeReadOnly( // this function will decide what textboxes need to be disabled and what to input into them
                typeLabel.Text, subTypeLabel.Text, cageIdLabel.Texts, genderLabel.Texts, idLabel.Texts
            );

            ((MainWindow)this.Parent.Parent).addBird1.Show();
            this.Hide();
            ((MainWindow)this.Parent.Parent).hideBackBtn();
        }

        /// <summary>
        /// Gets all of the text from the screen from the bird side
        /// </summary>
        /// <returns>returns a Bird object with all of the information based on the CURRENT Bird object</returns>
        private Bird getTextFromUiBird()
        {
            Bird newBird = new Bird(infoFromDatabaseBird);

            string[] temp = new string[] {
                idLabel.Texts.ToString(),
                typeLabel.Text,// this is a combobox
                subTypeLabel.Text,// this is a combobox
                datePicker.Text.ToString(),
                genderLabel.Texts.ToString(),
                cageIdLabel.Texts.ToString(),
                dadIdLabel.Texts.ToString(),
                momIdLabel.Texts.ToString()
            };
            newBird.EditFields(temp);

            return newBird;
        }

        /// <summary>
        /// Gets all of the text from the screen from the cage side 
        /// </summary>
        /// <returns>returns a Cage object with all of the information based on the CURRENT Cage object</returns>
        private Cage getTextFromUiCage()
        {
            Cage newCage = new Cage(infoFromDatabaseCage);
            string[] temp = new string[] {
                cageValue.Texts,
                lengthValue.Texts,
                widthValue.Texts,
                heightValue.Texts,
                materialValue.SelectedItem.ToString() // this is a combobox
            };
            newCage.EditFields(temp);

            return newCage;
        }

        // the user wants to edit the bird
        private void editBird_Button_Click(object sender, EventArgs e)
        {
            editBirdButton.Hide();
            saveBirdButton.Show();

            ((MainWindow)this.Parent.Parent).searchWindow1.ClearList();

            datePicker.Enabled = true;
            idLabel.Enabled = true;
            cageIdLabel.Enabled = true;
            dadIdLabel.Enabled = true;
            momIdLabel.Enabled = true;

            List<Bird> bird = MainWindow.HashTable.SearchBirdHashtable(infoFromDatabaseBird.Id); //search bird id in hashtable
            if (bird[0].isOffspring == false && bird[0].OffspringList.Count == 0)
            { //checking if the bird is adult and has no offsprings then we can edit these fields
                typeLabel.Enabled = true;
                subTypeLabel.Enabled = true;
                genderLabel.Enabled = true;
            }

            if (infoFromDatabaseBird.OffspringList.Count > 0 || infoFromDatabaseBird.isOffspring)
            { // if the bird has offsprings OR is itself an offspring then we cannot allow the user to change the cage id of this bird
                cageIdLabel.Enabled = false;
            }

            if (infoFromDatabaseBird.isOffspring)
            {
                dadIdLabel.Enabled = false;
                momIdLabel.Enabled = false;
            }
        }

        private void restoreInfo() // restores the information on the screen back to the original information from the database (hashtable)
        {
            idLabel.Texts = infoFromDatabaseBird.Id;
            typeLabel.SelectedItem = infoFromDatabaseBird.Type;
            subTypeLabel.SelectedItem = infoFromDatabaseBird.SubType;
            string[] date = infoFromDatabaseBird.DateOfBirth.Split("/");
            int d = int.Parse(date[0]), m = int.Parse(date[1]), y = int.Parse(date[2]);
            datePicker.Value = new DateTime(y, m, d); //yyyy,mm,dd
            genderLabel.Texts = infoFromDatabaseBird.Gender;
            cageIdLabel.Texts = infoFromDatabaseBird.CageId;
            dadIdLabel.Texts = infoFromDatabaseBird.DadId;
            momIdLabel.Texts = infoFromDatabaseBird.MomId;
        }

        // when the save button was clicked for the Bird side, the program will check the new information and if everything
        // checks out then it will update the screen and the database
        private void saveBird_Button_Click(object sender, EventArgs e) 
        {
            setUnedited();

            string[] newInfo = getTextFromUiBird().ToStringArray(); //convert Bird to string array for ease of use 
            string[] cleanUp = new string[9];
            for (int i = 0; i < 9; i++) { cleanUp[i] = ""; }
            int flag = 0;

            if (infoFromDatabaseBird.Id != newInfo[0])
            {
                if (!((MainWindow)this.Parent.Parent).addBird1.checkBirdId(newInfo[0]))
                    flag = 1;
            }

            if (flag == 0)
            {
                if (((MainWindow)this.Parent.Parent).addBird1.AddBirdToDatabase(getTextFromUiBird(), true, infoFromDatabaseBird.Id) == true)
                    infoFromDatabaseBird = getTextFromUiBird();
                else
                    restoreInfo();
            }

            if (flag == 1)
                restoreInfo();
        }

        // the user wants to edit the cage
        private void editCage_Button_Click(object sender, EventArgs e)  
        {
            editCageButton.Visible = false;
            saveCageButton.Visible = true;

            ((MainWindow)this.Parent.Parent).searchWindow1.ClearList();

            cageValue.Enabled = true;
            materialValue.Enabled = true;
            lengthValue.Enabled = true;
            widthValue.Enabled = true;
            heightValue.Enabled = true;
        }

        // when the save button was clicked for the Cage side, the program will check the new information and if everything
        // checks out then it will update the screen and the database
        private void saveCage_Button_Click(object sender, EventArgs e) // for cage //edit to hashtables
        {
            editCageButton.Visible = true;
            saveCageButton.Visible = false;

            cageValue.Enabled = false;
            materialValue.Enabled = false;
            lengthValue.Enabled = false;
            widthValue.Enabled = false;
            heightValue.Enabled = false;

            string[] cleanUp = new string[9];
            for (int i = 0; i < 9; i++) { cleanUp[i] = ""; }

            if (((MainWindow)this.Parent.Parent).addCage1.AddCageToDatabase(getTextFromUiCage(), true, infoFromDatabaseCage.Id, infoFromDatabaseCage.Material) == true)
            {
                // if the cage was updated successfuly, we need to update the 'infoFromDatabaseCage' object
                // incase the user decides to update the values again without getting out of the moredetails window
                infoFromDatabaseCage = getTextFromUiCage();
                List<Cage> newCage = MainWindow.HashTable.SearchCageHashtable(infoFromDatabaseCage.Id);
                birdList.Items.Clear();
                foreach (Bird bird in newCage[0].BirdList) //adding birds to list 
                {
                    string newStr = "Bird ID: " + bird.Id + " , Type: " + bird.Type + " , Gender: " + bird.Gender + " , Cage ID: " + bird.CageId;
                    birdList.Items.Add(newStr);
                }
            }
            else
            {
                cageValue.Texts = infoFromDatabaseCage.Id;
                lengthValue.Texts = infoFromDatabaseCage.Length;
                widthValue.Texts = infoFromDatabaseCage.Width;
                heightValue.Texts = infoFromDatabaseCage.Height;
                materialValue.SelectedItem = infoFromDatabaseCage.Material;
            }
        }

        public void setUnedited()
        {
            // reserting bird more details
            editBirdButton.Show();
            saveBirdButton.Hide();

            idLabel.Enabled = false;
            typeLabel.Enabled = false;
            subTypeLabel.Enabled = false;
            datePicker.Enabled = false;
            genderLabel.Enabled = false;
            cageIdLabel.Enabled = false;
            dadIdLabel.Enabled = false;
            momIdLabel.Enabled = false;

            // reseting cage more details
            editCageButton.Show();
            saveCageButton.Hide();

            cageValue.Enabled = false;
            materialValue.Enabled = false;
            lengthValue.Enabled = false;
            widthValue.Enabled = false;
            heightValue.Enabled = false;
        }

        private void typeCombobox_ItemClicked(object sender, EventArgs e)
        {
            setSubTypeCombobox();
        }
    }
}

using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTesting
{
    public partial class MoreDetails : UserControl
    {

        private Bird infoFromDatabaseBird;
        private Cage infoFromDatabaseCage;

        public MoreDetails()
        {
            InitializeComponent();
        }

        public void setImages()
        {
            this.mainPic.Image = getRandomImage();
            this.myPic.Image = getRandomImage();
        }

        private Image getRandomImage()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 19);
            Image temp = Image.FromFile(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\" + randomNumber.ToString() + ".jpg");
            return temp;
        }

        private void setSubTypeCombobox()
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

        public void initLabels(string id, string birdOrCage = "bird")
        {
            cleanLabels();// needs to recive a param and clean based on that param

            if (birdOrCage.Equals("bird")) //if bird we initialize the brid's info
            {
                cagePanel.Visible = false;
                editBirdButton.Show();
                saveBirdButton.Hide();
                setImages();

                string[] typeOptions = { "American Gouldian", "European Gouldian", "Australian Gouldian" };
                typeLabel.Items.Clear();
                typeLabel.Items.AddRange(typeOptions);

                List<Bird> birdInfo = MainWindow.HashTable.SearchBirdHashtable(id); //search bird in hashtable
                infoFromDatabaseBird = birdInfo[0];//save the bird for later use
                //initializing the fields
                idLabel.Texts = birdInfo[0].Id;
                typeLabel.SelectedItem = birdInfo[0].Type;
                setSubTypeCombobox();
                subTypeLabel.SelectedItem = birdInfo[0].SubType;
                string[] date = birdInfo[0].DateOfBirth.Split("/");
                int d = int.Parse(date[0]), m = int.Parse(date[1]), y = int.Parse(date[2]);
                datePicker.Value = new DateTime(y, m, d); //yyyy,mm,dd
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
                cagePanel.Visible = true;
                List<Cage> cageInfo = MainWindow.HashTable.SearchCageHashtable(id); //search cage in hashtable
                infoFromDatabaseCage = cageInfo[0]; //saving cage for later use

                //filling the fields for cage
                cageValue.Texts = cageInfo[0].Id;
                lengthValue.Texts = cageInfo[0].Length;
                widthValue.Texts = cageInfo[0].Width;
                heightValue.Texts = cageInfo[0].Height;
                materialValue.Texts = cageInfo[0].Material;

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
            //typeLabel.Texts = "";
            //subTypeLabel.Texts = "";
            genderLabel.Texts = "";
            cageIdLabel.Texts = "";
            dadIdLabel.Texts = "";
            momIdLabel.Texts = "";

            cageValue.Texts = "";
            lengthValue.Texts = "";
            widthValue.Texts = "";
            heightValue.Texts = "";
            materialValue.Texts = "";
            birdList.Items.Clear();
            offspringList.Items.Clear();
        }

        private void addOffspringButton_Click(object sender, EventArgs e) //changed to add offspring page
        {
            ((MainWindow)this.Parent.Parent).addBird1.setTypeCombobox();
            ((MainWindow)this.Parent.Parent).addBird1.setSubTypeCombobox();
            ((MainWindow)this.Parent.Parent).addBird1.makeReadOnly(
                typeLabel.Text, subTypeLabel.Text, cageIdLabel.Texts, genderLabel.Texts, idLabel.Texts
            );

            ((MainWindow)this.Parent.Parent).addBird1.Show();
            this.Hide();
            ((MainWindow)this.Parent.Parent).hideBackBtn();
        }

        private Bird getTextFromUiBird()
        {
            Bird newBird = new Bird(infoFromDatabaseBird);

            string[] temp = new string[] {
                idLabel.Texts.ToString(),
                typeLabel.Text,
                subTypeLabel.Text,
                datePicker.Text.ToString(),
                genderLabel.Texts.ToString(),
                cageIdLabel.Texts.ToString(),
                dadIdLabel.Texts.ToString(),
                momIdLabel.Texts.ToString()
            };
            newBird.EditFields(temp);

            return newBird;
        }

        private Cage getTextFromUiCage()
        {
            Cage newCage = new Cage(infoFromDatabaseCage);
            string[] temp = new string[] {
                cageValue.Texts.ToString(),
                lengthValue.Texts.ToString(),
                widthValue.Texts.ToString(),
                heightValue.Texts.ToString(),
                materialValue.Texts.ToString()
            };
            newCage.EditFields(temp);

            return newCage;
        }

        private void editBirdButton_Click(object sender, EventArgs e)
        {
            editBirdButton.Hide();
            saveBirdButton.Show();
            //infoFromDatabaseBird = getTextFromUi();

            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();

            ////idLabel.ReadOnly = false;
            datePicker.Enabled = true;
            //cageIdLabel.ReadOnly = false;
            //dadIdLabel.ReadOnly = false;
            //momIdLabel.ReadOnly = false;

            idLabel.Enabled = true;
            cageIdLabel.Enabled = true;
            dadIdLabel.Enabled = true;
            momIdLabel.Enabled = true;

            List<Bird> bird = MainWindow.HashTable.SearchBirdHashtable(infoFromDatabaseBird.Id); //search bird id in hashtable
            if (bird[0].isOffspring == false && bird[0].OffspringList.Count == 0)
            { //checking if the bird is adult and has no offsprings then we can edit these fields
                //typeLabel.ReadOnly = false;
                //subTypeLabel.ReadOnly = false;
                //genderLabel.ReadOnly = false;

                typeLabel.Enabled = true;
                subTypeLabel.Enabled = true;
                genderLabel.Enabled = true;
            }

            if (infoFromDatabaseBird.OffspringList.Count > 0 || infoFromDatabaseBird.isOffspring)
            {
                //cageIdLabel.ReadOnly = true;
                cageIdLabel.Enabled = false;
            }
        }

        private void restorInfo()
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

        private void saveBirdButton_Click(object sender, EventArgs e) //change implementation with hashtable
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
                if (((MainWindow)this.Parent.Parent).addBird1.getInfoFromUser(getTextFromUiBird(), true, infoFromDatabaseBird.Id) == true)
                    infoFromDatabaseBird = getTextFromUiBird();
                else
                    restorInfo();
            }

            if (flag == 1)
                restorInfo();
        }

        private void editCageButton_Click(object sender, EventArgs e) // for cage 
        {
            editCageButton.Visible = false;
            saveCageButton.Visible = true;

            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();

            //cageValue.ReadOnly = false;
            //materialValue.ReadOnly = false;
            //lengthValue.ReadOnly = false;
            //widthValue.ReadOnly = false;
            //heightValue.ReadOnly = false;

            cageValue.Enabled = true;
            materialValue.Enabled = true;
            lengthValue.Enabled = true;
            widthValue.Enabled = true;
            heightValue.Enabled = true;
        }

        private void saveCageButton_Click(object sender, EventArgs e) // for cage //edit to hashtables
        {
            editCageButton.Visible = true;
            saveCageButton.Visible = false;

            //cageValue.ReadOnly = true;
            //materialValue.ReadOnly = true;
            //lengthValue.ReadOnly = true;
            //widthValue.ReadOnly = true;
            //heightValue.ReadOnly = true;

            cageValue.Enabled = false;
            materialValue.Enabled = false;
            lengthValue.Enabled = false;
            widthValue.Enabled = false;
            heightValue.Enabled = false;

            string[] cleanUp = new string[9];
            for (int i = 0; i < 9; i++) { cleanUp[i] = ""; }

            if (((MainWindow)this.Parent.Parent).addCage1.getInfoFromUser(getTextFromUiCage(), true, infoFromDatabaseCage.Id) == true)
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
                materialValue.Texts = infoFromDatabaseCage.Material;
            }
        }

        public void setUnedited()
        {
            editBirdButton.Show();
            saveBirdButton.Hide();

            //idLabel.ReadOnly = true;
            //typeLabel.ReadOnly = true;
            //subTypeLabel.ReadOnly = true;
            //genderLabel.ReadOnly = true;
            //cageIdLabel.ReadOnly = true;
            //dadIdLabel.ReadOnly = true;
            //momIdLabel.ReadOnly = true;

            idLabel.Enabled = false;
            typeLabel.Enabled = false;
            subTypeLabel.Enabled = false;
            datePicker.Enabled = false;
            genderLabel.Enabled = false;
            cageIdLabel.Enabled = false;
            dadIdLabel.Enabled = false;
            momIdLabel.Enabled = false;
        }

        private void typeCombobox_ItemClicked(object sender, EventArgs e)
        {
            setSubTypeCombobox();
        }
    }
}

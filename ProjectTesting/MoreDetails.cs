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

namespace ProjectTesting
{
    public partial class MoreDetails : UserControl
    {

        private string[] infoFromDatabase;

        public MoreDetails()
        {
            InitializeComponent();

        }

        public void setImages()
        {
            string dirc = Directory.GetCurrentDirectory().Split("bin")[0];

            this.mainPic.Image = getRandomImage();

            //Image offspring1 = Image.FromFile(dirc + "images\\questionMark.jpg");
            //this.offspringPic1.Image = offspring1;

            //Image offspring2 = Image.FromFile(dirc + "images\\questionMark.jpg");
            //this.offspringPic2.Image = offspring2;

            //Image offspring3 = Image.FromFile(dirc + "images\\questionMark.jpg");
            //this.offspringPic3.Image = offspring3;

            //Image offspring4 = Image.FromFile(dirc + "images\\questionMark.jpg");
            //this.offspringPic4.Image = offspring4;

            //Image offspring5 = Image.FromFile(dirc + "images\\questionMark.jpg");
            //this.offspringPic5.Image = offspring5;
        }

        private Image getRandomImage()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            Image temp = Image.FromFile(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\" + randomNumber.ToString() + ".jpg");
            return temp;
        }

        public void initLabels(string id, string birdOrCage = "bird")
        {
            cleanLabels();// needs to recive a param and clean based on that param
          
            if (birdOrCage == "bird") //if bird we initialize the brid's info
            {
                cagePanel.Visible = false;
                editButton.Show();
                saveButton.Hide();
                setImages();

                List<string[]> birdInfo = MainWindow.HashTable.SearchBirdHashtable(id); //search bird in hashtable
                infoFromDatabase = birdInfo[0];//save the bird for later use
                //initializing the fields
                idLabel.Text = birdInfo[0][0];
                typeLabel.Text = birdInfo[0][1];
                subTypeLabel.Text = birdInfo[0][2];
                dateTextBox.Text = birdInfo[0][3];
                genderLabel.Text = birdInfo[0][4];
                cageIdLabel.Text = birdInfo[0][5];
                dadIdLabel.Text = birdInfo[0][6];
                momIdLabel.Text = birdInfo[0][7];
                //checks if offspring, if not we show a list of offsprings
                if (birdInfo[0][8] == "yes")
                {
                    offspringsPanel.Hide();
                    fledglingLabel.Show();
                }
                else if (birdInfo[0][8] == "no")
                {
                    offspringsPanel.Show();
                    fledglingLabel.Hide();
                }
               
            }
            else if (birdOrCage == "cage") //else we initialize cage's info
            {
                cagePanel.Visible = true;
                List<string[]> cageInfo = MainWindow.HashTable.SearchCageHashtable(id); //search cage in hashtable
                infoFromDatabase = cageInfo[0]; //saving cage for later use

                //filling the fields for cage
                cageValue.Text = cageInfo[0][0];
                lengthValue.Text = cageInfo[0][1];
                widthValue.Text = cageInfo[0][2];
                heightValue.Text = cageInfo[0][3];
                materialValue.Text = cageInfo[0][4];

                List<string[]> birdsInCage = MainWindow.HashTable.SearchBirdHashtable(id); //searching the brids hashtable for cage's birds

                foreach (string[] bird in  birdsInCage) //adding birds to list 
                {
                    string newStr = "Bird ID: " + bird[0] + " , Type: " + bird[1] + " , Gender: " + bird[4] + " , Cage ID: " + bird[5];
                    birdList.Items.Add(newStr);
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            cleanLabels();
            this.Hide();
        }

        private void cleanLabels()
        {
            idLabel.Text = "";
            typeLabel.Text = "";
            subTypeLabel.Text = "";
            dateLabel.Text = "";
            genderLabel.Text = "";
            cageIdLabel.Text = "";
            dadIdLabel.Text = "";
            momIdLabel.Text = "";

            cageValue.Text = "";
            lengthValue.Text = "";
            widthValue.Text = "";
            heightValue.Text = "";
            materialValue.Text = "";
            birdList.Items.Clear();
        }

        private void addOffspringButton_Click(object sender, EventArgs e) //changed to add offspring page
        {
            ((MainWindow)this.Parent.Parent).addBird1.AddBird_label.Text = "Add an Offspring:";
            ((MainWindow)this.Parent.Parent).addBird1.typeBox.Text = typeLabel.Text;
            ((MainWindow)this.Parent.Parent).addBird1.typeBox.ReadOnly = true;
            ((MainWindow)this.Parent.Parent).addBird1.subTypeBox.Text = subTypeLabel.Text;
            ((MainWindow)this.Parent.Parent).addBird1.subTypeBox.ReadOnly = true;
            ((MainWindow)this.Parent.Parent).addBird1.cageIdBox.Text = cageIdLabel.Text;
            ((MainWindow)this.Parent.Parent).addBird1.cageIdBox.ReadOnly = true;
            if (genderLabel.Text == "Male")
            {
                ((MainWindow)this.Parent.Parent).addBird1.dadBox.Text = idLabel.Text;
                ((MainWindow)this.Parent.Parent).addBird1.dadBox.ReadOnly = true;
            }
            else
            {
                ((MainWindow)this.Parent.Parent).addBird1.momBox.Text = idLabel.Text;
                ((MainWindow)this.Parent.Parent).addBird1.momBox.ReadOnly = true;
            }
            ((MainWindow)this.Parent.Parent).addBird1.Show();
            this.Hide();
            ((MainWindow)this.Parent.Parent).hideBackBtn();
        }

        private string[] getTextFromUi(string birdOrCage = "bird") 
        {
            string[] info = null;
            if (birdOrCage == "bird")
            {
                info = new string[9];

                info[0] = idLabel.Text.ToString();
                info[1] = typeLabel.Text.ToString();
                info[2] = subTypeLabel.Text.ToString();
                info[3] = dateLabel.Text.ToString();
                info[4] = genderLabel.Text.ToString();
                info[5] = cageIdLabel.Text.ToString();
                info[6] = dadIdLabel.Text.ToString();
                info[7] = momIdLabel.Text.ToString();

            }
            else if (birdOrCage == "cage")
            {
                info = new string[5];

                info[0] = cageValue.Text.ToString();
                info[1] = lengthValue.Text.ToString();
                info[2] = widthValue.Text.ToString();
                info[3] = heightValue.Text.ToString();
                info[4] = materialValue.Text.ToString();
            }
            return info;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Hide();
            saveButton.Show();

            infoFromDatabase = getTextFromUi();

            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();

            idLabel.ReadOnly = false;
            dateTextBox.Visible = false;
            dateLabel.Visible = true;
            dateLabel.Enabled = true;
            cageIdLabel.ReadOnly = false;
            dadIdLabel.ReadOnly = false;
            momIdLabel.ReadOnly = false;

            idLabel.Enabled = true;
            cageIdLabel.Enabled = true;
            dadIdLabel.Enabled = true;
            momIdLabel.Enabled = true;

            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow(7), flag = 0;

            // Checking if the bird is an adult and has at least one offspring, in that case we cant change the gender, type and subtype.
            if (infoFromDatabase[8] == "no")
            {
                for (int i = 1; i < row; i++)
                {
                    string isOffspring = ex.ReadCell("O" + i);
                    if (isOffspring == "yes")
                    {
                        string momId = ex.ReadCell("M" + i), dadId = ex.ReadCell("N" + i);
                        if (momId == infoFromDatabase[0] || dadId == infoFromDatabase[0])
                        {
                            //Here the bird we are editing is an adult and a parent with at least one offspring
                            flag = 1;
                            break;
                        }
                    }
                }
            }

            if (flag == 0)
            {
                typeLabel.ReadOnly = false;
                subTypeLabel.ReadOnly = false;
                genderLabel.ReadOnly = false;

                typeLabel.Enabled = true;
                subTypeLabel.Enabled = true;
                genderLabel.Enabled = true;
            }

            ex.Quit();
        }

        private void saveButton_Click(object sender, EventArgs e) //change implementation with hashtable
        {
            progressBarPanel.Visible = true;
            progressBar.Value = 0;

            editButton.Show();
            saveButton.Hide();

            idLabel.ReadOnly = true;
            typeLabel.ReadOnly = true;
            subTypeLabel.ReadOnly = true;
            dateTextBox.Visible = true;
            dateLabel.Visible = false;
            dateLabel.Enabled = false;
            genderLabel.ReadOnly = true;
            cageIdLabel.ReadOnly = true;
            dadIdLabel.ReadOnly = true;
            momIdLabel.ReadOnly = true;

            idLabel.Enabled = false;
            typeLabel.Enabled = false;
            subTypeLabel.Enabled = false;
            genderLabel.Enabled = false;
            cageIdLabel.Enabled = false;
            dadIdLabel.Enabled = false;
            momIdLabel.Enabled = false;

            progressBar.Value = 25;

            string[] newInfo = getTextFromUi();
            string[] cleanUp = new string[9];
            for (int i = 0; i < 9; i++) { cleanUp[i] = ""; }
            int flag = 0;

            if (infoFromDatabase[0] != newInfo[0])
            {
                if (!((MainWindow)this.Parent.Parent).addBird1.checkBirdId(newInfo[0]))
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                if (((MainWindow)this.Parent.Parent).addBird1.getInfoFromUser(getTextFromUi(), "no", true) == true)
                {
                    Excel ex = new Excel("database", MainWindow.UserSheet);
                    int row = ex.GetLastRow(7);

                    for (int i = 1; i < row; i++)
                    {
                        if (ex.ReadCell("G" + i) == infoFromDatabase[0])
                        {
                            progressBar.Value = 100;
                            newInfo[8] = ex.ReadCell("O" + i);
                            ex.WriteRange(i, 7, 15, newInfo);
                            ex.WriteRange(row - 1, 7, 15, cleanUp);

                            dateTextBox.Text = newInfo[3];
                        }
                    }
                    ex.Quit();
                }
                else
                {
                    idLabel.Text = infoFromDatabase[0];
                    typeLabel.Text = infoFromDatabase[1];
                    subTypeLabel.Text = infoFromDatabase[2];
                    dateTextBox.Text = infoFromDatabase[3];
                    genderLabel.Text = infoFromDatabase[4];
                    cageIdLabel.Text = infoFromDatabase[5];
                    dadIdLabel.Text = infoFromDatabase[6];
                    momIdLabel.Text = infoFromDatabase[7];
                }
            }

            progressBarPanel.Visible = false;

            if (flag == 1)
            {
                idLabel.Text = infoFromDatabase[0];
                typeLabel.Text = infoFromDatabase[1];
                subTypeLabel.Text = infoFromDatabase[2];
                dateTextBox.Text = infoFromDatabase[3];
                genderLabel.Text = infoFromDatabase[4];
                cageIdLabel.Text = infoFromDatabase[5];
                dadIdLabel.Text = infoFromDatabase[6];
                momIdLabel.Text = infoFromDatabase[7];
            }

        }

        private void editBtn_Click(object sender, EventArgs e) // for cage 
        {
            editBtn.Visible = false;
            saveBtn.Visible = true;

            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();

            cageValue.ReadOnly = false;
            materialValue.ReadOnly = false;
            lengthValue.ReadOnly = false;
            widthValue.ReadOnly = false;
            heightValue.ReadOnly = false;

            cageValue.Enabled = true;
            materialValue.Enabled = true;
            lengthValue.Enabled = true;
            widthValue.Enabled = true;
            heightValue.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e) // for cage //edit to hashtables
        {
            editBtn.Visible = true;
            saveBtn.Visible = false;

            cageValue.ReadOnly = true;
            materialValue.ReadOnly = true;
            lengthValue.ReadOnly = true;
            widthValue.ReadOnly = true;
            heightValue.ReadOnly = true;

            cageValue.Enabled = false;
            materialValue.Enabled = false;
            lengthValue.Enabled = false;
            widthValue.Enabled = false;
            heightValue.Enabled = false;

            string[] newInfo = getTextFromUi("cage");
            string[] cleanUp = new string[9];
            for (int i = 0; i < 9; i++) { cleanUp[i] = ""; }

            if (((MainWindow)this.Parent.Parent).addCage1.getInfoFromUser(getTextFromUi("cage"), true) == true)
            {
                Excel ex = new Excel("database", MainWindow.UserSheet);
                int row = ex.GetLastRow();

                for (int i = 1; i < row; i++)
                {
                    if (ex.ReadCell("A" + i) == infoFromDatabase[0])
                    {

                        //progressBar.Value = 100;
                        ex.WriteRange(i, 1, 5, newInfo);
                        ex.WriteRange(row - 1, 1, 5, cleanUp);

                    }
                }

                if (infoFromDatabase[0] != cageValue.Text) //this means that the id was changed, now we change the chage id for the birds
                {
                    row = ex.GetLastRow(7);

                    for (int i = 1; i < row; i++)
                    {
                        if (ex.ReadCell("L" + i) == infoFromDatabase[0])
                        {
                            ex.WriteCell("L" + i.ToString(), cageValue.Text);
                        }
                    }
                }
                ex.Quit();
            }
            else
            {
                cageValue.Text = infoFromDatabase[0];
                lengthValue.Text = infoFromDatabase[1];
                widthValue.Text = infoFromDatabase[2];
                heightValue.Text = infoFromDatabase[3];
                materialValue.Text = infoFromDatabase[4];
            }
        }

    }
}

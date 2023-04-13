using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void initLabels(string birdId)
        {
            editButton.Show();
            saveButton.Hide();
            setImages();
            cleanLabels();
            Excel ex = new Excel("database", MainWindow.UserSheet);
            int size = ex.GetLastRow(7);
            string tempId = "";
            string[] databaseInfo = null;

            for (int i = 1; i < size; i++)
            {
                tempId = ex.ReadCell("G" + i.ToString());
                if (tempId == birdId) //if we found one that matches we open a messagebox and break
                {
                    databaseInfo = ex.ReadRange(i, 7, 15);
                    infoFromDatabase = databaseInfo;

                    idLabel.Text = databaseInfo[0];
                    typeLabel.Text = databaseInfo[1];
                    subTypeLabel.Text = databaseInfo[2];
                    dateLabel.Text = databaseInfo[3];
                    genderLabel.Text = databaseInfo[4];
                    cageIdLabel.Text = databaseInfo[5];
                    dadIdLabel.Text = databaseInfo[6];
                    momIdLabel.Text = databaseInfo[7];

                    if (databaseInfo[8] == "yes")
                    {
                        offspringsPanel.Hide();
                        fledglingLabel.Show();
                    }
                    else if (databaseInfo[8] == "no")
                    {
                        offspringsPanel.Show();
                        fledglingLabel.Hide();
                    }
                    break;
                }
            }
            ex.Quit();
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

        private string[] getTextFromUi()
        {
            string[] birdInfo = new string[9];

            birdInfo[0] = idLabel.Text.ToString();
            birdInfo[1] = typeLabel.Text.ToString();
            birdInfo[2] = subTypeLabel.Text.ToString();
            birdInfo[3] = dateLabel.Text.ToString();
            birdInfo[4] = genderLabel.Text.ToString();
            birdInfo[5] = cageIdLabel.Text.ToString();
            birdInfo[6] = dadIdLabel.Text.ToString();
            birdInfo[7] = momIdLabel.Text.ToString();

            return birdInfo;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Hide();
            saveButton.Show();

            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();

            idLabel.ReadOnly = false;
            typeLabel.ReadOnly = false;
            subTypeLabel.ReadOnly = false;
            dateLabel.Enabled = true;
            genderLabel.ReadOnly = false;
            cageIdLabel.ReadOnly = false;
            dadIdLabel.ReadOnly = false;
            momIdLabel.ReadOnly = false;

            idLabel.Enabled = true;
            typeLabel.Enabled = true;
            subTypeLabel.Enabled = true;
            genderLabel.Enabled = true;
            cageIdLabel.Enabled = true;
            dadIdLabel.Enabled = true;
            momIdLabel.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            editButton.Show();
            saveButton.Hide();
            idLabel.ReadOnly = true;
            typeLabel.ReadOnly = true;
            subTypeLabel.ReadOnly = true;
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

            string[] newInfo = getTextFromUi();
            string[] cleanUp = new string[9];

            for (int i = 0; i < 9; i++)
            {
                cleanUp[i] = "";
            }

            if (((MainWindow)this.Parent.Parent).addBird1.getInfoFromUser(getTextFromUi(), "no", true) == true)
            {
                Excel ex = new Excel("database", MainWindow.UserSheet);
                int row = ex.GetLastRow(7);
                MessageBox.Show("Add a loading bar or circle for the users to know that the saving is in progress");

                for (int i = 1; i < row; i++)
                {
                    if (ex.ReadCell("G" + i) == infoFromDatabase[0])
                    {
                        newInfo[8] = ex.ReadCell("O" + i);
                        ex.WriteRange(i, 7, 15, newInfo);
                        ex.WriteRange(row-1, 7, 15, cleanUp);
                    }
                }
                ex.Quit();
            }
        }
    }
}

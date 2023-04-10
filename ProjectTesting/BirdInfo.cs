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
    public partial class BirdInfo : UserControl
    {
        public BirdInfo()
        {
            InitializeComponent();
            setImages();
            initLabels(); // this function needs to run when we use the .Show() method on this object
        }

        public void setImages()
        {
            string dirc = Directory.GetCurrentDirectory().Split("bin")[0];

            this.mainPic.Image = getRandomImage();

            Image offspring1 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.offspringPic1.Image = offspring1;

            Image offspring2 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.offspringPic2.Image = offspring2;

            Image offspring3 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.offspringPic3.Image = offspring3;

            Image offspring4 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.offspringPic4.Image = offspring4;

            Image offspring5 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.offspringPic5.Image = offspring5;
        }

        private Image getRandomImage()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            Image temp = Image.FromFile(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\" + randomNumber.ToString() + ".jpg");
            return temp;
        }

        public void initLabels()
        {
            string BIRD_ID = "97235"; // This function will recive a birds id in some way shape or form
            string USER_NAME = "default"; // This function will have access to the username of the current user

            Excel ex = new Excel("database", USER_NAME);
            int size = ex.GetLastRow();
            string tempId = "";
            string[] databaseInfo = null;

            for (int i = 2; i < size; i++)
            {
                tempId = ex.ReadCell("G" + i.ToString());
                if (tempId == BIRD_ID) //if we found one that matches we open a messagebox and break
                {
                    databaseInfo = ex.ReadRange(i, 7, 14);
                    idLabel.Text = databaseInfo[0];
                    typeLabel.Text = databaseInfo[1];
                    subTypeLabel.Text = databaseInfo[2];
                    dateLabel.Text = databaseInfo[3];
                    genderLabel.Text = databaseInfo[4];
                    cageIdLabel.Text = databaseInfo[5];
                    dadIdLabel.Text = databaseInfo[6];
                    momIdLabel.Text = databaseInfo[7];
                    break;
                }
            }

            ex.Quit();
        }





        // Click Events:

        private void button1_Click(object sender, EventArgs e)
        {
            idLabel.Text = "";
            typeLabel.Text = "";
            subTypeLabel.Text = "";
            dateLabel.Text = "";
            genderLabel.Text = "";
            cageIdLabel.Text = "";
            dadIdLabel.Text = "";
            momIdLabel.Text = "";
            this.Hide();
        }
    }
}

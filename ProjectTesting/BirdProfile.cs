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
    public partial class BirdProfile : UserControl
    {

        public BirdProfile()
        {
            InitializeComponent();
            setImages();
            initLabels();
        }

        private void setImages()
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

        private void initLabels()
        {
            string USERNAME = "Max"; // This will be a global username that the function could reference when the window is loaded
        }





        // Click Events:

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

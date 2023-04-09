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
        }

        private void setImages()
        {
            string dirc = Directory.GetCurrentDirectory().Split("bin")[0];

            this.pictureBox1.Image = getRandomImage();

            Image offspring1 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.pictureBox2.Image = offspring1;

            Image offspring2 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.pictureBox3.Image = offspring2;

            Image offspring3 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.pictureBox4.Image = offspring3;

            Image offspring4 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.pictureBox5.Image = offspring4;

            Image offspring5 = Image.FromFile(dirc + "images\\questionMark.jpg");
            this.pictureBox6.Image = offspring5;
        }

        private Image getRandomImage()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            Image temp = Image.FromFile(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\" + randomNumber.ToString() + ".jpg");
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

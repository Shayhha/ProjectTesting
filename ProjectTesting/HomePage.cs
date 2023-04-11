﻿using System;
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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ((MainWindow)this.Parent).searchBird1.ClearList();
            string combo = comboBox.Text;
            if (((MainWindow)this.Parent).searchBird1.Search(name, combo) == true)
            {
                ((MainWindow)this.Parent).searchBird1.Show();
                this.Hide();
            }

            //MainWindow mainWindow = (MainWindow)this.ParentForm;
            //mainWindow.Controls.Remove(this);

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void Cage_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 22, FontStyle.Bold))
            {
                SizeF textSize = e.Graphics.MeasureString("Click To Add Cage", myFont);
                int x = (Cage_pictureBox.Width - (int)textSize.Width) / 2;
                int y = Cage_pictureBox.Height - (int)textSize.Height;
                e.Graphics.DrawString("Click To Add Cage", myFont, Brushes.White, new Point(x, y));
            }
        }

        private void Bird_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 22, FontStyle.Bold))
            {
                SizeF textSize = e.Graphics.MeasureString("Click To Add Bird", myFont);
                int x = (Bird_pictureBox.Width - (int)textSize.Width) / 2;
                int y = Bird_pictureBox.Height - (int)textSize.Height;
                e.Graphics.DrawString("Click To Add Bird", myFont, Brushes.White, new Point(x, y));
            }
        }


    }
}

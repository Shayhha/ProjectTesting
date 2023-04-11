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
            comboBox.SelectedIndex = 0;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();
            string combo = comboBox.Text;
            if (((MainWindow)this.Parent.Parent).searchBird1.Search(name, combo) == true)
            {
                ((MainWindow)this.Parent.Parent).searchBird1.Show();
                Search_textbox.Text = "";
                comboBox.SelectedIndex = 0;
                this.Hide();
            }

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

        private void Cage_pictureBox_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).addCage1.Show();
            this.Hide();
        }

        private void Bird_pictureBox_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).addBird1.Show();
            this.Hide();
        }
    }
}

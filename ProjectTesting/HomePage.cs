﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            string text = "( search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id )";
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
            e.ToolTipSize = new Size(440, 120);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string name = Search_textbox.Text;
            ((MainWindow)this.Parent.Parent).searchBird1.ClearList();
            string combo = comboBox.Text;
            if (((MainWindow)this.Parent.Parent).searchBird1.Search(name, combo) == true)
            {
                ((MainWindow)this.Parent.Parent).searchBird1.Show();
                ((MainWindow)this.Parent.Parent).showBackBtn();
                Search_textbox.Text = "";
                comboBox.SelectedIndex = 0;
                this.Hide();
            }

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void Cage_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 28, FontStyle.Bold))
            {
                string text = "Click To Add Cage";
                SizeF textSize = e.Graphics.MeasureString(text, myFont);
                int x = (Cage_pictureBox.Width - (int)textSize.Width) / 2 + 35;
                int y = (Cage_pictureBox.Height - (int)textSize.Height) + 12;

                GraphicsPath path = new GraphicsPath();
                path.AddString(text, myFont.FontFamily, (int)myFont.Style, myFont.Size, new Point(x, y), StringFormat.GenericDefault);

                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
                e.Graphics.FillPath(Brushes.White, path);
            }
        }

        private void Bird_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 28, FontStyle.Bold))
            {
                string text = "Click To Add Bird";
                SizeF textSize = e.Graphics.MeasureString(text, myFont);
                int x = (Bird_pictureBox.Width - (int)textSize.Width) / 2 + 46;
                int y = (Bird_pictureBox.Height - (int)textSize.Height) + 12;//5

                GraphicsPath path = new GraphicsPath();
                path.AddString(text, myFont.FontFamily, (int)myFont.Style, myFont.Size, new Point(x, y), StringFormat.GenericDefault);

                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
                e.Graphics.FillPath(Brushes.White, path);
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

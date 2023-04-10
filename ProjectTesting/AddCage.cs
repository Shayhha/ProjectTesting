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
    public partial class AddCage : UserControl
    {
        public AddCage()
        {
            InitializeComponent();
        }

        private void getInfoFromUser()
        {

            string[] birdInfo = new string[8];

            birdInfo[0] = idBox.Text.ToString();
            birdInfo[1] = lengthBox.Text.ToString();
            birdInfo[2] = widthBox.Text.ToString();
            birdInfo[3] = heightBox.Text.ToString();
            birdInfo[4] = materialBox.Text.ToString();

            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow();
            ex.WriteRange(row, 7, 14, birdInfo);
            ex.Quit();

        }

        private void cleanTextBoxes()
        {
            idBox.Text = "";
            lengthBox.Text = "";
            widthBox.Text = "";
            heightBox.Text = "";
            materialBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfoFromUser();
            cleanTextBoxes();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            this.Hide();
        }
    }
}

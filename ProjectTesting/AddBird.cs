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
    public partial class AddBird : UserControl
    {
        public AddBird()
        {
            InitializeComponent();
        }

        private void getInfoFromUser()
        {

            string[] birdInfo = new string[8];

            birdInfo[0] = idBox.Text.ToString();
            birdInfo[1] = typeBox.Text.ToString();
            birdInfo[2] = subTypeBox.Text.ToString();
            birdInfo[3] = dateBox.Text.ToString();
            birdInfo[4] = genderBox.Text.ToString();
            birdInfo[5] = cageIdBox.Text.ToString();
            birdInfo[6] = dadBox.Text.ToString();
            birdInfo[7] = momBox.Text.ToString();

            Excel ex = new Excel("database", MainWindow.UserSheet);
            int row = ex.GetLastRow();
            ex.WriteRange(row, 7, 14, birdInfo);
            ex.Quit();

        }

        private void cleanTextBoxes()
        {
            idBox.Text = "";
            typeBox.Text = "";
            subTypeBox.Text = "";
            dateBox.Text = "";
            genderBox.Text = "";
            cageIdBox.Text = "";
            dadBox.Text = "";
            momBox.Text = "";
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

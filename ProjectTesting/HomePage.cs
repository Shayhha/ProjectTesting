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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow.searchBird1.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}

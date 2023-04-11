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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\duke.ico");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ShowMessage(string message, string title) //sets the message box 
        {
            Text = title;
            Message_label.Text = message;
        }

        public static void Show(string message, string title)
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.ShowMessage(message, title);
            messageBox.ShowDialog();
        }

        private void OK_button_Click(object sender, EventArgs e) //closes the message box
        {
            this.Close();
        }
    }
}

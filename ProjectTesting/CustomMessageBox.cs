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

        public void ShowMessage(string message, string title, bool cross) //sets the message box 
        {
            if (cross == false) //if we want to hide the cross we check if cross if false 
            {
                Error_picture.Hide();
            }
            Text = title;
            Message_label.Text = message;
        }

        public static void Show(string message, string title, bool cross = true)
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.ShowMessage(message, title,cross);
            messageBox.ShowDialog();
        }

        private void OK_button_Click(object sender, EventArgs e) //closes the message box
        {
            this.Close();
        }
    }
}

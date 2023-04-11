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
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUp1_Load(object sender, EventArgs e)
        {

        }


        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string username = UserName_textbox.Text;
            string password = Password_textbox.Text;
            string[] info = { username, password };
            Excel ex = new Excel("users", "default");
            int size = ex.GetLastRow();
            string[] temp = null;
            int flag = 0;

            if (username == "" && password == "")
            {
                CustomMessageBox.Show("Field are empty!", "Error");
                flag = 1;
            }
            else
            {
                for (int i = 1; i < size; i++)
                {
                    temp = ex.ReadRange(i, 1, 3);
                    if (temp[0] == info[0] && temp[1] == info[1]) //if we found matching user we change value of UserSheet
                    {
                        MainWindow.UserSheet = username; //gives usersheet the current users name
                        flag = 1;
                        ((MainWindow)this.Parent.Parent).homePage1.Show();
                        UserName_textbox.Text = "";
                        Password_textbox.Text = "";
                        break;

                    }
                    else if (temp[0] == info[0] && temp[1] != info[1])
                    {
                        CustomMessageBox.Show("Wrong password!", "Password Error");
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 0)
            {
               CustomMessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
            //after we logged in we close users excel
            ex.Quit();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).logIn1.Hide();
            ((MainWindow)this.Parent.Parent).signUp1.Show();
        }
    }
}

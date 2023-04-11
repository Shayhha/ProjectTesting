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



        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string username = UserName_textbox.Text;
            string password = Password_textbox.Text;
            string[] info = { username, password };
            Excel ex = new Excel("users", "default");
            int size = ex.GetLastRow();
            string[] temp = null;
            int flag = 0;

            for (int i = 1; i < size; i++)
            {
                temp = ex.ReadRange(i, 1, 3);
                if (temp[0] == info[0] && temp[1] == info[1]) //if we found matching user we change value of UserSheet
                {
                    flag = 1; //needs hoempage
                    MainWindow.UserSheet = username; //gives usersheet the current users name

                    //Control parent = this.Parent;
                    //while (parent != null && !(parent is MainWindow))
                    //{
                    //    parent = parent.Parent;
                    //}

                    //if (parent is MainWindow mainWindow)
                    //{
                    //    mainWindow.homePage1.Show();
                    //}

                    ((MainWindow)this.Parent.Parent).homePage1.Show();
                }
                else if (temp[0] == info[0] && temp[1] == info[1])
                {
                    MessageBox.Show("Wrong password!", "Password Error");
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
            //after we logged in we close users excel
            UserName_textbox.Text = "";
            Password_textbox.Text = "";
            ex.Quit();
        }



        private void SignUp1_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).logIn1.Hide();
            ((MainWindow)this.Parent.Parent).signUp1.Show();
        }
    }
}

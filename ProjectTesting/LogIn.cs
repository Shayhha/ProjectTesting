using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            int s ='0';
            MessageBox.Show(s.ToString());
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
                        LoggedIn();
                        flag = 1;
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
            ex.Quit(); //after we logged in we close users excel
        }

        private void LoggedIn() //opens the 
        {



            Excel ex = new Excel("database", MainWindow.UserSheet);
            if (ex.ReadCell("A1") == "")
            {
                ((MainWindow)this.Parent.Parent).addCage1.setWelcome_lable(true);
                ((MainWindow)this.Parent.Parent).addCage1.Show();
            }
            else
            {
                ((MainWindow)this.Parent.Parent).homePage1.Show();
            }


            ((MainWindow)this.Parent.Parent).setCagesLabel((ex.GetLastRow() - 1).ToString());
            ((MainWindow)this.Parent.Parent).setBirdsLabel((ex.GetLastRow(7) - 1).ToString());
            
            ((MainWindow)this.Parent.Parent).showTopBar();
            ((MainWindow)this.Parent.Parent).showTopPanel();

            ex.Quit();//closes the database excel
            UserName_textbox.Text = "";
            Password_textbox.Text = "";
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).logIn1.Hide();
            ((MainWindow)this.Parent.Parent).signUp1.Show();
        }
    }
}

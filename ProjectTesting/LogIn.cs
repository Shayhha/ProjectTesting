using Microsoft.Office.Interop.Excel;
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
        public static Excel DataBaseExcel = null;
        public LogIn()
        {
            InitializeComponent();
        }
        
        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string username = UserName_textbox.Text;
            string password = Password_textbox.Text;
            string[] info = { username, password };
            List<string[]> result = MainWindow.HashTable.SearchUserHashtable(username);
            if (result[0][0] == username && result[0][1] != password)
            {
                CustomMessageBox.Show("Wrong password!", "Password Error");
            }
            else if (result[0][0] == username && result[0][1] == password)
            {
                MainWindow.UserSheet = username; //gives usersheet the current users name
                LoggedIn();
            }
            else
            {
                CustomMessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
        }

        private void LoggedIn() //opens the homepage
        {
            DataBaseExcel = new Excel("database", MainWindow.UserSheet); //opens the database of user
            if (DataBaseExcel.ReadCell("A1").Equals("")) //checks if user is new (without any cages)
            {
                ((MainWindow)this.Parent.Parent).showTopBar();
                ((MainWindow)this.Parent.Parent).showTopPanel();
                ((MainWindow)this.Parent.Parent).addCage1.setWelcome_lable(true);
                ((MainWindow)this.Parent.Parent).addCage1.Show();
            }
            else //else user isn't new so we show homepage
            {
                //((MainWindow)this.Parent.Parent).homePage1.Show();
            }
            ////set bird and cage counters and top bar
            ((MainWindow)this.Parent.Parent).setCagesLabel((DataBaseExcel.GetLastRow() - 1).ToString());
            ((MainWindow)this.Parent.Parent).setBirdsLabel((DataBaseExcel.GetLastRow(7) - 1).ToString());
            MainWindow.InitHashtable(); //initializing the hashtables of birds and cages!!
            ((MainWindow)this.Parent.Parent).homePage1.Show();
            ((MainWindow)this.Parent.Parent).showTopBar();
            ((MainWindow)this.Parent.Parent).showTopPanel();
            UserName_textbox.Text = "";
            Password_textbox.Text = "";
            DataBaseExcel.Quit(); //close DataBaseExcel
            this.Hide();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent.Parent).logIn1.Hide();
            ((MainWindow)this.Parent.Parent).signUp1.Show();
        }
    }
}

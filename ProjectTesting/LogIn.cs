﻿using Microsoft.Office.Interop.Excel;
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
            
            List<string[]> result = MainWindow.HashTable.SearchUserHashtable(username);
            if(username =="" &&  password != "") //if username is empty we show error
            {
                CustomMessageBox.Show("Username field is empty!", "Input Error");
            }
            else if (username != "" && password == "") //if password is empty we show error
            {
                CustomMessageBox.Show("Password field is empty!", "Input Error");
            }
            else if (username == "" && password == "") //if fields are empty we show error
            {
                CustomMessageBox.Show("Fields are empty!", "Input Error");
            }
            else if (result[0][0] == username && result[0][1] != password) // if password as invalid we show error
            {
                CustomMessageBox.Show("Wrong password!", "Password Error");
            }
            else if (result[0][0] == username && result[0][1] == password) //if user wrote valid information we call LoggedIn method
            {
                MainWindow.UserSheet = username; //gives usersheet the current users name
                LoggedIn();
            }
            else //else no user found and we show error 
            {
                CustomMessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
        }

        private void LoggedIn() //opens the homepage
        {
            DataBaseExcel = new Excel("database", MainWindow.UserSheet); //opens the database of user

            ////set bird and cage counters and top bar
            //((MainWindow)this.Parent.Parent).setCagesLabel((DataBaseExcel.GetLastRow() - 1).ToString());
            //((MainWindow)this.Parent.Parent).setBirdsLabel((DataBaseExcel.GetLastRow(7) - 1).ToString());
            MainWindow.InitHashtable(); //initializing the hashtables of birds and cages!!

            //((MainWindow)this.Parent.Parent).homePage1.Show(); // This is not needed

            ////set bird and cage counters and top bar //!?!?!?! try this and if its not fast then delete
            ((MainWindow)this.Parent).setCagesLabel((DataBaseExcel.GetLastRow() - 1).ToString());
            ((MainWindow)this.Parent).setBirdsLabel((DataBaseExcel.GetLastRow(7) - 1).ToString());

            ((MainWindow)this.Parent).showTopBar();
            ((MainWindow)this.Parent).showTopPanel();
            UserName_textbox.Text = "";
            Password_textbox.Text = "";

            ((MainWindow)this.Parent).showContent(); // makeing the content panel visible, all of our screens sit inside of it (other than login and signup)

            if (DataBaseExcel.ReadCell("A1").Equals("")) //checks if user is new (without any cages)
            {
                // If our user is new, he will not have any cages, thats why for new users we want to show the "Add Cage" screen
                // as the first screen untill they have actualy added a cage inorder to make them use our app safly and not get bugged out
                ((MainWindow)this.Parent).showTopBar();
                ((MainWindow)this.Parent).showTopPanel();
                ((MainWindow)this.Parent).addCage1.setWelcome_lable(true);
                ((MainWindow)this.Parent).addCage1.Show();
            }
            else //else user isn't new so we show homepage
            {
                // Here we show the homepage because in this case we know that the user has atleast one cage and can safly use our app
                ((MainWindow)this.Parent).homePage1.Show();
            }

            DataBaseExcel.Quit(); //close DataBaseExcel
            this.Hide();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent).logIn1.Hide();
            ((MainWindow)this.Parent).signUp1.Show();
        }
    }
}

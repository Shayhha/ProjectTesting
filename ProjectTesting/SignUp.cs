using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {

            string pass = Password_textbox.Text;
            string username = UserName_textbox.Text;
            string id = ID_textbox.Text;
            string[] info = { username, pass, id };
            Excel ex = new Excel("users", "default");
            string[] temp = null;
            int flag = 0;
            int size = ex.GetLastRow();

            if (id.Length != 6)
            {
                MessageBox.Show("ID length must be 6 characters.");
                flag = 1;
            }

            if (UsernameValidate(username) == false)
                flag = 1;

            if (PasswordValidate(pass) == false)
                flag = 1;

            for (int i = 1; i < size; i++)
            { //we check if we have a user with same username or ID
                temp = ex.ReadRange(i, 1, 3);
                if (temp[0] == username) //if we found one that matches we open a messagebox and break
                {
                    MessageBox.Show("Username is already taken!", "ERROR");
                    flag = 1;
                    break;
                }
                if (temp[2] == id)
                {
                    MessageBox.Show("ID is already registered!", "ERROR");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0) //if everything went right we add the user to file and send welcome message
            {
                ex.WriteRange(ex.GetLastRow(), 1, 3, info);
                Excel ex2 = new Excel("database", "default");
                ex2.CreateNewSheet(username);
                ex2.Quit();
                MessageBox.Show("You've successfully signed up to system!", "Welocme");
                Password_textbox.Text = "";
                UserName_textbox.Text = "";
                ID_textbox.Text = "";
                this.Hide(); //return to previous window
            }
            ex.Quit();
        }

        public bool UsernameValidate(string user)
        {
            var hasTwoNumbers = new Regex(@"^(?=(?:\D*\d){0,2}\D*$)[a-zA-Z0-9]*$");
            var hasMiniMaxChars = new Regex(@"^.{6,8}$");
            var isAlphaNumeric = new Regex(@"^[a-zA-Z0-9_]+$"); // ^[a-zA-Z]+^[0-9]{1,2}$

            if (!hasTwoNumbers.IsMatch(user))
            {
                MessageBox.Show("Error, username can have maximum of two numbers", "ERROR");
                return false;
            }
            if (!hasMiniMaxChars.IsMatch(user))
            {
                MessageBox.Show("Error, username must contain between 6 to 8 characters!", "ERROR");
                return false;
            }
            if (!isAlphaNumeric.IsMatch(user))
            {
                MessageBox.Show("Error, password must contain only letters and numbers!", "ERROR");
                return false;
            }
            return true;

        }
        public bool PasswordValidate(string pass)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@"^.{8,10}$"); //password is between 8-10 characters
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (pass == "")
            {
                MessageBox.Show("Error, password cannot be empty!");
            }
            else
            {
                if (!hasNumber.IsMatch(pass))
                {
                    MessageBox.Show("Error, password must contain at least one number!", "ERROR");
                    return false;
                }
                if (!hasUpperChar.IsMatch(pass))
                {
                    MessageBox.Show("Error, password must contain at least one upper case letter!", "ERROR");
                    return false;
                }
                if (!hasMiniMaxChars.IsMatch(pass))
                {
                    MessageBox.Show("Error, password must be between 8 to 10 characters!", "ERROR");
                    return false;
                }
                if (!hasLowerChar.IsMatch(pass))
                {
                    MessageBox.Show("Error, password must contain at least one lower case letter!", "ERROR");
                    return false;
                }
                if (!hasSymbols.IsMatch(pass))
                {
                    MessageBox.Show("Error, password must contain at least symbol!", "ERROR");
                    return false;
                }
            }
            return true;
        }

        private void Cancel_button_Click(object sender, EventArgs e) //returns to sign in
        {
            Password_textbox.Text = "";
            UserName_textbox.Text = "";
            ID_textbox.Text = "";
            this.Hide();
        }
    }
}

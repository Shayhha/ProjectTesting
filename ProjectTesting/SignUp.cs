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
            ToolTip passwordRequirementsToolTip = new ToolTip();
            passwordRequirementsToolTip.InitialDelay = 0; // Set the delay before the ToolTip appears
            passwordRequirementsToolTip.OwnerDraw = true; // Enable owner drawing of the ToolTip
            passwordRequirementsToolTip.Draw += PasswordRequirementsToolTip_Draw; // Handle the Draw event to draw the ToolTip
            passwordRequirementsToolTip.Popup += PasswordRequirementsToolTip_Popup;
            string text = "1. Name must contain only letters and at max 2 numbers\n2. ID must contain 9 numbers\n" +
                "3. Passsword must contain at least one capital case letter and one" +
                " lower case letter, also needs to contain at least one symbol\n";
            passwordRequirementsToolTip.SetToolTip(Question_pictureBox, text);
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {

            string pass = Password_textbox.Text;
            string username = UserName_textbox.Text;
            string id = ID_textbox.Text;
            string[] userInfo = { username, pass, id };
            Excel ex = new Excel("users", "default");
            string[] temp = null;
            int flag = 0;
            int size = ex.GetLastRow();

            if (pass == "" && username == "" && id == "") //if fields are empty we give an error
            {
                CustomMessageBox.Show("Fields are empty!", "ERROR");
                flag = 1;
            }

            else //else fields are'nt empty so we check their validity
            {
                if (id.Length != 6)
                {
                    CustomMessageBox.Show("ID length must be 6 characters.", "ERROR");
                    flag = 1;
                }

                if (UsernameValidate(username) == false)
                    flag = 1;

                if (PasswordValidate(pass) == false)
                    flag = 1;
            }

            if (flag == 0) //if no errors occurred we check if the user exists in our user hashtable
            {
                List<string[]> searchUser = MainWindow.HashTable.SearchUserHashtable(username);
                List<string[]> searchID = MainWindow.HashTable.SearchUserHashtable(id);
                if (searchUser[0][0] != "" && (searchUser[0][2] == username || searchUser[0][0].ToLower() == username.ToLower())) //if we found one that matches we open a messagebox and break
                {
                    CustomMessageBox.Show("Username is already taken!", "ERROR");
                    flag = 1;
                }

                if (searchID[0][0] != "" && searchID[0][2] == id)
                {
                    CustomMessageBox.Show("ID is already registered!", "ERROR");
                    flag = 1;
                }
            }

            if (flag == 0) //if everything went right we add the user to file and send welcome message
            {
                ex.WriteRange(ex.GetLastRow(), 1, 3, userInfo);
                Excel ex2 = new Excel("database", "default");
                ex2.CreateNewSheet(username);
                ex2.Quit();
                CustomMessageBox.Show("You've successfully signed up to system!", "Welocme", false);
                Password_textbox.Text = "";
                UserName_textbox.Text = "";
                ID_textbox.Text = "";
                ((MainWindow)this.Parent.Parent).logIn1.Show();
                MainWindow.HashTable.AddUserToHashtable(userInfo); //add user to hashtable
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
                CustomMessageBox.Show("Error, username can have maximum of two numbers", "ERROR");
                return false;
            }
            if (!hasMiniMaxChars.IsMatch(user))
            {
                CustomMessageBox.Show("Error, username must contain between 6 to 8 characters!", "ERROR");
                return false;
            }
            if (!isAlphaNumeric.IsMatch(user))
            {
                CustomMessageBox.Show("Error, password must contain only letters and numbers!", "ERROR");
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
                CustomMessageBox.Show("Error, password cannot be empty!", "Password Error");
            }
            else
            {
                if (!hasNumber.IsMatch(pass))
                {
                    CustomMessageBox.Show("Error, password must contain at least one number!", "ERROR");
                    return false;
                }
                if (!hasUpperChar.IsMatch(pass))
                {
                    CustomMessageBox.Show("Error, password must contain at least one upper case letter!", "ERROR");
                    return false;
                }
                if (!hasMiniMaxChars.IsMatch(pass))
                {
                    CustomMessageBox.Show("Error, password must be between 8 to 10 characters!", "ERROR");
                    return false;
                }
                if (!hasLowerChar.IsMatch(pass))
                {
                    CustomMessageBox.Show("Error, password must contain at least one lower case letter!", "ERROR");
                    return false;
                }
                if (!hasSymbols.IsMatch(pass))
                {
                    CustomMessageBox.Show("Error, password must contain at least symbol!", "ERROR");
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
            ((MainWindow)this.Parent.Parent).logIn1.Show();
            this.Hide();
        }

        public void PasswordRequirementsToolTip_Draw(object sender, DrawToolTipEventArgs e) //sets font size of ToolTip and the background
        {
            // Set the font size of the text in the ToolTip
            Font font = new Font(e.Font.FontFamily, 12);

            // Draw the background and border of the ToolTip
            e.DrawBackground();
            e.DrawBorder();

            // Draw the text in the ToolTip using the specified font
            e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, e.Bounds);
        }

        public void PasswordRequirementsToolTip_Popup(object sender, PopupEventArgs e) //sets size of ToolTip
        {
            e.ToolTipSize = new Size(440, 120);
        }
    }
}

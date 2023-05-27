using System.Text.RegularExpressions;

namespace ProjectTesting
{
    /// <summary>
    /// The SignUp class is a UserControl that is used to display the signup page to the user.
    /// This class has 3 textboxes named: UserName_textbox, Password_textbox and ID_textbox.
    /// It also has a few labels and two buttons, a 'Sign Up' button and a 'Cancel' button.
    /// This class has a method SignUp_button_Click, it is an event that is triggered by clicking the 'Sign Up'
    /// button and its pourpose is to check if the users information is correct, if it is then create a new accout
    /// but if there is something wrong then an error message will apear and a new user will not be created.
    /// </summary>
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();

            // This ToolTip is a popup panel that will show usfull information to a new user when he hovers over the '?' sign
            ToolTip passwordRequirementsToolTip = new ToolTip();
            passwordRequirementsToolTip.InitialDelay = 0; // Set the delay before the ToolTip appears
            passwordRequirementsToolTip.OwnerDraw = true; // Enable owner drawing of the ToolTip
            passwordRequirementsToolTip.Draw += PasswordRequirementsToolTip_Draw; // Handle the Draw event to draw the ToolTip
            passwordRequirementsToolTip.Popup += PasswordRequirementsToolTip_Popup;
            string text = "1. Name must contain only letters and at max 2 numbers\n2. ID must contain 9 numbers.\n" +
                "3. Passsword must contain at least one capital case letter and one." +
                " lower case letter, also needs to contain at least one symbol.\n";
            passwordRequirementsToolTip.SetToolTip(Question_pictureBox, text);
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            // our variables
            string pass = Password_textbox.Texts;
            string username = UserName_textbox.Texts;
            string id = ID_textbox.Texts;
            string[] userInfo = { username, pass, id };

            //if fields are empty we show an error message
            if (pass == "" || username == "" || id == "")
            {
                CustomMessageBox.Show("Some fields are empty!", "ERROR");
                return;
            }
            else //else fields are not empty so we check their validity
            {
                if (UsernameValidate(username) == false) // if username does not match the pattern we show error and stop
                    return;
                else
                {
                    // if the username matches the pattern we need to check if the username already exists in the hashtables, we do it by checking the Users hashtable
                    List<string[]> searchUser = MainWindow.HashTable.SearchUserHashtable(username);
                    List<string[]> searchID = MainWindow.HashTable.SearchUserHashtable(id);
                    if (searchUser[0][0] != "" && (searchUser[0][2] == username || searchUser[0][0].ToLower() == username.ToLower())) //if we found one that matches we open a messagebox and break
                    {
                        CustomMessageBox.Show("Username is already taken!", "ERROR");
                        return;
                    }

                    if (searchID[0][0] != "" && searchID[0][2] == id) // also checking the id because id's must be unique
                    {
                        CustomMessageBox.Show("ID is already registered!", "ERROR");
                        return;
                    }
                }

                if (PasswordValidate(pass) == false) // if password does not match the pattern we show error and stop
                    return;

                if (id.Length != 9 || !(id.All(char.IsDigit))) // if id does not match the pattern we show error and stop
                {
                    CustomMessageBox.Show("ID length must be 9 characters and contain only numbers", "ERROR");
                    return;
                }
            }

            // if everything went right and the function is still excecuting, then we add the user to file and send welcome message

            // we add the new user to the users database
            Excel ex = new Excel("users", "default");
            ex.WriteRange(ex.GetLastRow(), 1, 3, userInfo);
            ex.Quit();

            // we create a new sheet for this user in the birds and cages database
            Excel ex2 = new Excel("database", "default");
            ex2.CreateNewSheet(username);
            ex2.Quit();

            CustomMessageBox.Show("You've successfully signed up to system!", "Welocme", false); // show a success message
            Password_textbox.Texts = ""; // clean textboxes
            UserName_textbox.Texts = "";
            ID_textbox.Texts = "";
            ((MainWindow)this.Parent).logIn1.Show(); // show the login screen to the user
            MainWindow.HashTable.AddUserToHashtable(userInfo); // add user to hashtable
            this.Hide(); // hide the current window
        }

        /// <summary>
        /// This function checks the validity of a givn username based on a few metrics.
        /// A username must be 6 to 8 characters long have a maximum of 2 numbers and contain only letters and numbers.
        /// </summary>
        /// <returns>true if the username is correct, false otherwise</returns>
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

        /// <summary>
        /// This function checks the validity of a givn password based on a few metrics.
        /// A password must be 8 to 10 characters long, must contain at least one capital case letter and one lower case letter,
        /// also needs to contain at least one symbol
        /// </summary>
        /// <returns>true if the password is correct, false otherwise</returns>
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
                    CustomMessageBox.Show("Error, password must contain at least one symbol!", "ERROR");
                    return false;
                }
            }
            return true;
        }

        private void Cancel_Button_Click(object sender, EventArgs e) //returns to sign in
        {
            Password_textbox.Texts = "";
            UserName_textbox.Texts = "";
            ID_textbox.Texts = "";
            ((MainWindow)this.Parent).logIn1.Show();
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

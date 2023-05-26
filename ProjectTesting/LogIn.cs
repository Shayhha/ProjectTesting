
namespace ProjectTesting
{
    /// <summary>
    /// The LogIn class is a UserControl that represents the login page, it is the first page of our application.
    /// This page has two textboxes for username and password, as well as two buttons, login and signup.
    /// After a user enters correect credentials the program will load that users database and create a hashtable
    /// for the rest of the program to use inorder to insure O(1) run times.
    /// </summary>
    public partial class LogIn : UserControl
    {
        // This Excel object will be used a the main database object after a user has logged in, we will use it instead of creating new objects
        public static Excel DataBaseExcel = null;

        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function performs all of the checks in order to determin if the user's information is correct
        /// and correlates to an existing user in the database, if not then errors will be shown to the user.
        /// </summary>
        private void LogIn_button_Click(object sender, EventArgs e)
        {
            // place holders for user's information from the gui
            string username = UserName_textbox.Texts;
            string password = Password_textbox.Texts;

            // searching for an existing user name in the user's hashtable that was created when the app is loaded
            List<string[]> result = MainWindow.HashTable.SearchUserHashtable(username); 
            if (username == "" && password != "") //if username is empty we show error
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
                LoggedIn(); // this function will take care of the rest of the work because now we have found the user in the hashtable
            }
            else //else no user found and we show error 
            {
                CustomMessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
        }

        private void LoggedIn() //opens the homepage
        {
            DataBaseExcel = new Excel("database", MainWindow.UserSheet); //opens the database of user

            MainWindow.InitHashtable(); //initializing the hashtables of birds and cages!!

            //set bird and cage counters and top bar 
            ((MainWindow)this.Parent).setCagesLabel((DataBaseExcel.GetLastRow() - 1).ToString());
            ((MainWindow)this.Parent).setBirdsLabel((DataBaseExcel.GetLastRow(7) - 1).ToString());

            ((MainWindow)this.Parent).showTopBar();
            ((MainWindow)this.Parent).showTopPanel();
            UserName_textbox.Texts = "";
            Password_textbox.Texts = "";

            // makeing the content panel visible, all of our screens sit inside of it (other than login and signup)
            ((MainWindow)this.Parent).showContent(); 

            if (DataBaseExcel.ReadCell("A1").Equals("")) //checks if user is new (without any cages)
            {
                // If our user is new, he will not have any cages, thats why for new users we want to show the "Add Cage" screen
                // as the first screen untill they have actualy added a cage inorder to make them use our app safly and not get bugged out
                ((MainWindow)this.Parent).showTopBar();
                ((MainWindow)this.Parent).showTopPanel();
                ((MainWindow)this.Parent).addCage1.setWelcome_lable(true);
                ((MainWindow)this.Parent).addCage1.setTypeCombobox();
                ((MainWindow)this.Parent).addCage1.addButton.Location = new System.Drawing.Point(158, 348); 
                ((MainWindow)this.Parent).addCage1.panel2.Location = new System.Drawing.Point(381, 124);
                ((MainWindow)this.Parent).addCage1.panel3.Location = new System.Drawing.Point(389, 115);
                ((MainWindow)this.Parent).addCage1.Show();
            }
            else //else user isn't new so we show homepage
            {
                // Here we show the homepage because in this case we know that the user has atleast one cage and can safly use our app
                ((MainWindow)this.Parent).addCage1.panel2.Location = new System.Drawing.Point(381, 72);
                ((MainWindow)this.Parent).addCage1.panel3.Location = new System.Drawing.Point(389, 63);
                ((MainWindow)this.Parent).homePage1.Show();
            }

            DataBaseExcel.Quit(); //close DataBaseExcel
            this.Hide();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Parent).signUp1.Show();
            ((MainWindow)this.Parent).logIn1.Hide();
        }
    }
}

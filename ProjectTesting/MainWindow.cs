
namespace ProjectTesting

{
    public partial class MainWindow : Form
    {
        public static string UserSheet = ""; //this represents the logged in user sheet name

        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\parrot.ico");
            this.StartPosition = FormStartPosition.CenterScreen;
            Back_Button.Hide();
            hideTopBar();
            hideTopPanel();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //SignUp1.Hide();
            //searchBird1.Hide();
            //homePage1.Hide();
            //addBird1.Hide();
            //addCage1.Hide();
        }

        public void loginToSignUp()
        {
            logIn1.Hide();
            signUp1.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logIn1.Show();
            homePage1.Hide();
            searchBird1.Hide();
            addBird1.Hide();
            addCage1.Hide();
            moreDetails1.Hide();
            hideTopBar();
            hideBackBtn();
            hideTopPanel();
        }

        public void showTopBar()
        {
            logOutButton.Show();
            Bird_label.Show();
            Cage_label.Show();
            dashboardButton.Show();
        }

        public void hideTopBar()
        {
            logOutButton.Hide();
            Bird_label.Hide();
            Cage_label.Hide();
            dashboardButton.Hide();
        }

        public void showTopPanel() { headlinePanel.Show(); }
        public void hideTopPanel() { headlinePanel.Hide(); }

        public void showBackBtn() { Back_Button.Show(); }
        public void hideBackBtn() { Back_Button.Hide(); }

        public void setBirdsLabel(string number)
        {
            Bird_label.Text = "Birds: " + number;
        }
        public void setCagesLabel(string number)
        {
            Cage_label.Text = "Cages: " + number;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (searchBird1.Visible == true)
            {
                if (searchBird1.Search_textbox.Text != "") { searchBird1.Search_textbox.Text = ""; }
                searchBird1.Hide();
                hideBackBtn();
                homePage1.Show();
            }
            else if (moreDetails1.Visible == true)
            {
                moreDetails1.Hide();
                searchBird1.Show();
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Opens the dashboard", "dashboard");
        }
    }
}
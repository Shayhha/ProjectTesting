
namespace ProjectTesting

{
    public partial class MainWindow : Form
    {
        public static string UserSheet = ""; //this represents the logged in user sheet name

        public MainWindow()
        {
            InitializeComponent();
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

    }
}
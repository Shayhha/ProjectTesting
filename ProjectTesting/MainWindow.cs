
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



        private void readExcel()
        {
            Excel excel = new Excel("users", "Sheet1");

            //MessageBox.Show(excel.ReadCell("A2"));

            //string[] stuff = excel.ReadRange(4, 1, 2);

            //foreach (string res in stuff)
            //{
            //    MessageBox.Show(res);
            //}



            string[] myArray = { "max", "123321" };

            excel.WriteRange(5, 1, 2, myArray);

            excel.Quit();
        }


        public void loginToSignUp()
        {
            logIn1.Hide();
            signUp1.Show();
        }

    }
}
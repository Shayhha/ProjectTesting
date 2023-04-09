
namespace ProjectTesting

{
    public partial class MainWindow : Form
    {
        private string UserSheet = ""; //this represents the logged in user sheet name

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string username = UserName_textbox.Text;
            string password = Password_textbox.Text;
            string[] info = { username, password };
            Excel ex = new Excel("users", "default");
            int size = ex.GetLastRow();
            string[] temp = null;
            int flag = 0;

            for (int i = 1; i < size; i++)
            {
                temp = ex.ReadRange(i, 1, 3);
                if (temp[0] == info[0] && temp[1] == info[1]) //if we found matching user we change value of UserSheet
                {
                    flag = 1; //needs hoempage
                    this.UserSheet = username; //gives usersheet the current users name
                    homePage1.Show();
                }
                else if (temp[0] == info[0] && temp[1] == info[1])
                {
                    MessageBox.Show("Wrong password!", "Password Error");
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("No matching user \"" + username + "\"", "User Error");
            }
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SignUp1.Hide();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            SignUp1.Show();
        }

    }
}
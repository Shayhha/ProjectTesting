
namespace ProjectTesting
{
    /// <summary>
    /// This class is a Form, it shows the user how many birds and cages he has in total, and also shows a list 
    /// of his birds and a list of his cages.
    /// </summary>
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();

            // adding an icon to this form
            this.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\parrot.ico");
            Text = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// This function is the one that goes over the database and fills up all of the information on the 
        /// dashboard window based on the current connected user.
        /// </summary>
        public void initDash()
        {
            clearDash();
            LogIn.DataBaseExcel = new Excel("database", MainWindow.UserSheet); // openning the database
            string[] temp;
            string newStr;

            // filling counters
            usernameLabel.Text = "Hello " + MainWindow.UserSheet;
            birdsLabel.Text = "You have " + (LogIn.DataBaseExcel.GetLastRow(7) - 1).ToString() + " birds:";
            cagesLabel.Text = "You have " + (LogIn.DataBaseExcel.GetLastRow(0) - 1).ToString() + " cages:";


            // filling lists
            for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(); i++)
            {
                temp = LogIn.DataBaseExcel.ReadRange(i, 1, 5);
                newStr = "Cage ID: " + temp[0] + " , Length: " + temp[1] + " , Width: " + temp[2] + " , Height: " + temp[3] + " , Material: " + temp[4];
                cagesList.Items.Add(newStr);
            }

            for (int i = 1; i < LogIn.DataBaseExcel.GetLastRow(7); i++)
            {
                temp = LogIn.DataBaseExcel.ReadRange(i, 7, 15);
                newStr = "Bird ID: " + temp[0] + " , Type: " + temp[1] + " , Gender: " + temp[4] + " , Cage ID: " + temp[5] + " , fledgling: " + temp[8];
                birdsList.Items.Add(newStr);
            }

            // closing the database
            LogIn.DataBaseExcel.Quit();
        }

        public void clearDash()
        {
            // cleaning the lists
            cagesList.Items.Clear();
            birdsList.Items.Clear();
        }
    }
}

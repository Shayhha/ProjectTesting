
namespace ProjectTesting

{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Works", "Windows 11 ");
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            UserName_textbox.Text = "Has Been Clicked!";
            readExcel();
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

            //excel.WriteCell("A6", "Maxim");
            //MessageBox.Show(excel.ReadCell("A6"));

            //excel.CreateNewSheet("NewSheet");

            //excel.SelectWorkSheet("NewSheet");
            //excel.WriteCell("B2", "Hey");

            //string[] myArray = { "max", "123321" };

            //excel.WriteRange(6, 1, 2, myArray);

            //MessageBox.Show(excel.ReadCell("A6"));
            //MessageBox.Show(excel.ReadCell("B6"));

            //int last = excel.GetLastRow();
            //excel.WriteCell("A" + last.ToString(), "something");

            excel.Quit();
        }

    }
}
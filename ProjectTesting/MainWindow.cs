using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection.Metadata;

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
            UserName_textbox.Text = "Clicked!";
            readExcel();
        }

        private void readExcel()
        {
            Excel excel = new Excel("users", "Sheet1");

            //MessageBox.Show(excel.ReadCell("A2"));

            //string[,] stuff = excel.ReadRange(4, 1, 2);

            //foreach (string res in stuff)
            //{
            //    MessageBox.Show(res);
            //}



            string[] myArray = {"max","123321"};
            
            excel.WriteRange(5, 1, 2, myArray);

            excel.Quit();
        }

    }
}
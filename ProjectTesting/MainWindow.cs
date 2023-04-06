using Microsoft.Office.Interop.Excel;
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
            string filePath = PATH;
            //Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];
            MessageBox.Show(Convert.ToString(ws.Cells[1, 1].Value));

        }
    }
}
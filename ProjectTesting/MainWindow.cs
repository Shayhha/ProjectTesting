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
            MessageBox.Show("Works", "Windows 11 ");
        }

        private void button_Click(object sender, EventArgs e)
        {
            UserName_textbox.Text = "Clicked!";
        }


    }
}
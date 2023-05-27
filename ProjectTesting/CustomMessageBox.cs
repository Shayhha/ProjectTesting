
namespace ProjectTesting
{
    public partial class CustomMessageBox : Form
    {
        /// <summary>
        /// Custom message box for our application with added functions
        /// </summary>
        public CustomMessageBox()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetCurrentDirectory().Split("bin")[0] + "images\\duke.ico"); //set icon for form
            this.StartPosition = FormStartPosition.CenterScreen; //center the screen
        }

        public void ShowMessage(string message, string title, bool cross) //sets the message box 
        {
            if (cross == false) //if we want to hide the cross we check if cross if false 
            {
                Error_picture.Hide();
            }
            Text = title;
            Message_label.Text = message;
        }

        public static void Show(string message, string title, bool cross = true) //method that sets the text and dialog of message box
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.ShowMessage(message, title, cross);
            messageBox.ShowDialog();
        }

        private void OK_Button_Click(object sender, EventArgs e) //closes the message box
        {
            this.Close();
        }
    }
}

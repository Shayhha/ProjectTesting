using System.Diagnostics; // this import is used if we remove the Stopwatch comments, leave this import here.
using System.Drawing.Drawing2D;

namespace ProjectTesting
{
    public partial class HomePage : UserControl
    {
        public bool OneOption = false; // if false it means that after a search the user has more then one result
        public HomePage()
        {
            InitializeComponent();
            searchBySwitch.Checked = false;
            string text = "search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id.";
            System.Windows.Forms.ToolTip SearchRequirementsToolTip = new System.Windows.Forms.ToolTip();
            SearchRequirementsToolTip.InitialDelay = 0; // Set the delay before the ToolTip appears
            SearchRequirementsToolTip.OwnerDraw = true; // Enable owner drawing of the ToolTip
            SearchRequirementsToolTip.Draw += SearchRequirementsToolTip_Draw; // Handle the Draw event to draw the ToolTip
            SearchRequirementsToolTip.Popup += SearchRequirementsToolTip_Popup;
            SearchRequirementsToolTip.SetToolTip(Search_textbox, text);
        }

        /// <summary>
        /// sets font size of ToolTip and the background
        /// </summary>
        private void SearchRequirementsToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Set the font size of the text in the ToolTip
            Font font = new Font(e.Font.FontFamily, 12);

            // Draw the background and border of the ToolTip
            e.DrawBackground();
            e.DrawBorder();

            // Draw the text in the ToolTip using the specified font
            e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, e.Bounds);
        }

        private void SearchRequirementsToolTip_Popup(object sender, PopupEventArgs e) //sets size of ToolTip
        {
            e.ToolTipSize = new Size(400, 85);
        }

        /// <summary>
        /// This function uses the Search function we build in the SearchWindow UserControl because the
        /// functionality is exactly the same. 
        /// This function has a stopwatch functionality in comments, if you want to see the runtimes you can 
        /// remove them from the comments.
        /// </summary>
        private void Search_button_Click(object sender, EventArgs e)
        {
            //// Start the stopwatch
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //*****************Stopwatch*******************//

            string name = Search_textbox.Text; // saveing the text the user inputed into the search bar
            ((MainWindow)this.Parent.Parent).searchWindow1.ClearList(); // clearing the results list
            bool searchSwitch = searchBySwitch.Checked; // getting the users search selection (it will be True if the user selected to search for Cages and False if searches for Birds)
            int SearchResult = ((MainWindow)this.Parent.Parent).searchWindow1.Search(name, searchSwitch); // running the Search function that is writen in the SearchWindow

            if (SearchResult == 0) // this means that the Search function found more than one result, thats why we show the SearchWindow
            {
                ((MainWindow)this.Parent.Parent).searchWindow1.setTextAndSwitch(name, searchSwitch);
                ((MainWindow)this.Parent.Parent).searchWindow1.Show();
                ((MainWindow)this.Parent.Parent).showBackBtn();
                this.Hide();
            }
            else if (SearchResult == 1) // this means that the Search function found EXACTLY ONE search result, in this case we want to show the MoreDetails page
            {
                OneOption = true; // this will be used later to open the MoreDetails page
                string text = ((MainWindow)this.Parent.Parent).searchWindow1.birdList.Items[0].ToString(); //gets text in selected index
                ItemSelected(text); // this function will open the MoreDetails window based on the text the user entered and using the OneOption variable
                ((MainWindow)this.Parent.Parent).showBackBtn();
                ((MainWindow)this.Parent.Parent).searchWindow1.ClearList();
                this.Hide();
            }

            //*****************Stopwatch*******************//
            //// Stop the stopwatch
            //stopwatch.Stop();

            //// Get the elapsed time as a TimeSpan object
            //TimeSpan elapsed = stopwatch.Elapsed;

            //// Print the elapsed time in milliseconds
            //MessageBox.Show("Elapsed time: " + elapsed.TotalMilliseconds + " ms");
        }

        /// <summary>
        /// This function is built around our implementation of the results list that exists in the SearchWindow UserControl
        /// Based on the way we input information into that list we know exactly how to "decode" the information and 
        /// understand if the user searched for a bird or a cage (we use the Split function for it)
        /// </summary>
        /// <param name="text">is a stirng that represents a whole line from the search results that the user sees in the SearchWindow page in the list</param>
        public void ItemSelected(string text)
        {
            if (text.Split(",")[0].Split(" ")[0] == "Bird")
            {
                string birdId = text.Split(",")[0].Split(" ")[2].ToString(); //gets the bird id using split method
                ((MainWindow)this.Parent.Parent).moreDetails1.initLabels(birdId);
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();
                this.Hide();
            }
            else if (text.Split(",")[0].Split(" ")[0] == "Cage")
            {
                string cageId = text.Split(",")[0].Split(" ")[2].ToString(); //gets the bird id using split method
                ((MainWindow)this.Parent.Parent).moreDetails1.initLabels(cageId, "cage");
                ((MainWindow)this.Parent.Parent).moreDetails1.Show();
                this.Hide();
            }
        }

        private void Cage_pictureBox_Paint(object sender, PaintEventArgs e) // adding text over the cage image
        {
            using (Font myFont = new Font("Arial", 28, FontStyle.Bold))
            {
                string text = "Click To Add Cage";
                SizeF textSize = e.Graphics.MeasureString(text, myFont);
                int x = (Cage_pictureBox.Width - (int)textSize.Width) / 2 + 35;
                int y = (Cage_pictureBox.Height - (int)textSize.Height) + 12;

                GraphicsPath path = new GraphicsPath();
                path.AddString(text, myFont.FontFamily, (int)myFont.Style, myFont.Size, new Point(x, y), StringFormat.GenericDefault);

                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
                e.Graphics.FillPath(Brushes.White, path);
            }
        }

        private void Bird_pictureBox_Paint(object sender, PaintEventArgs e) // adding text over the bird image
        {
            using (Font myFont = new Font("Arial", 28, FontStyle.Bold))
            {
                string text = "Click To Add Bird";
                SizeF textSize = e.Graphics.MeasureString(text, myFont);
                int x = (Bird_pictureBox.Width - (int)textSize.Width) / 2 + 46;
                int y = (Bird_pictureBox.Height - (int)textSize.Height) + 12;//5

                GraphicsPath path = new GraphicsPath();
                path.AddString(text, myFont.FontFamily, (int)myFont.Style, myFont.Size, new Point(x, y), StringFormat.GenericDefault);

                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
                e.Graphics.FillPath(Brushes.White, path);
            }
        }

        private void Cage_pictureBox_Click(object sender, EventArgs e) // showing the AddCage page
        {
            ((MainWindow)this.Parent.Parent).addCage1.addButton.Location = new System.Drawing.Point(73, 348);
            ((MainWindow)this.Parent.Parent).addCage1.panel2.Location = new System.Drawing.Point(381, 72);
            ((MainWindow)this.Parent.Parent).addCage1.panel3.Location = new System.Drawing.Point(389, 63);
            ((MainWindow)this.Parent.Parent).addCage1.Show();
            ((MainWindow)this.Parent.Parent).addCage1.setTypeCombobox();
            this.Hide();
        }

        private void Bird_pictureBox_Click(object sender, EventArgs e) // showing the AddBird page
        {
            ((MainWindow)this.Parent.Parent).addBird1.Show();
            ((MainWindow)this.Parent.Parent).addBird1.setTypeCombobox();
            ((MainWindow)this.Parent.Parent).addBird1.setSubTypeCombobox();
            this.Hide();
        }

        public void cleanTextbox()
        {
            Search_textbox.Text = "";
            searchBySwitch.Checked = false;
        }

        public void setTextAndSwitch(string text, bool option) // this function transfers the text and search switch position from homepage to searchBird window 
        {
            Search_textbox.Text = text;
            searchBySwitch.Checked = option;
        }
    }
}

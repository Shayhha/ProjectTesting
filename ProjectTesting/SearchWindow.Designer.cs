namespace ProjectTesting
{
    partial class SearchWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            birdList = new ListBox();
            colorDialog1 = new ColorDialog();
            tempListBox = new ListBox();
            Search_button = new RJControls.RJButton();
            Search_textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            searchBySwitch = new RJControls.RJToggleButton();
            SuspendLayout();
            // 
            // birdList
            // 
            birdList.BackColor = Color.WhiteSmoke;
            birdList.Cursor = Cursors.Hand;
            birdList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            birdList.FormattingEnabled = true;
            birdList.ItemHeight = 41;
            birdList.Items.AddRange(new object[] { "Bird Id: 93754 , Type: Something , Gender: Male , Cage id: 991A13 | click for more details", "Bird Id: 72721 , Type: Australian Gouldian, Gender: Female , Cage id: BE318R | click for more details" });
            birdList.Location = new Point(29, 249);
            birdList.Margin = new Padding(3, 4, 3, 4);
            birdList.Name = "birdList";
            birdList.Size = new Size(1388, 496);
            birdList.TabIndex = 0;
            birdList.SelectedIndexChanged += birdList_SelectedIndexChanged;
            // 
            // tempListBox
            // 
            tempListBox.BackColor = Color.WhiteSmoke;
            tempListBox.Cursor = Cursors.Hand;
            tempListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tempListBox.FormattingEnabled = true;
            tempListBox.ItemHeight = 41;
            tempListBox.Location = new Point(29, 249);
            tempListBox.Margin = new Padding(3, 4, 3, 4);
            tempListBox.Name = "tempListBox";
            tempListBox.Size = new Size(1388, 496);
            tempListBox.TabIndex = 15;
            // 
            // Search_button
            // 
            Search_button.BackColor = Color.FromArgb(145, 199, 136);
            Search_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            Search_button.BorderColor = Color.FromArgb(115, 165, 100);
            Search_button.BorderRadius = 10;
            Search_button.BorderSize = 2;
            Search_button.Cursor = Cursors.Hand;
            Search_button.FlatAppearance.BorderSize = 0;
            Search_button.FlatStyle = FlatStyle.Flat;
            Search_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search_button.ForeColor = Color.Black;
            Search_button.Location = new Point(893, 88);
            Search_button.Margin = new Padding(3, 4, 3, 4);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(120, 44);
            Search_button.TabIndex = 2;
            Search_button.Text = "Search";
            Search_button.TextColor = Color.Black;
            Search_button.UseVisualStyleBackColor = false;
            Search_button.Click += Search_Button_Click;
            // 
            // Search_textbox
            // 
            Search_textbox.Cursor = Cursors.IBeam;
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.Location = new Point(455, 91);
            Search_textbox.Margin = new Padding(3, 4, 3, 4);
            Search_textbox.Name = "Search_textbox";
            Search_textbox.PlaceholderText = "  Search for birds/cages.....";
            Search_textbox.ScrollBars = ScrollBars.Vertical;
            Search_textbox.Size = new Size(428, 39);
            Search_textbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(562, 144);
            label2.Name = "label2";
            label2.Size = new Size(68, 32);
            label2.TabIndex = 52;
            label2.Text = "Birds";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(699, 144);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 51;
            label1.Text = "Cages";
            // 
            // searchBySwitch
            // 
            searchBySwitch.Cursor = Cursors.Hand;
            searchBySwitch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBySwitch.Location = new Point(630, 145);
            searchBySwitch.Margin = new Padding(3, 4, 3, 4);
            searchBySwitch.MinimumSize = new Size(51, 29);
            searchBySwitch.Name = "searchBySwitch";
            searchBySwitch.OffBackColor = Color.FromArgb(153, 169, 143);
            searchBySwitch.OffToggleColor = Color.WhiteSmoke;
            searchBySwitch.OnBackColor = Color.FromArgb(97, 135, 110);
            searchBySwitch.OnToggleColor = Color.FromArgb(145, 199, 136);
            searchBySwitch.Size = new Size(63, 32);
            searchBySwitch.TabIndex = 50;
            searchBySwitch.UseVisualStyleBackColor = true;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchBySwitch);
            Controls.Add(Search_textbox);
            Controls.Add(Search_button);
            Controls.Add(birdList);
            Controls.Add(tempListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchWindow";
            Size = new Size(1445, 815);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox birdList;
        private ColorDialog colorDialog1;
        private ListBox tempListBox;
        public TextBox Search_textbox;
        private RJControls.RJButton Search_button;
        private Label label2;
        private Label label1;
        public RJControls.RJToggleButton searchBySwitch;
    }
}

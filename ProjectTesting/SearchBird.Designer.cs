namespace ProjectTesting
{
    partial class SearchBird
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
            birdList.ItemHeight = 32;
            birdList.Items.AddRange(new object[] { "Bird Id: 93754 , Type: Something , Gender: Male , Cage id: 991A13 | click for more details", "Bird Id: 72721 , Type: Australian Gouldian, Gender: Female , Cage id: BE318R | click for more details" });
            birdList.Location = new Point(25, 187);
            birdList.Name = "birdList";
            birdList.Size = new Size(1215, 356);
            birdList.TabIndex = 0;
            birdList.SelectedIndexChanged += birdList_SelectedIndexChanged;
            // 
            // tempListBox
            // 
            tempListBox.BackColor = Color.WhiteSmoke;
            tempListBox.Cursor = Cursors.Hand;
            tempListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tempListBox.FormattingEnabled = true;
            tempListBox.ItemHeight = 32;
            tempListBox.Location = new Point(25, 187);
            tempListBox.Name = "tempListBox";
            tempListBox.Size = new Size(1215, 356);
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
            Search_button.Location = new Point(768, 41);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(105, 33);
            Search_button.TabIndex = 43;
            Search_button.Text = "Search";
            Search_button.TextColor = Color.Black;
            Search_button.UseVisualStyleBackColor = false;
            Search_button.Click += Search_button_Click;
            // 
            // Search_textbox
            // 
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.Location = new Point(385, 41);
            Search_textbox.Name = "Search_textbox";
            Search_textbox.PlaceholderText = "  Search for birds/cages.....";
            Search_textbox.ScrollBars = ScrollBars.Vertical;
            Search_textbox.Size = new Size(375, 33);
            Search_textbox.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(385, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 52;
            label2.Text = "Birds";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(505, 82);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 51;
            label1.Text = "Cages";
            // 
            // searchBySwitch
            // 
            searchBySwitch.Cursor = Cursors.Hand;
            searchBySwitch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBySwitch.Location = new Point(444, 83);
            searchBySwitch.MinimumSize = new Size(45, 22);
            searchBySwitch.Name = "searchBySwitch";
            searchBySwitch.OffBackColor = Color.FromArgb(153, 169, 143);
            searchBySwitch.OffToggleColor = Color.WhiteSmoke;
            searchBySwitch.OnBackColor = Color.FromArgb(97, 135, 110);
            searchBySwitch.OnToggleColor = Color.FromArgb(145, 199, 136);
            searchBySwitch.Size = new Size(55, 24);
            searchBySwitch.TabIndex = 50;
            searchBySwitch.UseVisualStyleBackColor = true;
            // 
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchBySwitch);
            Controls.Add(Search_textbox);
            Controls.Add(Search_button);
            Controls.Add(birdList);
            Controls.Add(tempListBox);
            Name = "SearchBird";
            Size = new Size(1264, 611);
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
        private RJControls.RJToggleButton searchBySwitch;
    }
}

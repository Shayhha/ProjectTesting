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
            Search_label = new Label();
            colorDialog1 = new ColorDialog();
            comboBox = new ComboBox();
            tempListBox = new ListBox();
            rjToggleButton1 = new RJControls.RJToggleButton();
            Search_button = new RJControls.RJButton();
            Search_textbox = new TextBox();
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
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search_label.Location = new Point(385, 88);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(188, 25);
            Search_label.TabIndex = 3;
            Search_label.Text = "Choose search type: ";
            // 
            // comboBox
            // 
            comboBox.Cursor = Cursors.Hand;
            comboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Bird", "Cage" });
            comboBox.Location = new Point(566, 88);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(87, 28);
            comboBox.TabIndex = 14;
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
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Location = new Point(692, 90);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.FromArgb(153, 169, 143);
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.FromArgb(97, 135, 110);
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(45, 22);
            rjToggleButton1.TabIndex = 40;
            rjToggleButton1.UseVisualStyleBackColor = true;
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
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(Search_textbox);
            Controls.Add(Search_button);
            Controls.Add(rjToggleButton1);
            Controls.Add(comboBox);
            Controls.Add(Search_label);
            Controls.Add(birdList);
            Controls.Add(tempListBox);
            Name = "SearchBird";
            Size = new Size(1264, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox birdList;
        private Label Search_label;
        private ColorDialog colorDialog1; 
        private ComboBox comboBox;
        private ListBox tempListBox;
        public TextBox Search_textbox;
        private RJControls.RJToggleButton rjToggleButton1;
        private RJControls.RJButton Search_button;
    }
}

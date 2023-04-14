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
            Search_textbox = new TextBox();
            Search_label = new Label();
            label2 = new Label();
            Search_button = new Button();
            colorDialog1 = new ColorDialog();
            comboBox = new ComboBox();
            SuspendLayout();
            // 
            // birdList
            // 
            birdList.Cursor = Cursors.Hand;
            birdList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            birdList.FormattingEnabled = true;
            birdList.ItemHeight = 32;
            birdList.Items.AddRange(new object[] { "Bird Id: 93754 , Type: Something , Gender: Male , Cage id: 991A13 | click for more details", "Bird Id: 72721 , Type: Australian Gouldian, Gender: Female , Cage id: BE318R | click for more details" });
            birdList.Location = new Point(23, 165);
            birdList.Name = "birdList";
            birdList.Size = new Size(1215, 420);
            birdList.TabIndex = 0;
            birdList.SelectedIndexChanged += birdList_SelectedIndexChanged;
            // 
            // Search_textbox
            // 
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.Location = new Point(385, 50);
            Search_textbox.Name = "Search_textbox";
            Search_textbox.PlaceholderText = "  Search for birds/cages.....";
            Search_textbox.ScrollBars = ScrollBars.Vertical;
            Search_textbox.Size = new Size(350, 33);
            Search_textbox.TabIndex = 2;
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search_label.Location = new Point(385, 88);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(185, 25);
            Search_label.TabIndex = 3;
            Search_label.Text = "choose search type: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 127);
            label2.Name = "label2";
            label2.Size = new Size(769, 20);
            label2.TabIndex = 4;
            label2.Text = "( search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id )";
            
            // 
            // Search_button
            // 
            Search_button.Cursor = Cursors.Hand;
            Search_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_button.Location = new Point(741, 50);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(156, 35);
            Search_button.TabIndex = 6;
            Search_button.Text = "Search Results";
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // comboBox
            // 
            comboBox.Cursor = Cursors.Hand;
            comboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Bird", "Cage" });
            comboBox.Location = new Point(576, 88);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(87, 28);
            comboBox.TabIndex = 14;
            // 
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(Search_button);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(Search_label);
            Controls.Add(Search_textbox);
            Controls.Add(birdList);
            Name = "SearchBird";
            Size = new Size(1264, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox birdList;
        public TextBox Search_textbox;
        private Label Search_label;
        private Label label2;
        private Button Search_button;
        private ColorDialog colorDialog1; // what is this? *****************
        private ComboBox comboBox;
    }
}

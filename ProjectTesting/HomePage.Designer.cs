namespace ProjectTesting
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            LogOut_button = new Button();
            Bird_label = new Label();
            Cage_pictureBox = new PictureBox();
            Bird_pictureBox = new PictureBox();
            Cage_label = new Label();
            Search_button = new Button();
            comboBox = new ComboBox();
            label2 = new Label();
            Search_label = new Label();
            Search_textbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // LogOut_button
            // 
            LogOut_button.BackColor = Color.IndianRed;
            LogOut_button.Cursor = Cursors.Hand;
            LogOut_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogOut_button.ForeColor = Color.White;
            LogOut_button.Location = new Point(1127, 25);
            LogOut_button.Name = "LogOut_button";
            LogOut_button.Size = new Size(90, 40);
            LogOut_button.TabIndex = 2;
            LogOut_button.Text = "Log-out";
            LogOut_button.UseVisualStyleBackColor = false;
            LogOut_button.Click += LogOut_button_Click;
            // 
            // Bird_label
            // 
            Bird_label.AutoSize = true;
            Bird_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Bird_label.Location = new Point(1024, 35);
            Bird_label.Name = "Bird_label";
            Bird_label.Size = new Size(57, 20);
            Bird_label.TabIndex = 3;
            Bird_label.Text = "Brids: Y";
            // 
            // Cage_pictureBox
            // 
            Cage_pictureBox.Cursor = Cursors.Hand;
            Cage_pictureBox.Image = (Image)resources.GetObject("Cage_pictureBox.Image");
            Cage_pictureBox.Location = new Point(221, 230);
            Cage_pictureBox.Name = "Cage_pictureBox";
            Cage_pictureBox.Size = new Size(300, 300);
            Cage_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Cage_pictureBox.TabIndex = 6;
            Cage_pictureBox.TabStop = false;
            Cage_pictureBox.Tag = "";
            Cage_pictureBox.Click += Cage_pictureBox_Click;
            Cage_pictureBox.Paint += Cage_pictureBox_Paint;
            // 
            // Bird_pictureBox
            // 
            Bird_pictureBox.Cursor = Cursors.Hand;
            Bird_pictureBox.Image = (Image)resources.GetObject("Bird_pictureBox.Image");
            Bird_pictureBox.Location = new Point(794, 230);
            Bird_pictureBox.Name = "Bird_pictureBox";
            Bird_pictureBox.Size = new Size(300, 300);
            Bird_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Bird_pictureBox.TabIndex = 7;
            Bird_pictureBox.TabStop = false;
            Bird_pictureBox.Tag = "";
            Bird_pictureBox.Click += Bird_pictureBox_Click;
            Bird_pictureBox.Paint += Bird_pictureBox_Paint;
            // 
            // Cage_label
            // 
            Cage_label.AutoSize = true;
            Cage_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cage_label.Location = new Point(953, 35);
            Cage_label.Name = "Cage_label";
            Cage_label.Size = new Size(59, 20);
            Cage_label.TabIndex = 8;
            Cage_label.Text = "Cage: X";
            // 
            // Search_button
            // 
            Search_button.Cursor = Cursors.Hand;
            Search_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_button.Location = new Point(851, 96);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(156, 35);
            Search_button.TabIndex = 12;
            Search_button.Text = "Search Results";
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // comboBox
            // 
            comboBox.Cursor = Cursors.Hand;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Bird", "Cage" });
            comboBox.Location = new Point(590, 137);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(147, 23);
            comboBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(274, 184);
            label2.Name = "label2";
            label2.Size = new Size(769, 20);
            label2.TabIndex = 11;
            label2.Text = "( search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id )";
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search_label.Location = new Point(411, 101);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(79, 25);
            Search_label.TabIndex = 10;
            Search_label.Text = "Search: ";
            // 
            // Search_textbox
            // 
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.Location = new Point(495, 98);
            Search_textbox.Name = "Search_textbox";
            Search_textbox.ScrollBars = ScrollBars.Vertical;
            Search_textbox.Size = new Size(350, 33);
            Search_textbox.TabIndex = 9;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(Search_button);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(Search_label);
            Controls.Add(Search_textbox);
            Controls.Add(Cage_label);
            Controls.Add(Bird_pictureBox);
            Controls.Add(Cage_pictureBox);
            Controls.Add(Bird_label);
            Controls.Add(LogOut_button);
            Name = "HomePage";
            Size = new Size(1264, 611);
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogOut_button;
        private Label Bird_label;
        private PictureBox Cage_pictureBox;
        private PictureBox Bird_pictureBox;
        private Label Cage_label;
        private Button Search_button;
        private ComboBox comboBox;
        private Label label2;
        private Label Search_label;
        private TextBox Search_textbox;
    }
}

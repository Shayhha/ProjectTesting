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
            Cage_pictureBox = new PictureBox();
            Bird_pictureBox = new PictureBox();
            comboBox = new ComboBox();
            Search_label = new Label();
            rjToggleButton1 = new RJControls.RJToggleButton();
            Search_button = new RJControls.RJButton();
            Search_textbox = new RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Cage_pictureBox
            // 
            Cage_pictureBox.Cursor = Cursors.Hand;
            Cage_pictureBox.Image = (Image)resources.GetObject("Cage_pictureBox.Image");
            Cage_pictureBox.Location = new Point(248, 196);
            Cage_pictureBox.Name = "Cage_pictureBox";
            Cage_pictureBox.Size = new Size(306, 327);
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
            Bird_pictureBox.Location = new Point(658, 196);
            Bird_pictureBox.Name = "Bird_pictureBox";
            Bird_pictureBox.Size = new Size(359, 327);
            Bird_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Bird_pictureBox.TabIndex = 7;
            Bird_pictureBox.TabStop = false;
            Bird_pictureBox.Tag = "";
            Bird_pictureBox.Click += Bird_pictureBox_Click;
            Bird_pictureBox.Paint += Bird_pictureBox_Paint;
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
            comboBox.TabIndex = 13;
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search_label.Location = new Point(385, 88);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(185, 25);
            Search_label.TabIndex = 10;
            Search_label.Text = "choose search type: ";
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Location = new Point(729, 92);
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
            Search_button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Search_button.ForeColor = Color.Black;
            Search_button.Location = new Point(772, 41);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(153, 40);
            Search_button.TabIndex = 41;
            Search_button.Text = "Search Results";
            Search_button.TextColor = Color.Black;
            Search_button.UseVisualStyleBackColor = false;
            Search_button.Click += Search_button_Click;
            // 
            // Search_textbox
            // 
            Search_textbox.BackColor = SystemColors.Window;
            Search_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            Search_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            Search_textbox.BorderRadius = 10;
            Search_textbox.BorderSize = 2;
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            Search_textbox.Location = new Point(385, 41);
            Search_textbox.Margin = new Padding(4);
            Search_textbox.Multiline = false;
            Search_textbox.Name = "Search_textbox";
            Search_textbox.Padding = new Padding(10, 7, 10, 7);
            Search_textbox.PasswordChar = false;
            Search_textbox.PlaceholderColor = Color.DarkGray;
            Search_textbox.PlaceholderText = "Search for birds/cages.....";
            Search_textbox.Size = new Size(375, 40);
            Search_textbox.TabIndex = 42;
            Search_textbox.Texts = "";
            Search_textbox.UnderlinedStyle = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(Search_textbox);
            Controls.Add(Search_button);
            Controls.Add(rjToggleButton1);
            Controls.Add(comboBox);
            Controls.Add(Search_label);
            Controls.Add(Bird_pictureBox);
            Controls.Add(Cage_pictureBox);
            Name = "HomePage";
            Size = new Size(1264, 611);
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Cage_pictureBox;
        private PictureBox Bird_pictureBox;
        private ComboBox comboBox;
        private Label Search_label;
        private RJControls.RJToggleButton rjToggleButton1;
        private RJControls.RJButton Search_button;
        private RJControls.RJTextBox Search_textbox;
    }
}

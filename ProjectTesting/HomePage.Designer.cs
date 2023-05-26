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
            searchBySwitch = new RJControls.RJToggleButton();
            Search_button = new RJControls.RJButton();
            Search_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Cage_pictureBox
            // 
            Cage_pictureBox.Cursor = Cursors.Hand;
            Cage_pictureBox.Image = (Image)resources.GetObject("Cage_pictureBox.Image");
            Cage_pictureBox.Location = new Point(248, 184);
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
            Bird_pictureBox.Location = new Point(658, 184);
            Bird_pictureBox.Name = "Bird_pictureBox";
            Bird_pictureBox.Size = new Size(359, 327);
            Bird_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Bird_pictureBox.TabIndex = 7;
            Bird_pictureBox.TabStop = false;
            Bird_pictureBox.Tag = "";
            Bird_pictureBox.Click += Bird_pictureBox_Click;
            Bird_pictureBox.Paint += Bird_pictureBox_Paint;
            // 
            // searchBySwitch
            // 
            searchBySwitch.Cursor = Cursors.Hand;
            searchBySwitch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBySwitch.Location = new Point(551, 109);
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
            Search_button.Location = new Point(781, 68);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(105, 33);
            Search_button.TabIndex = 2;
            Search_button.Text = "Search";
            Search_button.TextColor = Color.Black;
            Search_button.UseVisualStyleBackColor = false;
            Search_button.Click += Search_button_Click;
            // 
            // Search_textbox
            // 
            Search_textbox.Cursor = Cursors.IBeam;
            Search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Search_textbox.Location = new Point(398, 68);
            Search_textbox.Name = "Search_textbox";
            Search_textbox.PlaceholderText = "  Search for birds/cages.....";
            Search_textbox.ScrollBars = ScrollBars.Vertical;
            Search_textbox.Size = new Size(375, 33);
            Search_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(612, 108);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 48;
            label1.Text = "Cages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(492, 108);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 49;
            label2.Text = "Birds";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Search_textbox);
            Controls.Add(Search_button);
            Controls.Add(searchBySwitch);
            Controls.Add(Bird_pictureBox);
            Controls.Add(Cage_pictureBox);
            Name = "HomePage";
            Size = new Size(1264, 611);
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Cage_pictureBox;
        private PictureBox Bird_pictureBox;
        private RJControls.RJToggleButton searchBySwitch;
        private RJControls.RJButton Search_button;
        public TextBox Search_textbox;
        private Label label1;
        private Label label2;
    }
}

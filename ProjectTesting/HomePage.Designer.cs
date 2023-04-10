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
            Search_button = new Button();
            LogOut_button = new Button();
            Bird_label = new Label();
            Cage_pictureBox = new PictureBox();
            Bird_pictureBox = new PictureBox();
            Cage_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Search_button
            // 
            Search_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Search_button.Location = new Point(504, 124);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(340, 45);
            Search_button.TabIndex = 0;
            Search_button.Text = "Search Birds/Cages";
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // LogOut_button
            // 
            LogOut_button.BackColor = Color.IndianRed;
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
            Cage_pictureBox.Location = new Point(167, 259);
            Cage_pictureBox.Name = "Cage_pictureBox";
            Cage_pictureBox.Size = new Size(386, 215);
            Cage_pictureBox.TabIndex = 6;
            Cage_pictureBox.TabStop = false;
            // 
            // Bird_pictureBox
            // 
            Bird_pictureBox.Location = new Point(773, 259);
            Bird_pictureBox.Name = "Bird_pictureBox";
            Bird_pictureBox.Size = new Size(386, 215);
            Bird_pictureBox.TabIndex = 7;
            Bird_pictureBox.TabStop = false;
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
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(Cage_label);
            Controls.Add(Bird_pictureBox);
            Controls.Add(Cage_pictureBox);
            Controls.Add(Bird_label);
            Controls.Add(LogOut_button);
            Controls.Add(Search_button);
            Name = "HomePage";
            Size = new Size(1280, 720);
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)Cage_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Search_button;
        private Button LogOut_button;
        private Label Bird_label;
        private PictureBox Cage_pictureBox;
        private PictureBox Bird_pictureBox;
        private Label Cage_label;
    }
}

namespace ProjectTesting
{
    partial class UserDash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            cagesLabel = new Label();
            birdsLabel = new Label();
            birdsList = new ListBox();
            cagesList = new ListBox();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(9, 11);
            usernameLabel.Margin = new Padding(0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(300, 46);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Hello USERNAME";
            // 
            // cagesLabel
            // 
            cagesLabel.AutoSize = true;
            cagesLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cagesLabel.Location = new Point(14, 437);
            cagesLabel.Name = "cagesLabel";
            cagesLabel.Size = new Size(208, 32);
            cagesLabel.TabIndex = 10;
            cagesLabel.Text = "You have Y cages:";
            // 
            // birdsLabel
            // 
            birdsLabel.AutoSize = true;
            birdsLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            birdsLabel.Location = new Point(14, 76);
            birdsLabel.Name = "birdsLabel";
            birdsLabel.Size = new Size(201, 32);
            birdsLabel.TabIndex = 9;
            birdsLabel.Text = "You have X birds:";
            // 
            // birdsList
            // 
            birdsList.BackColor = Color.WhiteSmoke;
            birdsList.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            birdsList.FormattingEnabled = true;
            birdsList.ItemHeight = 30;
            birdsList.Items.AddRange(new object[] { "Bird Id: 72721 , Type: Australian Gouldian , Gender: Female , Cage id: BE318R , Adult: no" });
            birdsList.Location = new Point(14, 113);
            birdsList.Margin = new Padding(3, 4, 3, 4);
            birdsList.Name = "birdsList";
            birdsList.Size = new Size(912, 274);
            birdsList.TabIndex = 8;
            // 
            // cagesList
            // 
            cagesList.BackColor = Color.WhiteSmoke;
            cagesList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cagesList.FormattingEnabled = true;
            cagesList.ItemHeight = 32;
            cagesList.Items.AddRange(new object[] { "Cage Id: A5342G , Length: 200 , Width: 400 , Height: 600 , Material: PLASTIC" });
            cagesList.Location = new Point(14, 475);
            cagesList.Margin = new Padding(3, 4, 3, 4);
            cagesList.Name = "cagesList";
            cagesList.Size = new Size(912, 228);
            cagesList.TabIndex = 7;
            // 
            // UserDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            ClientSize = new Size(938, 728);
            Controls.Add(usernameLabel);
            Controls.Add(cagesLabel);
            Controls.Add(birdsLabel);
            Controls.Add(birdsList);
            Controls.Add(cagesList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UserDash";
            Text = "UserDash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label cagesLabel;
        private Label birdsLabel;
        private ListBox birdsList;
        private ListBox cagesList;
    }
}
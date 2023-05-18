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
            usernameLabel.Location = new Point(8, 8);
            usernameLabel.Margin = new Padding(0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(240, 37);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Hello USERNAME";
            // 
            // cagesLabel
            // 
            cagesLabel.AutoSize = true;
            cagesLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            cagesLabel.Location = new Point(12, 328);
            cagesLabel.Name = "cagesLabel";
            cagesLabel.Size = new Size(163, 25);
            cagesLabel.TabIndex = 10;
            cagesLabel.Text = "You have Y cages:";
            // 
            // birdsLabel
            // 
            birdsLabel.AutoSize = true;
            birdsLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            birdsLabel.Location = new Point(12, 57);
            birdsLabel.Name = "birdsLabel";
            birdsLabel.Size = new Size(158, 25);
            birdsLabel.TabIndex = 9;
            birdsLabel.Text = "You have X birds:";
            // 
            // birdsList
            // 
            birdsList.BackColor = Color.WhiteSmoke;
            birdsList.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            birdsList.FormattingEnabled = true;
            birdsList.ItemHeight = 23;
            birdsList.Items.AddRange(new object[] { "Bird Id: 72721 , Type: Australian Gouldian , Gender: Female , Cage id: BE318R , Adult: no" });
            birdsList.Location = new Point(12, 85);
            birdsList.Name = "birdsList";
            birdsList.Size = new Size(768, 211);
            birdsList.TabIndex = 8;
            // 
            // cagesList
            // 
            cagesList.BackColor = Color.WhiteSmoke;
            cagesList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cagesList.FormattingEnabled = true;
            cagesList.ItemHeight = 25;
            cagesList.Items.AddRange(new object[] { "Cage Id: A5342G , Length: 200 , Width: 400 , Height: 600 , Material: PLASTIC" });
            cagesList.Location = new Point(12, 356);
            cagesList.Name = "cagesList";
            cagesList.Size = new Size(768, 179);
            cagesList.TabIndex = 7;
            // 
            // UserDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            ClientSize = new Size(794, 546);
            Controls.Add(usernameLabel);
            Controls.Add(cagesLabel);
            Controls.Add(birdsLabel);
            Controls.Add(birdsList);
            Controls.Add(cagesList);
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
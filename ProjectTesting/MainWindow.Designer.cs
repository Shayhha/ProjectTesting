namespace ProjectTesting
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headlinePanel = new Panel();
            Back_Button = new Button();
            Cage_label = new Label();
            Bird_label = new Label();
            logOutButton = new Button();
            contentPanel = new Panel();
            moreDetails1 = new MoreDetails();
            searchBird1 = new SearchBird();
            addCage1 = new AddCage();
            addBird1 = new AddBird();
            homePage1 = new HomePage();
            signUp1 = new SignUp();
            logIn1 = new LogIn();
            headlinePanel.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headlinePanel
            // 
            headlinePanel.BackColor = Color.DarkSlateGray;
            headlinePanel.Controls.Add(Back_Button);
            headlinePanel.Controls.Add(Cage_label);
            headlinePanel.Controls.Add(Bird_label);
            headlinePanel.Controls.Add(logOutButton);
            headlinePanel.Location = new Point(0, 0);
            headlinePanel.Name = "headlinePanel";
            headlinePanel.Size = new Size(1264, 70);
            headlinePanel.TabIndex = 1;
            // 
            // Back_Button
            // 
            Back_Button.Cursor = Cursors.Hand;
            Back_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(12, 14);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(90, 40);
            Back_Button.TabIndex = 11;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Visible = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // Cage_label
            // 
            Cage_label.AutoSize = true;
            Cage_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cage_label.ForeColor = Color.White;
            Cage_label.Location = new Point(965, 25);
            Cage_label.Name = "Cage_label";
            Cage_label.Size = new Size(65, 21);
            Cage_label.TabIndex = 10;
            Cage_label.Text = "Cage: X";
            // 
            // Bird_label
            // 
            Bird_label.AutoSize = true;
            Bird_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Bird_label.ForeColor = Color.White;
            Bird_label.Location = new Point(1048, 25);
            Bird_label.Name = "Bird_label";
            Bird_label.Size = new Size(64, 21);
            Bird_label.TabIndex = 9;
            Bird_label.Text = "Brids: Y";
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.IndianRed;
            logOutButton.Cursor = Cursors.Hand;
            logOutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(1162, 14);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(90, 40);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log-out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Controls.Add(moreDetails1);
            contentPanel.Controls.Add(searchBird1);
            contentPanel.Controls.Add(addCage1);
            contentPanel.Controls.Add(addBird1);
            contentPanel.Controls.Add(homePage1);
            contentPanel.Controls.Add(signUp1);
            contentPanel.Controls.Add(logIn1);
            contentPanel.Location = new Point(0, 71);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1264, 611);
            contentPanel.TabIndex = 2;
            // 
            // moreDetails1
            // 
            moreDetails1.Location = new Point(0, 0);
            moreDetails1.Name = "moreDetails1";
            moreDetails1.Size = new Size(1264, 611);
            moreDetails1.TabIndex = 6;
            moreDetails1.Visible = false;
            // 
            // searchBird1
            // 
            searchBird1.BackColor = Color.LightCyan;
            searchBird1.Location = new Point(0, 0);
            searchBird1.Name = "searchBird1";
            searchBird1.Size = new Size(1264, 611);
            searchBird1.TabIndex = 5;
            searchBird1.Visible = false;
            // 
            // addCage1
            // 
            addCage1.Location = new Point(0, 0);
            addCage1.Name = "addCage1";
            addCage1.Size = new Size(1264, 611);
            addCage1.TabIndex = 4;
            addCage1.Visible = false;
            // 
            // addBird1
            // 
            addBird1.Location = new Point(0, 0);
            addBird1.Name = "addBird1";
            addBird1.Size = new Size(1264, 611);
            addBird1.TabIndex = 3;
            addBird1.Visible = false;
            // 
            // homePage1
            // 
            homePage1.BackColor = Color.LightCyan;
            homePage1.Location = new Point(0, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(1264, 611);
            homePage1.TabIndex = 2;
            homePage1.Visible = false;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.LightCyan;
            signUp1.Location = new Point(0, 0);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(1264, 611);
            signUp1.TabIndex = 1;
            signUp1.Visible = false;
            // 
            // logIn1
            // 
            logIn1.BackColor = Color.LightCyan;
            logIn1.Location = new Point(0, 0);
            logIn1.Name = "logIn1";
            logIn1.Size = new Size(1264, 611);
            logIn1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1264, 681);
            Controls.Add(contentPanel);
            Controls.Add(headlinePanel);
            Name = "MainWindow";
            Text = "MainWindow";
            headlinePanel.ResumeLayout(false);
            headlinePanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel headlinePanel;
        private Panel contentPanel;
        public MoreDetails moreDetails1;
        public SearchBird searchBird1;
        public AddCage addCage1;
        public AddBird addBird1;
        public HomePage homePage1;
        public SignUp signUp1;
        public LogIn logIn1;
        private Button logOutButton;
        private Label Cage_label;
        private Label Bird_label;
        public Button Back_Button;
    }
}
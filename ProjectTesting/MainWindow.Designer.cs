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
            label1 = new Label();
            headlinePanel = new Panel();
            contentPanel = new Panel();
            moreDetails1 = new MoreDetails();
            searchBird1 = new SearchBird();
            addCage1 = new AddCage();
            addBird1 = new AddBird();
            homePage1 = new HomePage();
            signUp1 = new SignUp();
            logIn1 = new LogIn();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // headlinePanel
            // 
            headlinePanel.BackColor = Color.DarkSlateGray;
            headlinePanel.Location = new Point(0, 0);
            headlinePanel.Name = "headlinePanel";
            headlinePanel.Size = new Size(1264, 70);
            headlinePanel.TabIndex = 1;
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
            moreDetails1.Size = new Size(1280, 720);
            moreDetails1.TabIndex = 6;
            moreDetails1.Visible = false;
            // 
            // searchBird1
            // 
            searchBird1.BackColor = Color.LightCyan;
            searchBird1.Location = new Point(0, 0);
            searchBird1.Name = "searchBird1";
            searchBird1.Size = new Size(1280, 720);
            searchBird1.TabIndex = 5;
            searchBird1.Visible = false;
            // 
            // addCage1
            // 
            addCage1.Location = new Point(0, 0);
            addCage1.Name = "addCage1";
            addCage1.Size = new Size(1280, 720);
            addCage1.TabIndex = 4;
            addCage1.Visible = false;
            // 
            // addBird1
            // 
            addBird1.Location = new Point(0, 0);
            addBird1.Name = "addBird1";
            addBird1.Size = new Size(1280, 720);
            addBird1.TabIndex = 3;
            addBird1.Visible = false;
            // 
            // homePage1
            // 
            homePage1.BackColor = Color.LightCyan;
            homePage1.Location = new Point(0, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(1280, 720);
            homePage1.TabIndex = 2;
            homePage1.Visible = false;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.LightCyan;
            signUp1.Location = new Point(0, 0);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(1280, 720);
            signUp1.TabIndex = 1;
            signUp1.Visible = false;
            // 
            // logIn1
            // 
            logIn1.Location = new Point(0, 0);
            logIn1.Name = "logIn1";
            logIn1.Size = new Size(1280, 720);
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
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "MainWindow";
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel headlinePanel;
        private Panel contentPanel;
        private MoreDetails moreDetails1;
        public SearchBird searchBird1;
        private AddCage addCage1;
        private AddBird addBird1;
        public HomePage homePage1;
        private SignUp signUp1;
        private LogIn logIn1;

        // maybe do some set and get functions or regular methods that allow us to for example hide homePage1 and show searchBird1
    }
}
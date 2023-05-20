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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            headlinePanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            logOutButton = new Button();
            Back_Button = new Button();
            dashboardButton = new Button();
            countersPanel = new Panel();
            Cage_label = new Label();
            Bird_label = new Label();
            appIcon = new PictureBox();
            contentPanel = new Panel();
            moreDetails1 = new MoreDetails();
            searchBird1 = new SearchBird();
            addCage1 = new AddCage();
            addBird1 = new AddBird();
            homePage1 = new HomePage();
            signUp1 = new SignUp();
            logIn1 = new LogIn();
            headlinePanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            countersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appIcon).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headlinePanel
            // 
            headlinePanel.BackColor = Color.FromArgb(50, 80, 57);
            headlinePanel.Controls.Add(flowLayoutPanel1);
            headlinePanel.Controls.Add(appIcon);
            headlinePanel.Location = new Point(0, 0);
            headlinePanel.Name = "headlinePanel";
            headlinePanel.Size = new Size(1264, 71);
            headlinePanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(logOutButton);
            flowLayoutPanel1.Controls.Add(Back_Button);
            flowLayoutPanel1.Controls.Add(dashboardButton);
            flowLayoutPanel1.Controls.Add(countersPanel);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(775, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(476, 70);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // logOutButton
            // 
            logOutButton.Anchor = AnchorStyles.Right;
            logOutButton.BackColor = Color.IndianRed;
            logOutButton.Cursor = Cursors.Hand;
            logOutButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(373, 11);
            logOutButton.Margin = new Padding(13, 3, 3, 3);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(100, 40);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log-out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // Back_Button
            // 
            Back_Button.Anchor = AnchorStyles.Right;
            Back_Button.Cursor = Cursors.Hand;
            Back_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(267, 11);
            Back_Button.Margin = new Padding(13, 3, 3, 3);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(90, 40);
            Back_Button.TabIndex = 11;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Visible = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Anchor = AnchorStyles.Right;
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardButton.Location = new Point(121, 11);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(130, 40);
            dashboardButton.TabIndex = 12;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // countersPanel
            // 
            countersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countersPanel.BackColor = Color.Transparent;
            countersPanel.Controls.Add(Cage_label);
            countersPanel.Controls.Add(Bird_label);
            countersPanel.Location = new Point(22, 3);
            countersPanel.Name = "countersPanel";
            countersPanel.Size = new Size(93, 56);
            countersPanel.TabIndex = 16;
            // 
            // Cage_label
            // 
            Cage_label.AutoSize = true;
            Cage_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cage_label.ForeColor = Color.White;
            Cage_label.Location = new Point(7, 5);
            Cage_label.Name = "Cage_label";
            Cage_label.Size = new Size(80, 21);
            Cage_label.TabIndex = 10;
            Cage_label.Text = "Cages: 99";
            // 
            // Bird_label
            // 
            Bird_label.AutoSize = true;
            Bird_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Bird_label.ForeColor = Color.White;
            Bird_label.Location = new Point(7, 27);
            Bird_label.Name = "Bird_label";
            Bird_label.Size = new Size(82, 21);
            Bird_label.TabIndex = 9;
            Bird_label.Text = "Brids: 999";
            // 
            // appIcon
            // 
            appIcon.Anchor = AnchorStyles.None;
            appIcon.Image = (Image)resources.GetObject("appIcon.Image");
            appIcon.Location = new Point(11, 9);
            appIcon.Name = "appIcon";
            appIcon.Size = new Size(60, 60);
            appIcon.TabIndex = 14;
            appIcon.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(210, 230, 200);
            contentPanel.Controls.Add(moreDetails1);
            contentPanel.Controls.Add(searchBird1);
            contentPanel.Controls.Add(addCage1);
            contentPanel.Controls.Add(addBird1);
            contentPanel.Controls.Add(homePage1);
            contentPanel.Location = new Point(0, 70);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1264, 611);
            contentPanel.TabIndex = 2;
            contentPanel.Visible = false;
            // 
            // moreDetails1
            // 
            moreDetails1.BackColor = Color.FromArgb(210, 230, 200);
            moreDetails1.Location = new Point(0, 1);
            moreDetails1.Name = "moreDetails1";
            moreDetails1.Size = new Size(1264, 611);
            moreDetails1.TabIndex = 6;
            moreDetails1.Visible = false;
            // 
            // searchBird1
            // 
            searchBird1.BackColor = Color.FromArgb(210, 230, 200);
            searchBird1.Location = new Point(0, 0);
            searchBird1.Name = "searchBird1";
            searchBird1.Size = new Size(1264, 611);
            searchBird1.TabIndex = 5;
            searchBird1.Visible = false;
            // 
            // addCage1
            // 
            addCage1.BackColor = Color.FromArgb(210, 230, 200);
            addCage1.Location = new Point(0, -1);
            addCage1.Name = "addCage1";
            addCage1.Size = new Size(1264, 611);
            addCage1.TabIndex = 4;
            addCage1.Visible = false;
            // 
            // addBird1
            // 
            addBird1.BackColor = Color.FromArgb(210, 230, 200);
            addBird1.Location = new Point(0, 0);
            addBird1.Name = "addBird1";
            addBird1.Size = new Size(1264, 611);
            addBird1.TabIndex = 3;
            addBird1.Visible = false;
            // 
            // homePage1
            // 
            homePage1.BackColor = Color.FromArgb(210, 230, 200);
            homePage1.Location = new Point(0, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(1264, 611);
            homePage1.TabIndex = 2;
            homePage1.Visible = false;
            // 
            // signUp1
            // 
            signUp1.BackgroundImage = (Image)resources.GetObject("signUp1.BackgroundImage");
            signUp1.Location = new Point(0, 0);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(1264, 683);
            signUp1.TabIndex = 1;
            signUp1.Visible = false;
            // 
            // logIn1
            // 
            logIn1.BackgroundImage = (Image)resources.GetObject("logIn1.BackgroundImage");
            logIn1.Location = new Point(0, 0);
            logIn1.Name = "logIn1";
            logIn1.Size = new Size(1264, 683);
            logIn1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1264, 681);
            Controls.Add(headlinePanel);
            Controls.Add(contentPanel);
            Controls.Add(signUp1);
            Controls.Add(logIn1);
            Name = "MainWindow";
            Text = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            headlinePanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            countersPanel.ResumeLayout(false);
            countersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appIcon).EndInit();
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel headlinePanel;
        public Panel contentPanel;
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
        public Button dashboardButton;
        private PictureBox appIcon;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel countersPanel;
    }
}
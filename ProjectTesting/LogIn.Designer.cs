namespace ProjectTesting
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            LogIn_label = new Label();
            UserName_label = new Label();
            Pasword_label = new Label();
            SignUp_button = new RJControls.RJButton();
            LogIn_button = new RJControls.RJButton();
            panel1 = new Panel();
            Password_textbox = new RJControls.RJTextBox();
            UserName_textbox = new RJControls.RJTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogIn_label
            // 
            LogIn_label.AutoSize = true;
            LogIn_label.BackColor = Color.Transparent;
            LogIn_label.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Underline, GraphicsUnit.Point);
            LogIn_label.Location = new Point(107, 28);
            LogIn_label.Name = "LogIn_label";
            LogIn_label.Size = new Size(206, 75);
            LogIn_label.TabIndex = 9;
            LogIn_label.Text = "Login";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.BackColor = Color.Transparent;
            UserName_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_label.Location = new Point(58, 127);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(124, 30);
            UserName_label.TabIndex = 2;
            UserName_label.Text = "User Name:";
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.BackColor = Color.Transparent;
            Pasword_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Pasword_label.Location = new Point(58, 211);
            Pasword_label.Name = "Pasword_label";
            Pasword_label.Size = new Size(108, 30);
            Pasword_label.TabIndex = 3;
            Pasword_label.Text = "Password:";
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = Color.FromArgb(145, 199, 136);
            SignUp_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            SignUp_button.BorderColor = Color.FromArgb(115, 165, 100);
            SignUp_button.BorderRadius = 10;
            SignUp_button.BorderSize = 3;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.FlatAppearance.BorderSize = 0;
            SignUp_button.FlatStyle = FlatStyle.Flat;
            SignUp_button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp_button.ForeColor = Color.Black;
            SignUp_button.Location = new Point(224, 396);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Padding = new Padding(0, 0, 0, 2);
            SignUp_button.Size = new Size(155, 55);
            SignUp_button.TabIndex = 4;
            SignUp_button.Text = "Sign Up";
            SignUp_button.TextColor = Color.Black;
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = Color.FromArgb(145, 199, 136);
            LogIn_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            LogIn_button.BorderColor = Color.FromArgb(115, 165, 100);
            LogIn_button.BorderRadius = 10;
            LogIn_button.BorderSize = 3;
            LogIn_button.Cursor = Cursors.Hand;
            LogIn_button.FlatAppearance.BorderSize = 0;
            LogIn_button.FlatStyle = FlatStyle.Flat;
            LogIn_button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn_button.ForeColor = Color.Black;
            LogIn_button.Location = new Point(38, 396);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Padding = new Padding(0, 0, 0, 2);
            LogIn_button.Size = new Size(155, 55);
            LogIn_button.TabIndex = 3;
            LogIn_button.Text = "Log In";
            LogIn_button.TextColor = Color.Black;
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 97, 135, 110);
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(LogIn_label);
            panel1.Controls.Add(UserName_textbox);
            panel1.Controls.Add(LogIn_button);
            panel1.Controls.Add(UserName_label);
            panel1.Controls.Add(Pasword_label);
            panel1.Controls.Add(SignUp_button);
            panel1.Location = new Point(125, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 480);
            panel1.TabIndex = 41;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = SystemColors.Window;
            Password_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            Password_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            Password_textbox.BorderRadius = 5;
            Password_textbox.BorderSize = 2;
            Password_textbox.Cursor = Cursors.IBeam;
            Password_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            Password_textbox.Location = new Point(58, 242);
            Password_textbox.Margin = new Padding(4);
            Password_textbox.Multiline = false;
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Padding = new Padding(10, 7, 10, 7);
            Password_textbox.PasswordChar = true;
            Password_textbox.PlaceholderColor = Color.DarkGray;
            Password_textbox.PlaceholderText = " password";
            Password_textbox.Size = new Size(300, 40);
            Password_textbox.TabIndex = 2;
            Password_textbox.Texts = "";
            Password_textbox.UnderlinedStyle = false;
            // 
            // UserName_textbox
            // 
            UserName_textbox.BackColor = SystemColors.Window;
            UserName_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            UserName_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            UserName_textbox.BorderRadius = 5;
            UserName_textbox.BorderSize = 2;
            UserName_textbox.Cursor = Cursors.IBeam;
            UserName_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            UserName_textbox.Location = new Point(58, 158);
            UserName_textbox.Margin = new Padding(4);
            UserName_textbox.Multiline = false;
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Padding = new Padding(10, 7, 10, 7);
            UserName_textbox.PasswordChar = false;
            UserName_textbox.PlaceholderColor = Color.DarkGray;
            UserName_textbox.PlaceholderText = " username";
            UserName_textbox.Size = new Size(300, 40);
            UserName_textbox.TabIndex = 1;
            UserName_textbox.Texts = "";
            UserName_textbox.UnderlinedStyle = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel1);
            Name = "LogIn";
            Size = new Size(1264, 683);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label UserName_label;
        private Label Pasword_label;
        private Label LogIn_label;
        private RJControls.RJButton SignUp_button;
        private RJControls.RJButton LogIn_button;
        private Panel panel1;
        private RJControls.RJTextBox Password_textbox;
        private RJControls.RJTextBox UserName_textbox;
    }
}

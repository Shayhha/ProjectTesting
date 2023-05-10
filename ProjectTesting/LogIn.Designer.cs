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
            panel1 = new Panel();
            Password_textbox = new TextBox();
            LogIn_button = new Button();
            SignUp_button = new Button();
            UserName_textbox = new TextBox();
            UserName_label = new Label();
            Pasword_label = new Label();
            LogIn_label = new Label();
            loginButton_4 = new RJControls.RJButton();
            loginButton_2 = new RJControls.RJButton();
            loginButton_3 = new RJControls.RJButton();
            loginButton_1 = new RJControls.RJButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(LogIn_button);
            panel1.Controls.Add(SignUp_button);
            panel1.Controls.Add(UserName_textbox);
            panel1.Controls.Add(UserName_label);
            panel1.Controls.Add(Pasword_label);
            panel1.Location = new Point(351, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 359);
            panel1.TabIndex = 10;
            // 
            // Password_textbox
            // 
            Password_textbox.BorderStyle = BorderStyle.FixedSingle;
            Password_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(219, 131);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '●';
            Password_textbox.Size = new Size(180, 33);
            Password_textbox.TabIndex = 4;
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = SystemColors.ActiveCaption;
            LogIn_button.Cursor = Cursors.Hand;
            LogIn_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn_button.Location = new Point(66, 221);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(162, 44);
            LogIn_button.TabIndex = 6;
            LogIn_button.Text = "Log In";
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = SystemColors.ActiveCaption;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUp_button.Location = new Point(279, 221);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(162, 44);
            SignUp_button.TabIndex = 7;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // UserName_textbox
            // 
            UserName_textbox.BorderStyle = BorderStyle.FixedSingle;
            UserName_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(219, 83);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 33);
            UserName_textbox.TabIndex = 1;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_label.Location = new Point(89, 85);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(124, 30);
            UserName_label.TabIndex = 2;
            UserName_label.Text = "User Name:";
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Pasword_label.Location = new Point(105, 134);
            Pasword_label.Name = "Pasword_label";
            Pasword_label.Size = new Size(108, 30);
            Pasword_label.TabIndex = 3;
            Pasword_label.Text = "Password:";
            // 
            // LogIn_label
            // 
            LogIn_label.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LogIn_label.Location = new Point(523, 2);
            LogIn_label.Name = "LogIn_label";
            LogIn_label.Size = new Size(180, 86);
            LogIn_label.TabIndex = 9;
            LogIn_label.Text = "Log In";
            // 
            // loginButton_4
            // 
            loginButton_4.BackColor = Color.FromArgb(97, 135, 110);
            loginButton_4.BackgroundColor = Color.FromArgb(97, 135, 110);
            loginButton_4.BorderColor = Color.FromArgb(82, 115, 77);
            loginButton_4.BorderRadius = 10;
            loginButton_4.BorderSize = 2;
            loginButton_4.FlatAppearance.BorderSize = 0;
            loginButton_4.FlatStyle = FlatStyle.Flat;
            loginButton_4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton_4.ForeColor = Color.White;
            loginButton_4.Location = new Point(185, 294);
            loginButton_4.Name = "loginButton_4";
            loginButton_4.Size = new Size(150, 40);
            loginButton_4.TabIndex = 36;
            loginButton_4.Text = "Sign Up";
            loginButton_4.TextColor = Color.White;
            loginButton_4.UseVisualStyleBackColor = false;
            // 
            // loginButton_2
            // 
            loginButton_2.BackColor = Color.FromArgb(145, 199, 136);
            loginButton_2.BackgroundColor = Color.FromArgb(145, 199, 136);
            loginButton_2.BorderColor = Color.FromArgb(115, 165, 100);
            loginButton_2.BorderRadius = 10;
            loginButton_2.BorderSize = 2;
            loginButton_2.FlatAppearance.BorderSize = 0;
            loginButton_2.FlatStyle = FlatStyle.Flat;
            loginButton_2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton_2.ForeColor = Color.Black;
            loginButton_2.Location = new Point(185, 225);
            loginButton_2.Name = "loginButton_2";
            loginButton_2.Size = new Size(150, 40);
            loginButton_2.TabIndex = 38;
            loginButton_2.Text = "Sign Up";
            loginButton_2.TextColor = Color.Black;
            loginButton_2.UseVisualStyleBackColor = false;
            // 
            // loginButton_3
            // 
            loginButton_3.BackColor = Color.FromArgb(97, 135, 110);
            loginButton_3.BackgroundColor = Color.FromArgb(97, 135, 110);
            loginButton_3.BorderColor = Color.FromArgb(82, 115, 77);
            loginButton_3.BorderRadius = 10;
            loginButton_3.BorderSize = 2;
            loginButton_3.FlatAppearance.BorderSize = 0;
            loginButton_3.FlatStyle = FlatStyle.Flat;
            loginButton_3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton_3.ForeColor = Color.White;
            loginButton_3.Location = new Point(19, 294);
            loginButton_3.Name = "loginButton_3";
            loginButton_3.Size = new Size(150, 40);
            loginButton_3.TabIndex = 35;
            loginButton_3.Text = "Log In";
            loginButton_3.TextColor = Color.White;
            loginButton_3.UseVisualStyleBackColor = false;
            // 
            // loginButton_1
            // 
            loginButton_1.BackColor = Color.FromArgb(145, 199, 136);
            loginButton_1.BackgroundColor = Color.FromArgb(145, 199, 136);
            loginButton_1.BorderColor = Color.FromArgb(115, 165, 100);
            loginButton_1.BorderRadius = 10;
            loginButton_1.BorderSize = 2;
            loginButton_1.FlatAppearance.BorderSize = 0;
            loginButton_1.FlatStyle = FlatStyle.Flat;
            loginButton_1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton_1.ForeColor = Color.Black;
            loginButton_1.Location = new Point(19, 225);
            loginButton_1.Name = "loginButton_1";
            loginButton_1.Size = new Size(150, 40);
            loginButton_1.TabIndex = 37;
            loginButton_1.Text = "Log In";
            loginButton_1.TextColor = Color.Black;
            loginButton_1.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(loginButton_4);
            Controls.Add(loginButton_2);
            Controls.Add(loginButton_3);
            Controls.Add(loginButton_1);
            Controls.Add(panel1);
            Controls.Add(LogIn_label);
            Name = "LogIn";
            Size = new Size(1264, 611);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Password_textbox;
        private Button LogIn_button;
        private Button SignUp_button;
        private TextBox UserName_textbox;
        private Label UserName_label;
        private Label Pasword_label;
        private Label LogIn_label;
        private RJControls.RJButton loginButton_4;
        private RJControls.RJButton loginButton_2;
        private RJControls.RJButton loginButton_3;
        private RJControls.RJButton loginButton_1;
    }
}

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
            Password_textbox = new TextBox();
            UserName_textbox = new TextBox();
            LogIn_button = new RJControls.RJButton();
            backSquare = new RJControls.RJButton();
            SuspendLayout();
            // 
            // LogIn_label
            // 
            LogIn_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            LogIn_label.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LogIn_label.Location = new Point(231, 164);
            LogIn_label.Name = "LogIn_label";
            LogIn_label.Size = new Size(180, 86);
            LogIn_label.TabIndex = 9;
            LogIn_label.Text = "Log In";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            UserName_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_label.Location = new Point(162, 307);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(124, 30);
            UserName_label.TabIndex = 2;
            UserName_label.Text = "User Name:";
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            Pasword_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Pasword_label.Location = new Point(178, 360);
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
            SignUp_button.BorderSize = 2;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.FlatAppearance.BorderSize = 0;
            SignUp_button.FlatStyle = FlatStyle.Flat;
            SignUp_button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp_button.ForeColor = Color.Black;
            SignUp_button.Location = new Point(328, 460);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(125, 45);
            SignUp_button.TabIndex = 38;
            SignUp_button.Text = "Sign Up";
            SignUp_button.TextColor = Color.Black;
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // Password_textbox
            // 
            Password_textbox.BorderStyle = BorderStyle.FixedSingle;
            Password_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(292, 357);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '●';
            Password_textbox.Size = new Size(180, 33);
            Password_textbox.TabIndex = 4;
            // 
            // UserName_textbox
            // 
            UserName_textbox.BorderStyle = BorderStyle.FixedSingle;
            UserName_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(292, 305);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 33);
            UserName_textbox.TabIndex = 1;
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = Color.FromArgb(145, 199, 136);
            LogIn_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            LogIn_button.BorderColor = Color.FromArgb(115, 165, 100);
            LogIn_button.BorderRadius = 10;
            LogIn_button.BorderSize = 2;
            LogIn_button.Cursor = Cursors.Hand;
            LogIn_button.FlatAppearance.BorderSize = 0;
            LogIn_button.FlatStyle = FlatStyle.Flat;
            LogIn_button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn_button.ForeColor = Color.Black;
            LogIn_button.Location = new Point(177, 460);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(125, 45);
            LogIn_button.TabIndex = 37;
            LogIn_button.Text = "Log In";
            LogIn_button.TextColor = Color.Black;
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // backSquare
            // 
            backSquare.BackColor = Color.FromArgb(230, 97, 135, 110);
            backSquare.BackgroundColor = Color.FromArgb(230, 97, 135, 110);
            backSquare.BorderColor = Color.FromArgb(230, 82, 115, 77);
            backSquare.BorderRadius = 35;
            backSquare.BorderSize = 3;
            backSquare.Enabled = false;
            backSquare.FlatAppearance.BorderSize = 0;
            backSquare.FlatStyle = FlatStyle.Flat;
            backSquare.ForeColor = Color.FromArgb(82, 115, 77);
            backSquare.Location = new Point(125, 125);
            backSquare.Name = "backSquare";
            backSquare.Size = new Size(375, 450);
            backSquare.TabIndex = 40;
            backSquare.TextColor = Color.FromArgb(82, 115, 77);
            backSquare.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(LogIn_label);
            Controls.Add(UserName_label);
            Controls.Add(Pasword_label);
            Controls.Add(SignUp_button);
            Controls.Add(Password_textbox);
            Controls.Add(UserName_textbox);
            Controls.Add(LogIn_button);
            Controls.Add(backSquare);
            Name = "LogIn";
            Size = new Size(1264, 683);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Password_textbox;
        private TextBox UserName_textbox;
        private Label UserName_label;
        private Label Pasword_label;
        private Label LogIn_label;
        private RJControls.RJButton SignUp_button;
        private RJControls.RJButton LogIn_button;
        private RJControls.RJButton backSquare;
    }
}

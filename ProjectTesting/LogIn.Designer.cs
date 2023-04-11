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
            panel1.Location = new Point(343, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 306);
            panel1.TabIndex = 10;
            // 
            // Password_textbox
            // 
            Password_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(174, 89);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '*';
            Password_textbox.Size = new Size(180, 27);
            Password_textbox.TabIndex = 4;
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = SystemColors.ActiveCaption;
            LogIn_button.Cursor = Cursors.Hand;
            LogIn_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn_button.Location = new Point(96, 185);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(162, 44);
            LogIn_button.TabIndex = 0;
            LogIn_button.Text = "Log In";
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = SystemColors.ActiveCaption;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUp_button.Location = new Point(335, 185);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(162, 44);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // UserName_textbox
            // 
            UserName_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(174, 42);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 27);
            UserName_textbox.TabIndex = 1;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_label.Location = new Point(31, 33);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(137, 32);
            UserName_label.TabIndex = 2;
            UserName_label.Text = "User Name:";
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Pasword_label.Location = new Point(40, 80);
            Pasword_label.Name = "Pasword_label";
            Pasword_label.Size = new Size(116, 32);
            Pasword_label.TabIndex = 3;
            Pasword_label.Text = "Password:";
            // 
            // LogIn_label
            // 
            LogIn_label.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LogIn_label.Location = new Point(550, 54);
            LogIn_label.Name = "LogIn_label";
            LogIn_label.Size = new Size(204, 86);
            LogIn_label.TabIndex = 9;
            LogIn_label.Text = "Log In";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
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
    }
}

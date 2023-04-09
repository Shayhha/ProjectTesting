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
            LogIn_button = new Button();
            UserName_textbox = new TextBox();
            label1 = new Label();
            UserName_label = new Label();
            Pasword_label = new Label();
            Password_textbox = new TextBox();
            SignIn_label = new Label();
            SignUp_button = new Button();
            SignUp1 = new SignUp();
            panel1 = new Panel();
            panel1.SuspendLayout();
            birdProfile1 = new BirdProfile();
            SuspendLayout();
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = SystemColors.ActiveCaption;
            LogIn_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn_button.Location = new Point(96, 185);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(162, 44);
            LogIn_button.TabIndex = 0;
            LogIn_button.Text = "Log In";
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // UserName_textbox
            // 
            UserName_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(174, 42);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 27);
            UserName_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
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
            // Password_textbox
            // 
            Password_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(174, 89);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Size = new Size(180, 27);
            Password_textbox.TabIndex = 4;
            // 
            // SignIn_label
            // 
            SignIn_label.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            SignIn_label.Location = new Point(560, 26);
            SignIn_label.Name = "SignIn_label";
            SignIn_label.Size = new Size(204, 86);
            SignIn_label.TabIndex = 5;
            SignIn_label.Text = "Sign In";
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = SystemColors.ActiveCaption;
            SignUp_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUp_button.Location = new Point(335, 185);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(162, 44);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // SignUp1
            // 
            SignUp1.BackColor = Color.LightCyan;
            SignUp1.Location = new Point(0, -33);
            SignUp1.Name = "SignUp1";
            SignUp1.Size = new Size(1280, 720);
            SignUp1.TabIndex = 7;
            SignUp1.Visible = false;
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
            panel1.Location = new Point(348, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 306);
            panel1.TabIndex = 8;
            // 
            // birdProfile1
            // 
            birdProfile1.Location = new Point(-11, 0);
            birdProfile1.Name = "birdProfile1";
            birdProfile1.Size = new Size(1280, 720);
            birdProfile1.TabIndex = 9;
            birdProfile1.Visible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1264, 681);
            Controls.Add(birdProfile1);
            Controls.Add(SignUp1);
            Controls.Add(panel1);
            Controls.Add(SignIn_label);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "MainWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LogIn_button;
        private TextBox UserName_textbox;
        private Label label1;
        private Label UserName_label;
        private Label Pasword_label;
        private TextBox Password_textbox;
        private Label SignIn_label;
        private Button SignUp_button;
        private SignUp SignUp1;
        private Panel panel1;
        private BirdProfile birdProfile1;
    }
}
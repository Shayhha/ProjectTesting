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
            textBox1 = new TextBox();
            SignIn_label = new Label();
            SignUp_button = new Button();
            SuspendLayout();
            // 
            // LogIn_button
            // 
            LogIn_button.BackColor = SystemColors.ActiveCaption;
            LogIn_button.Location = new Point(331, 284);
            LogIn_button.Name = "LogIn_button";
            LogIn_button.Size = new Size(162, 44);
            LogIn_button.TabIndex = 0;
            LogIn_button.Text = "Log In";
            LogIn_button.UseVisualStyleBackColor = false;
            LogIn_button.Click += LogIn_button_Click;
            // 
            // UserName_textbox
            // 
            UserName_textbox.Location = new Point(313, 203);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 23);
            UserName_textbox.TabIndex = 1;
            UserName_textbox.TextChanged += textBox_TextChanged;
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
            UserName_label.Location = new Point(239, 206);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(68, 15);
            UserName_label.TabIndex = 2;
            UserName_label.Text = "User Name:";
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.Location = new Point(526, 203);
            Pasword_label.Name = "Pasword_label";
            Pasword_label.Size = new Size(60, 15);
            Pasword_label.TabIndex = 3;
            Pasword_label.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(592, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 4;
            // 
            // SignIn_label
            // 
            SignIn_label.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            SignIn_label.Location = new Point(469, 66);
            SignIn_label.Name = "SignIn_label";
            SignIn_label.Size = new Size(240, 54);
            SignIn_label.TabIndex = 5;
            SignIn_label.Text = "Sign In";
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = SystemColors.ActiveCaption;
            SignUp_button.Location = new Point(564, 284);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(162, 44);
            SignUp_button.TabIndex = 6;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 536);
            Controls.Add(SignUp_button);
            Controls.Add(SignIn_label);
            Controls.Add(textBox1);
            Controls.Add(Pasword_label);
            Controls.Add(UserName_label);
            Controls.Add(label1);
            Controls.Add(UserName_textbox);
            Controls.Add(LogIn_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIn_button;
        private TextBox UserName_textbox;
        private Label label1;
        private Label UserName_label;
        private Label Pasword_label;
        private TextBox textBox1;
        private Label SignIn_label;
        private Button SignUp_button;
    }
}
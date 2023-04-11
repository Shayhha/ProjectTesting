namespace ProjectTesting
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            SignUp_button = new Button();
            bindingSource1 = new BindingSource(components);
            Password_textbox = new TextBox();
            Password_label = new Label();
            UserName_label = new Label();
            UserName_textbox = new TextBox();
            SignUp_label = new Label();
            panel1 = new Panel();
            Question_pictureBox = new PictureBox();
            Cancel_button = new Button();
            ID_textbox = new TextBox();
            ID_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // SignUp_button
            // 
            SignUp_button.BackColor = SystemColors.ActiveCaption;
            SignUp_button.Cursor = Cursors.Hand;
            SignUp_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignUp_button.Location = new Point(98, 253);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(168, 39);
            SignUp_button.TabIndex = 0;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = SystemColors.ButtonFace;
            Password_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(194, 172);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PlaceholderText = "Between 8 - 10 characters";
            Password_textbox.Size = new Size(180, 27);
            Password_textbox.TabIndex = 8;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Password_label.Location = new Point(61, 167);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(116, 32);
            Password_label.TabIndex = 7;
            Password_label.Text = "Password:";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_label.Location = new Point(49, 60);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(137, 32);
            UserName_label.TabIndex = 6;
            UserName_label.Text = "User Name:";
            // 
            // UserName_textbox
            // 
            UserName_textbox.BackColor = SystemColors.ButtonFace;
            UserName_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(194, 65);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.PlaceholderText = "Between 6 - 8 characters";
            UserName_textbox.Size = new Size(180, 27);
            UserName_textbox.TabIndex = 5;
            // 
            // SignUp_label
            // 
            SignUp_label.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            SignUp_label.Location = new Point(203, 52);
            SignUp_label.Name = "SignUp_label";
            SignUp_label.Size = new Size(891, 128);
            SignUp_label.TabIndex = 19;
            SignUp_label.Text = "Welcome New User, Sign Up Now!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(Question_pictureBox);
            panel1.Controls.Add(Cancel_button);
            panel1.Controls.Add(ID_textbox);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(SignUp_button);
            panel1.Controls.Add(UserName_textbox);
            panel1.Controls.Add(UserName_label);
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(Password_label);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(355, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 312);
            panel1.TabIndex = 20;
            // 
            // Question_pictureBox
            // 
            Question_pictureBox.Cursor = Cursors.Help;
            Question_pictureBox.Image = (Image)resources.GetObject("Question_pictureBox.Image");
            Question_pictureBox.Location = new Point(511, 7);
            Question_pictureBox.Name = "Question_pictureBox";
            Question_pictureBox.Size = new Size(43, 45);
            Question_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Question_pictureBox.TabIndex = 24;
            Question_pictureBox.TabStop = false;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = SystemColors.ActiveCaption;
            Cancel_button.Cursor = Cursors.Hand;
            Cancel_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel_button.Location = new Point(314, 253);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(168, 39);
            Cancel_button.TabIndex = 23;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // ID_textbox
            // 
            ID_textbox.BackColor = SystemColors.ButtonFace;
            ID_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ID_textbox.Location = new Point(194, 117);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.PlaceholderText = "6 digit number";
            ID_textbox.Size = new Size(180, 27);
            ID_textbox.TabIndex = 21;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ID_label.Location = new Point(98, 112);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(42, 32);
            ID_label.TabIndex = 22;
            ID_label.Text = "ID:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(panel1);
            Controls.Add(SignUp_label);
            Name = "SignUp";
            Size = new Size(1264, 611);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SignUp_button;
        private BindingSource bindingSource1;
        private TextBox Password_textbox;
        private Label Password_label;
        private Label UserName_label;
        private TextBox UserName_textbox;
        private Label SignUp_label;
        private Panel panel1;
        private TextBox ID_textbox;
        private Label ID_label;
        private Button Cancel_button;
        private PictureBox Question_pictureBox;
    }
}

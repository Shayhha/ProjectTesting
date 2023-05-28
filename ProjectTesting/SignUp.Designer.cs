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
            bindingSource1 = new BindingSource(components);
            Password_label = new Label();
            UserName_label = new Label();
            SignUp_label = new Label();
            Question_pictureBox = new PictureBox();
            ID_label = new Label();
            SignUp_button = new RJControls.RJButton();
            Cancel_button = new RJControls.RJButton();
            label1 = new Label();
            ID_textbox = new RJControls.RJTextBox();
            UserName_textbox = new RJControls.RJTextBox();
            panel1 = new Panel();
            Password_textbox = new RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.BackColor = Color.Transparent;
            Password_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Password_label.Location = new Point(66, 281);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(139, 37);
            Password_label.TabIndex = 21;
            Password_label.Text = "Password:";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.BackColor = Color.Transparent;
            UserName_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_label.Location = new Point(66, 169);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(159, 37);
            UserName_label.TabIndex = 6;
            UserName_label.Text = "User Name:";
            // 
            // SignUp_label
            // 
            SignUp_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SignUp_label.BackColor = Color.Transparent;
            SignUp_label.Font = new Font("Arial Rounded MT Bold", 33.75F, FontStyle.Underline, GraphicsUnit.Point);
            SignUp_label.ForeColor = Color.WhiteSmoke;
            SignUp_label.Location = new Point(615, 119);
            SignUp_label.Name = "SignUp_label";
            SignUp_label.Size = new Size(819, 172);
            SignUp_label.TabIndex = 19;
            SignUp_label.Text = "Welcome New User Sign Up Now!";
            SignUp_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Question_pictureBox
            // 
            Question_pictureBox.BackColor = Color.Transparent;
            Question_pictureBox.Cursor = Cursors.Help;
            Question_pictureBox.Image = (Image)resources.GetObject("Question_pictureBox.Image");
            Question_pictureBox.Location = new Point(417, 15);
            Question_pictureBox.Margin = new Padding(3, 4, 3, 4);
            Question_pictureBox.Name = "Question_pictureBox";
            Question_pictureBox.Size = new Size(46, 53);
            Question_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Question_pictureBox.TabIndex = 24;
            Question_pictureBox.TabStop = false;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.BackColor = Color.Transparent;
            ID_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ID_label.Location = new Point(66, 392);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(51, 37);
            ID_label.TabIndex = 22;
            ID_label.Text = "ID:";
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
            SignUp_button.Location = new Point(43, 528);
            SignUp_button.Margin = new Padding(3, 4, 3, 4);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Padding = new Padding(0, 0, 0, 3);
            SignUp_button.Size = new Size(177, 73);
            SignUp_button.TabIndex = 4;
            SignUp_button.Text = "Sign Up";
            SignUp_button.TextColor = Color.Black;
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_Button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.FromArgb(145, 199, 136);
            Cancel_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            Cancel_button.BorderColor = Color.FromArgb(115, 165, 100);
            Cancel_button.BorderRadius = 10;
            Cancel_button.BorderSize = 3;
            Cancel_button.Cursor = Cursors.Hand;
            Cancel_button.FlatAppearance.BorderSize = 0;
            Cancel_button.FlatStyle = FlatStyle.Flat;
            Cancel_button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_button.ForeColor = Color.Black;
            Cancel_button.Location = new Point(256, 528);
            Cancel_button.Margin = new Padding(3, 4, 3, 4);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Padding = new Padding(0, 0, 0, 3);
            Cancel_button.Size = new Size(177, 73);
            Cancel_button.TabIndex = 5;
            Cancel_button.Text = "Cancel";
            Cancel_button.TextColor = Color.Black;
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_Button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(81, 37);
            label1.Name = "label1";
            label1.Size = new Size(344, 93);
            label1.TabIndex = 44;
            label1.Text = "Sign Up";
            // 
            // ID_textbox
            // 
            ID_textbox.BackColor = SystemColors.Window;
            ID_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            ID_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            ID_textbox.BorderRadius = 5;
            ID_textbox.BorderSize = 2;
            ID_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ID_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            ID_textbox.Location = new Point(66, 433);
            ID_textbox.Margin = new Padding(5);
            ID_textbox.Multiline = false;
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Padding = new Padding(11, 9, 11, 9);
            ID_textbox.PasswordChar = false;
            ID_textbox.PlaceholderColor = Color.DarkGray;
            ID_textbox.PlaceholderText = "9 digit number";
            ID_textbox.Size = new Size(343, 51);
            ID_textbox.TabIndex = 3;
            ID_textbox.Texts = "";
            ID_textbox.UnderlinedStyle = false;
            // 
            // UserName_textbox
            // 
            UserName_textbox.BackColor = SystemColors.Window;
            UserName_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            UserName_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            UserName_textbox.BorderRadius = 5;
            UserName_textbox.BorderSize = 2;
            UserName_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            UserName_textbox.Location = new Point(66, 212);
            UserName_textbox.Margin = new Padding(5);
            UserName_textbox.Multiline = false;
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Padding = new Padding(11, 9, 11, 9);
            UserName_textbox.PasswordChar = false;
            UserName_textbox.PlaceholderColor = Color.DarkGray;
            UserName_textbox.PlaceholderText = "Between 6 - 8 characters";
            UserName_textbox.Size = new Size(343, 51);
            UserName_textbox.TabIndex = 1;
            UserName_textbox.Texts = "";
            UserName_textbox.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 97, 135, 110);
            panel1.Controls.Add(Question_pictureBox);
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(Cancel_button);
            panel1.Controls.Add(SignUp_button);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserName_label);
            panel1.Controls.Add(Password_label);
            panel1.Controls.Add(ID_textbox);
            panel1.Controls.Add(UserName_textbox);
            panel1.Location = new Point(143, 127);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 640);
            panel1.TabIndex = 45;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = SystemColors.Window;
            Password_textbox.BorderColor = Color.FromArgb(145, 199, 136);
            Password_textbox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            Password_textbox.BorderRadius = 5;
            Password_textbox.BorderSize = 2;
            Password_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.ForeColor = Color.FromArgb(64, 64, 64);
            Password_textbox.Location = new Point(66, 323);
            Password_textbox.Margin = new Padding(5);
            Password_textbox.Multiline = false;
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Padding = new Padding(11, 9, 11, 9);
            Password_textbox.PasswordChar = false;
            Password_textbox.PlaceholderColor = Color.DarkGray;
            Password_textbox.PlaceholderText = "Between 8 - 10 characters";
            Password_textbox.Size = new Size(343, 51);
            Password_textbox.TabIndex = 2;
            Password_textbox.Texts = "";
            Password_textbox.UnderlinedStyle = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel1);
            Controls.Add(SignUp_label);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            Size = new Size(1445, 911);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private Label Password_label;
        private Label UserName_label;
        private Label SignUp_label;
        private Label ID_label;
        private PictureBox Question_pictureBox;
        private RJControls.RJButton SignUp_button;
        private RJControls.RJButton Cancel_button;
        private Label label1;
        private RJControls.RJTextBox ID_textbox;
        private RJControls.RJTextBox UserName_textbox;
        private Panel panel1;
        private RJControls.RJTextBox Password_textbox;
    }
}

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
            Password_textbox = new TextBox();
            Password_label = new Label();
            UserName_label = new Label();
            UserName_textbox = new TextBox();
            SignUp_label = new Label();
            Question_pictureBox = new PictureBox();
            ID_textbox = new TextBox();
            ID_label = new Label();
            backSquare = new RJControls.RJButton();
            SignUp_button = new RJControls.RJButton();
            Cancel_button = new RJControls.RJButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = SystemColors.ButtonFace;
            Password_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_textbox.Location = new Point(265, 357);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PlaceholderText = "Between 8 - 10 characters";
            Password_textbox.Size = new Size(250, 33);
            Password_textbox.TabIndex = 7;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            Password_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Password_label.Location = new Point(153, 358);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(108, 30);
            Password_label.TabIndex = 21;
            Password_label.Text = "Password:";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            UserName_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_label.Location = new Point(137, 252);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(124, 30);
            UserName_label.TabIndex = 6;
            UserName_label.Text = "User Name:";
            // 
            // UserName_textbox
            // 
            UserName_textbox.BackColor = SystemColors.ButtonFace;
            UserName_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_textbox.Location = new Point(266, 250);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.PlaceholderText = "Between 6 - 8 characters";
            UserName_textbox.Size = new Size(250, 33);
            UserName_textbox.TabIndex = 5;
            // 
            // SignUp_label
            // 
            SignUp_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SignUp_label.BackColor = Color.Transparent;
            SignUp_label.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            SignUp_label.ForeColor = Color.WhiteSmoke;
            SignUp_label.Location = new Point(327, 36);
            SignUp_label.Name = "SignUp_label";
            SignUp_label.Size = new Size(645, 52);
            SignUp_label.TabIndex = 19;
            SignUp_label.Text = "Welcome New User, Sign Up Now!";
            // 
            // Question_pictureBox
            // 
            Question_pictureBox.BackColor = Color.FromArgb(230, 97, 135, 110);
            Question_pictureBox.Cursor = Cursors.Help;
            Question_pictureBox.Image = (Image)resources.GetObject("Question_pictureBox.Image");
            Question_pictureBox.Location = new Point(484, 140);
            Question_pictureBox.Name = "Question_pictureBox";
            Question_pictureBox.Size = new Size(40, 40);
            Question_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Question_pictureBox.TabIndex = 24;
            Question_pictureBox.TabStop = false;
            // 
            // ID_textbox
            // 
            ID_textbox.BackColor = SystemColors.ButtonFace;
            ID_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ID_textbox.Location = new Point(265, 302);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.PlaceholderText = "6 digit number";
            ID_textbox.Size = new Size(250, 33);
            ID_textbox.TabIndex = 6;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.BackColor = Color.FromArgb(230, 97, 135, 110);
            ID_label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ID_label.Location = new Point(222, 303);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(39, 30);
            ID_label.TabIndex = 22;
            ID_label.Text = "ID:";
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
            backSquare.Size = new Size(410, 450);
            backSquare.TabIndex = 41;
            backSquare.TextColor = Color.FromArgb(82, 115, 77);
            backSquare.UseVisualStyleBackColor = false;
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
            SignUp_button.Location = new Point(186, 461);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(125, 45);
            SignUp_button.TabIndex = 43;
            SignUp_button.Text = "Sign Up";
            SignUp_button.TextColor = Color.Black;
            SignUp_button.UseVisualStyleBackColor = false;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.FromArgb(145, 199, 136);
            Cancel_button.BackgroundColor = Color.FromArgb(145, 199, 136);
            Cancel_button.BorderColor = Color.FromArgb(115, 165, 100);
            Cancel_button.BorderRadius = 10;
            Cancel_button.BorderSize = 2;
            Cancel_button.Cursor = Cursors.Hand;
            Cancel_button.FlatAppearance.BorderSize = 0;
            Cancel_button.FlatStyle = FlatStyle.Flat;
            Cancel_button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_button.ForeColor = Color.Black;
            Cancel_button.Location = new Point(347, 461);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(125, 45);
            Cancel_button.TabIndex = 42;
            Cancel_button.Text = "Cancel";
            Cancel_button.TextColor = Color.Black;
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(230, 97, 135, 110);
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(231, 144);
            label1.Name = "label1";
            label1.Size = new Size(224, 82);
            label1.TabIndex = 44;
            label1.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label1);
            Controls.Add(SignUp_button);
            Controls.Add(Cancel_button);
            Controls.Add(Question_pictureBox);
            Controls.Add(ID_textbox);
            Controls.Add(SignUp_label);
            Controls.Add(ID_label);
            Controls.Add(UserName_label);
            Controls.Add(Password_label);
            Controls.Add(UserName_textbox);
            Controls.Add(Password_textbox);
            Controls.Add(backSquare);
            Name = "SignUp";
            Size = new Size(1264, 683);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Question_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private TextBox Password_textbox;
        private Label Password_label;
        private Label UserName_label;
        private TextBox UserName_textbox;
        private Label SignUp_label;
        private TextBox ID_textbox;
        private Label ID_label;
        private PictureBox Question_pictureBox;
        private RJControls.RJButton backSquare;
        private RJControls.RJButton SignUp_button;
        private RJControls.RJButton Cancel_button;
        private Label label1;
    }
}

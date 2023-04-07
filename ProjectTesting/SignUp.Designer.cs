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
            SIgnUp_button = new Button();
            bindingSource1 = new BindingSource(components);
            Password_textbox = new TextBox();
            Pasword_label = new Label();
            UserName_label = new Label();
            UserName_textbox = new TextBox();
            SIgnUp_label = new Label();
            panel1 = new Panel();
            ID_textbox = new TextBox();
            ID_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SIgnUp_button
            // 
            SIgnUp_button.Location = new Point(748, 374);
            SIgnUp_button.Name = "SIgnUp_button";
            SIgnUp_button.Size = new Size(165, 36);
            SIgnUp_button.TabIndex = 0;
            SIgnUp_button.Text = "SIgn Up";
            SIgnUp_button.UseVisualStyleBackColor = true;
            SIgnUp_button.Click += button1_Click;
            // 
            // Password_textbox
            // 
            Password_textbox.Location = new Point(599, 26);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Size = new Size(182, 23);
            Password_textbox.TabIndex = 8;
            // 
            // Pasword_label
            // 
            Pasword_label.AutoSize = true;
            Pasword_label.Location = new Point(533, 29);
            Pasword_label.Name = "Pasword_label";
            Pasword_label.Size = new Size(60, 15);
            Pasword_label.TabIndex = 7;
            Pasword_label.Text = "Password:";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Location = new Point(5, 26);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(68, 15);
            UserName_label.TabIndex = 6;
            UserName_label.Text = "User Name:";
            // 
            // UserName_textbox
            // 
            UserName_textbox.Location = new Point(79, 23);
            UserName_textbox.Name = "UserName_textbox";
            UserName_textbox.Size = new Size(180, 23);
            UserName_textbox.TabIndex = 5;
            // 
            // SIgnUp_label
            // 
            SIgnUp_label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            SIgnUp_label.Location = new Point(138, 87);
            SIgnUp_label.Name = "SIgnUp_label";
            SIgnUp_label.Size = new Size(849, 128);
            SIgnUp_label.TabIndex = 19;
            SIgnUp_label.Text = "Welcome New User, SIgn Up Now!";
            // 
            // panel1
            // 
            panel1.Controls.Add(ID_textbox);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(UserName_textbox);
            panel1.Controls.Add(UserName_label);
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(Pasword_label);
            panel1.Location = new Point(129, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 104);
            panel1.TabIndex = 20;
            // 
            // ID_textbox
            // 
            ID_textbox.Location = new Point(321, 26);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Size = new Size(180, 23);
            ID_textbox.TabIndex = 21;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Location = new Point(294, 29);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(21, 15);
            ID_label.TabIndex = 22;
            ID_label.Text = "ID:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(SIgnUp_label);
            Controls.Add(SIgnUp_button);
            Name = "SignUp";
            Size = new Size(1089, 575);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SIgnUp_button;
        private BindingSource bindingSource1;
        private TextBox Password_textbox;
        private Label Pasword_label;
        private Label UserName_label;
        private TextBox UserName_textbox;
        private Label SIgnUp_label;
        private Panel panel1;
        private TextBox ID_textbox;
        private Label ID_label;
    }
}

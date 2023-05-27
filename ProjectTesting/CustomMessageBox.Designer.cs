namespace ProjectTesting
{
    partial class CustomMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            Message_label = new Label();
            OK_button = new Button();
            Error_picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Error_picture).BeginInit();
            SuspendLayout();
            // 
            // Message_label
            // 
            Message_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Message_label.Location = new Point(94, 24);
            Message_label.Name = "Message_label";
            Message_label.Size = new Size(433, 119);
            Message_label.TabIndex = 0;
            Message_label.Text = "Message";
            // 
            // OK_button
            // 
            OK_button.Cursor = Cursors.Hand;
            OK_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OK_button.Location = new Point(437, 154);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(90, 33);
            OK_button.TabIndex = 4;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += OK_Button_Click;
            // 
            // Error_picture
            // 
            Error_picture.Image = (Image)resources.GetObject("Error_picture.Image");
            Error_picture.Location = new Point(11, 24);
            Error_picture.Name = "Error_picture";
            Error_picture.Size = new Size(77, 53);
            Error_picture.SizeMode = PictureBoxSizeMode.Zoom;
            Error_picture.TabIndex = 2;
            Error_picture.TabStop = false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(539, 199);
            Controls.Add(OK_button);
            Controls.Add(Error_picture);
            Controls.Add(Message_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)Error_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Message_label;
        private Button OK_button;
        private PictureBox Error_picture;
    }
}
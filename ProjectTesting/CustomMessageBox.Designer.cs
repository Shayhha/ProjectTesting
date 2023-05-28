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
            Message_label.Location = new Point(107, 32);
            Message_label.Name = "Message_label";
            Message_label.Size = new Size(495, 159);
            Message_label.TabIndex = 0;
            Message_label.Text = "Message";
            // 
            // OK_button
            // 
            OK_button.Cursor = Cursors.Hand;
            OK_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OK_button.Location = new Point(521, 207);
            OK_button.Margin = new Padding(3, 4, 3, 4);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(103, 44);
            OK_button.TabIndex = 4;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += OK_Button_Click;
            // 
            // Error_picture
            // 
            Error_picture.Image = (Image)resources.GetObject("Error_picture.Image");
            Error_picture.Location = new Point(13, 32);
            Error_picture.Margin = new Padding(3, 4, 3, 4);
            Error_picture.Name = "Error_picture";
            Error_picture.Size = new Size(88, 71);
            Error_picture.SizeMode = PictureBoxSizeMode.Zoom;
            Error_picture.TabIndex = 2;
            Error_picture.TabStop = false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(639, 265);
            Controls.Add(OK_button);
            Controls.Add(Error_picture);
            Controls.Add(Message_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
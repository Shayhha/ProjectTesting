namespace ProjectTesting
{
    partial class AddCage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            heightBox = new RJControls.RJTextBox();
            label1 = new Label();
            widthBox = new RJControls.RJTextBox();
            label8 = new Label();
            lengthBox = new RJControls.RJTextBox();
            label2 = new Label();
            idBox = new RJControls.RJTextBox();
            label3 = new Label();
            Welcome_label = new Label();
            addButton = new RJControls.RJButton();
            cancelButton = new RJControls.RJButton();
            panel2 = new Panel();
            panel3 = new Panel();
            materialBox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(97, 135, 110);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(642, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(118, 11);
            label9.Name = "label9";
            label9.Size = new Size(230, 50);
            label9.TabIndex = 1;
            label9.Text = "Add a Cage:";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(heightBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(widthBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lengthBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(41, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 276);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(2, 223);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 18;
            label7.Text = "Material:";
            // 
            // heightBox
            // 
            heightBox.BackColor = SystemColors.Window;
            heightBox.BorderColor = Color.FromArgb(145, 199, 136);
            heightBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            heightBox.BorderRadius = 5;
            heightBox.BorderSize = 2;
            heightBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heightBox.ForeColor = Color.FromArgb(64, 64, 64);
            heightBox.Location = new Point(91, 169);
            heightBox.Margin = new Padding(4);
            heightBox.Multiline = false;
            heightBox.Name = "heightBox";
            heightBox.Padding = new Padding(10, 7, 10, 7);
            heightBox.PasswordChar = false;
            heightBox.PlaceholderColor = Color.DarkGray;
            heightBox.PlaceholderText = "";
            heightBox.Size = new Size(250, 40);
            heightBox.TabIndex = 12;
            heightBox.Texts = "";
            heightBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 14;
            label1.Text = "Id:";
            // 
            // widthBox
            // 
            widthBox.BackColor = SystemColors.Window;
            widthBox.BorderColor = Color.FromArgb(145, 199, 136);
            widthBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            widthBox.BorderRadius = 5;
            widthBox.BorderSize = 2;
            widthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            widthBox.ForeColor = Color.FromArgb(64, 64, 64);
            widthBox.Location = new Point(91, 121);
            widthBox.Margin = new Padding(4);
            widthBox.Multiline = false;
            widthBox.Name = "widthBox";
            widthBox.Padding = new Padding(10, 7, 10, 7);
            widthBox.PasswordChar = false;
            widthBox.PlaceholderColor = Color.DarkGray;
            widthBox.PlaceholderText = "";
            widthBox.Size = new Size(250, 40);
            widthBox.TabIndex = 11;
            widthBox.Texts = "";
            widthBox.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 178);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 17;
            label8.Text = "Height:";
            // 
            // lengthBox
            // 
            lengthBox.BackColor = SystemColors.Window;
            lengthBox.BorderColor = Color.FromArgb(145, 199, 136);
            lengthBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            lengthBox.BorderRadius = 5;
            lengthBox.BorderSize = 2;
            lengthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lengthBox.ForeColor = Color.FromArgb(64, 64, 64);
            lengthBox.Location = new Point(91, 71);
            lengthBox.Margin = new Padding(4);
            lengthBox.Multiline = false;
            lengthBox.Name = "lengthBox";
            lengthBox.Padding = new Padding(10, 7, 10, 7);
            lengthBox.PasswordChar = false;
            lengthBox.PlaceholderColor = Color.DarkGray;
            lengthBox.PlaceholderText = "";
            lengthBox.Size = new Size(250, 40);
            lengthBox.TabIndex = 10;
            lengthBox.Texts = "";
            lengthBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 15;
            label2.Text = "Length:";
            // 
            // idBox
            // 
            idBox.BackColor = SystemColors.Window;
            idBox.BorderColor = Color.FromArgb(145, 199, 136);
            idBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            idBox.BorderRadius = 5;
            idBox.BorderSize = 2;
            idBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.ForeColor = Color.FromArgb(64, 64, 64);
            idBox.Location = new Point(91, 20);
            idBox.Margin = new Padding(4);
            idBox.Multiline = false;
            idBox.Name = "idBox";
            idBox.Padding = new Padding(10, 7, 10, 7);
            idBox.PasswordChar = false;
            idBox.PlaceholderColor = Color.DarkGray;
            idBox.PlaceholderText = "";
            idBox.Size = new Size(250, 40);
            idBox.TabIndex = 9;
            idBox.Texts = "";
            idBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 16;
            label3.Text = "Width:";
            // 
            // Welcome_label
            // 
            Welcome_label.Font = new Font("Comic Sans MS", 24F, FontStyle.Underline, GraphicsUnit.Point);
            Welcome_label.Location = new Point(276, 32);
            Welcome_label.Name = "Welcome_label";
            Welcome_label.Size = new Size(660, 64);
            Welcome_label.TabIndex = 5;
            Welcome_label.Text = "Welcome new user! please add a new cage";
            Welcome_label.Visible = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(145, 199, 136);
            addButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            addButton.BorderColor = Color.FromArgb(115, 165, 100);
            addButton.BorderRadius = 10;
            addButton.BorderSize = 2;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(77, 358);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 45);
            addButton.TabIndex = 14;
            addButton.Text = "Add";
            addButton.TextColor = Color.Black;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(145, 199, 136);
            cancelButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            cancelButton.BorderColor = Color.FromArgb(115, 165, 100);
            cancelButton.BorderRadius = 10;
            cancelButton.BorderSize = 2;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(246, 358);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(125, 45);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.Black;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(97, 135, 110);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(cancelButton);
            panel2.Location = new Point(381, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 424);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(82, 115, 77);
            panel3.Location = new Point(389, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 424);
            panel3.TabIndex = 9;
            // 
            // materialBox
            // 
            materialBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialBox.FormattingEnabled = true;
            materialBox.Location = new Point(91, 219);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(250, 33);
            materialBox.TabIndex = 10;
            // 
            // AddCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(Welcome_label);
            Name = "AddCage";
            Size = new Size(1264, 611);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label Welcome_label;
        public RJControls.RJButton addButton;
        private RJControls.RJButton cancelButton;
        public Panel panel2;
        private RJControls.RJTextBox heightBox;
        private RJControls.RJTextBox widthBox;
        private RJControls.RJTextBox lengthBox;
        private RJControls.RJTextBox idBox;
        public Panel panel3;
        private ComboBox materialBox;
    }
}

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
            materialBox = new ComboBox();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(97, 135, 110);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(734, 151);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(111, 15);
            label9.Name = "label9";
            label9.Size = new Size(323, 58);
            label9.TabIndex = 1;
            label9.Text = "Add a Cage:";
            // 
            // panel1
            // 
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(materialBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(heightBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(widthBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lengthBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(28, 88);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 349);
            panel1.TabIndex = 0;
            // 
            // materialBox
            // 
            materialBox.Cursor = Cursors.Hand;
            materialBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialBox.FormattingEnabled = true;
            materialBox.Location = new Point(127, 292);
            materialBox.Margin = new Padding(3, 4, 3, 4);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(285, 40);
            materialBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 293);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
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
            heightBox.Cursor = Cursors.IBeam;
            heightBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heightBox.ForeColor = Color.FromArgb(64, 64, 64);
            heightBox.Location = new Point(127, 225);
            heightBox.Margin = new Padding(5);
            heightBox.Multiline = false;
            heightBox.Name = "heightBox";
            heightBox.Padding = new Padding(11, 9, 11, 9);
            heightBox.PasswordChar = false;
            heightBox.PlaceholderColor = Color.DarkGray;
            heightBox.PlaceholderText = "";
            heightBox.Size = new Size(286, 51);
            heightBox.TabIndex = 12;
            heightBox.Texts = "";
            heightBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 37);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
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
            widthBox.Cursor = Cursors.IBeam;
            widthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            widthBox.ForeColor = Color.FromArgb(64, 64, 64);
            widthBox.Location = new Point(127, 161);
            widthBox.Margin = new Padding(5);
            widthBox.Multiline = false;
            widthBox.Name = "widthBox";
            widthBox.Padding = new Padding(11, 9, 11, 9);
            widthBox.PasswordChar = false;
            widthBox.PlaceholderColor = Color.DarkGray;
            widthBox.PlaceholderText = "";
            widthBox.Size = new Size(286, 51);
            widthBox.TabIndex = 11;
            widthBox.Texts = "";
            widthBox.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(33, 234);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
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
            lengthBox.Cursor = Cursors.IBeam;
            lengthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lengthBox.ForeColor = Color.FromArgb(64, 64, 64);
            lengthBox.Location = new Point(127, 95);
            lengthBox.Margin = new Padding(5);
            lengthBox.Multiline = false;
            lengthBox.Name = "lengthBox";
            lengthBox.Padding = new Padding(11, 9, 11, 9);
            lengthBox.PasswordChar = false;
            lengthBox.PlaceholderColor = Color.DarkGray;
            lengthBox.PlaceholderText = "";
            lengthBox.Size = new Size(286, 51);
            lengthBox.TabIndex = 10;
            lengthBox.Texts = "";
            lengthBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
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
            idBox.Cursor = Cursors.IBeam;
            idBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.ForeColor = Color.FromArgb(64, 64, 64);
            idBox.Location = new Point(127, 27);
            idBox.Margin = new Padding(5);
            idBox.Multiline = false;
            idBox.Name = "idBox";
            idBox.Padding = new Padding(11, 9, 11, 9);
            idBox.PasswordChar = false;
            idBox.PlaceholderColor = Color.DarkGray;
            idBox.PlaceholderText = "";
            idBox.Size = new Size(286, 51);
            idBox.TabIndex = 9;
            idBox.Texts = "";
            idBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 171);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 16;
            label3.Text = "Width:";
            // 
            // Welcome_label
            // 
            Welcome_label.AutoSize = true;
            Welcome_label.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Underline, GraphicsUnit.Point);
            Welcome_label.Location = new Point(208, 49);
            Welcome_label.Name = "Welcome_label";
            Welcome_label.Size = new Size(1074, 58);
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
            addButton.BorderSize = 3;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(83, 464);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Padding = new Padding(0, 0, 0, 3);
            addButton.Size = new Size(160, 67);
            addButton.TabIndex = 14;
            addButton.Text = "Add";
            addButton.TextColor = Color.Black;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += add_Button_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(145, 199, 136);
            cancelButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            cancelButton.BorderColor = Color.FromArgb(115, 165, 100);
            cancelButton.BorderRadius = 10;
            cancelButton.BorderSize = 3;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(277, 464);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(0, 0, 0, 3);
            cancelButton.Size = new Size(160, 67);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.Black;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancel_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(97, 135, 110);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(cancelButton);
            panel2.Location = new Point(471, 89);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 565);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(82, 115, 77);
            panel3.Location = new Point(481, 78);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 565);
            panel3.TabIndex = 9;
            // 
            // AddCage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(Welcome_label);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCage";
            Size = new Size(1445, 815);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

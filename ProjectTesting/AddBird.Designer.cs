namespace ProjectTesting
{
    partial class AddBird
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
            panel1 = new Panel();
            subTypeBox = new ComboBox();
            momBox = new RJControls.RJTextBox();
            typeBox = new ComboBox();
            dateBox = new DateTimePicker();
            dadBox = new RJControls.RJTextBox();
            cageIdBox = new RJControls.RJTextBox();
            genderBox = new RJControls.RJTextBox();
            idBox = new RJControls.RJTextBox();
            label7 = new Label();
            label4 = new Label();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            AddBird_label = new Label();
            addButton = new RJControls.RJButton();
            cancelButton = new RJControls.RJButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(subTypeBox);
            panel1.Controls.Add(momBox);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(dateBox);
            panel1.Controls.Add(dadBox);
            panel1.Controls.Add(cageIdBox);
            panel1.Controls.Add(genderBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(21, 73);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 524);
            panel1.TabIndex = 0;
            // 
            // subTypeBox
            // 
            subTypeBox.Cursor = Cursors.Hand;
            subTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subTypeBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            subTypeBox.FormattingEnabled = true;
            subTypeBox.Location = new Point(171, 144);
            subTypeBox.Margin = new Padding(3, 4, 3, 4);
            subTypeBox.Name = "subTypeBox";
            subTypeBox.Size = new Size(285, 40);
            subTypeBox.TabIndex = 3;
            // 
            // momBox
            // 
            momBox.BackColor = SystemColors.Window;
            momBox.BorderColor = Color.FromArgb(145, 199, 136);
            momBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            momBox.BorderRadius = 5;
            momBox.BorderSize = 2;
            momBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            momBox.ForeColor = Color.FromArgb(64, 64, 64);
            momBox.Location = new Point(171, 451);
            momBox.Margin = new Padding(5, 5, 5, 5);
            momBox.Multiline = false;
            momBox.Name = "momBox";
            momBox.Padding = new Padding(11, 9, 11, 9);
            momBox.PasswordChar = false;
            momBox.PlaceholderColor = Color.DarkGray;
            momBox.PlaceholderText = "";
            momBox.Size = new Size(286, 51);
            momBox.TabIndex = 8;
            momBox.Texts = "";
            momBox.UnderlinedStyle = false;
            // 
            // typeBox
            // 
            typeBox.Cursor = Cursors.Hand;
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(171, 87);
            typeBox.Margin = new Padding(3, 4, 3, 4);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(285, 40);
            typeBox.TabIndex = 2;
            typeBox.SelectedIndexChanged += typeCombobox_ItemClicked;
            // 
            // dateBox
            // 
            dateBox.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateBox.CalendarMonthBackground = Color.WhiteSmoke;
            dateBox.Cursor = Cursors.Hand;
            dateBox.CustomFormat = "dd/MM/yyyy";
            dateBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(171, 200);
            dateBox.Margin = new Padding(3, 4, 3, 4);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(285, 39);
            dateBox.TabIndex = 4;
            // 
            // dadBox
            // 
            dadBox.BackColor = SystemColors.Window;
            dadBox.BorderColor = Color.FromArgb(145, 199, 136);
            dadBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            dadBox.BorderRadius = 5;
            dadBox.BorderSize = 2;
            dadBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dadBox.ForeColor = Color.FromArgb(64, 64, 64);
            dadBox.Location = new Point(171, 387);
            dadBox.Margin = new Padding(5, 5, 5, 5);
            dadBox.Multiline = false;
            dadBox.Name = "dadBox";
            dadBox.Padding = new Padding(11, 9, 11, 9);
            dadBox.PasswordChar = false;
            dadBox.PlaceholderColor = Color.DarkGray;
            dadBox.PlaceholderText = "";
            dadBox.Size = new Size(286, 51);
            dadBox.TabIndex = 7;
            dadBox.Texts = "";
            dadBox.UnderlinedStyle = false;
            // 
            // cageIdBox
            // 
            cageIdBox.BackColor = SystemColors.Window;
            cageIdBox.BorderColor = Color.FromArgb(145, 199, 136);
            cageIdBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            cageIdBox.BorderRadius = 5;
            cageIdBox.BorderSize = 2;
            cageIdBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cageIdBox.ForeColor = Color.FromArgb(64, 64, 64);
            cageIdBox.Location = new Point(171, 323);
            cageIdBox.Margin = new Padding(5, 5, 5, 5);
            cageIdBox.Multiline = false;
            cageIdBox.Name = "cageIdBox";
            cageIdBox.Padding = new Padding(11, 9, 11, 9);
            cageIdBox.PasswordChar = false;
            cageIdBox.PlaceholderColor = Color.DarkGray;
            cageIdBox.PlaceholderText = "";
            cageIdBox.Size = new Size(286, 51);
            cageIdBox.TabIndex = 6;
            cageIdBox.Texts = "";
            cageIdBox.UnderlinedStyle = false;
            // 
            // genderBox
            // 
            genderBox.BackColor = SystemColors.Window;
            genderBox.BorderColor = Color.FromArgb(145, 199, 136);
            genderBox.BorderFocusColor = Color.FromArgb(97, 135, 110);
            genderBox.BorderRadius = 5;
            genderBox.BorderSize = 2;
            genderBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.ForeColor = Color.FromArgb(64, 64, 64);
            genderBox.Location = new Point(171, 257);
            genderBox.Margin = new Padding(5, 5, 5, 5);
            genderBox.Multiline = false;
            genderBox.Name = "genderBox";
            genderBox.Padding = new Padding(11, 9, 11, 9);
            genderBox.PasswordChar = false;
            genderBox.PlaceholderColor = Color.DarkGray;
            genderBox.PlaceholderText = "";
            genderBox.Size = new Size(286, 51);
            genderBox.TabIndex = 5;
            genderBox.Texts = "";
            genderBox.UnderlinedStyle = false;
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
            idBox.Location = new Point(171, 21);
            idBox.Margin = new Padding(5, 5, 5, 5);
            idBox.Multiline = false;
            idBox.Name = "idBox";
            idBox.Padding = new Padding(11, 9, 11, 9);
            idBox.PasswordChar = false;
            idBox.PlaceholderColor = Color.DarkGray;
            idBox.PlaceholderText = "";
            idBox.Size = new Size(286, 51);
            idBox.TabIndex = 1;
            idBox.Texts = "";
            idBox.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(64, 266);
            label7.Name = "label7";
            label7.Size = new Size(112, 32);
            label7.TabIndex = 18;
            label7.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 460);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 21;
            label4.Text = "Mom's Id: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 32);
            label1.TabIndex = 14;
            label1.Text = "Id: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1, 200);
            label8.Name = "label8";
            label8.Size = new Size(175, 32);
            label8.TabIndex = 17;
            label8.Text = "Date of Birth: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(63, 332);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 19;
            label6.Text = "Cage Id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 90);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 15;
            label2.Text = "Type: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 146);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 16;
            label3.Text = "Sub-Type: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 396);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 20;
            label5.Text = "Dad's Id: ";
            // 
            // AddBird_label
            // 
            AddBird_label.AutoSize = true;
            AddBird_label.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Underline, GraphicsUnit.Point);
            AddBird_label.Location = new Point(118, 11);
            AddBird_label.Name = "AddBird_label";
            AddBird_label.Size = new Size(298, 58);
            AddBird_label.TabIndex = 1;
            AddBird_label.Text = "Add a Bird:";
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
            addButton.Location = new Point(82, 615);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Padding = new Padding(0, 0, 0, 3);
            addButton.Size = new Size(160, 67);
            addButton.TabIndex = 9;
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
            cancelButton.Location = new Point(272, 615);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(0, 0, 0, 3);
            cancelButton.Size = new Size(160, 67);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.Black;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancel_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(97, 135, 110);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(AddBird_label);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(435, 44);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 711);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(82, 115, 77);
            panel3.Location = new Point(445, 33);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 712);
            panel3.TabIndex = 5;
            // 
            // AddBird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBird";
            Size = new Size(1445, 815);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label4;
        private Label label1;
        private Label label8;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label5;
        public Label AddBird_label;
        private DateTimePicker dateBox;
        private RJControls.RJButton addButton;
        private RJControls.RJButton cancelButton;
        private RJControls.RJTextBox idBox;
        public RJControls.RJTextBox momBox;
        public RJControls.RJTextBox dadBox;
        public RJControls.RJTextBox cageIdBox;
        private RJControls.RJTextBox genderBox;
        private Panel panel2;
        private Panel panel3;
        private ComboBox subTypeBox;
        private ComboBox typeBox;
    }
}

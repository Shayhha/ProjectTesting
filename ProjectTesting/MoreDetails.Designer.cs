namespace ProjectTesting
{
    partial class MoreDetails
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
            dateLabel = new DateTimePicker();
            momIdLabel = new TextBox();
            dadIdLabel = new TextBox();
            cageIdLabel = new TextBox();
            genderLabel = new TextBox();
            subTypeLabel = new TextBox();
            typeLabel = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveButton = new Button();
            editButton = new Button();
            idLabel = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            nameLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            mainPic = new PictureBox();
            offspringList = new ListBox();
            addOffspringButton = new Button();
            offspringsPanel = new Panel();
            fledglingLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).BeginInit();
            offspringsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dateLabel);
            panel1.Controls.Add(momIdLabel);
            panel1.Controls.Add(dadIdLabel);
            panel1.Controls.Add(cageIdLabel);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(subTypeLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(215, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 223);
            panel1.TabIndex = 16;
            // 
            // dateLabel
            // 
            dateLabel.CustomFormat = "dd/MM/yyyy";
            dateLabel.Enabled = false;
            dateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Format = DateTimePickerFormat.Custom;
            dateLabel.Location = new Point(159, 87);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(111, 25);
            dateLabel.TabIndex = 28;
            // 
            // momIdLabel
            // 
            momIdLabel.BackColor = SystemColors.ControlLight;
            momIdLabel.BorderStyle = BorderStyle.None;
            momIdLabel.Enabled = false;
            momIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            momIdLabel.Location = new Point(159, 185);
            momIdLabel.Name = "momIdLabel";
            momIdLabel.PlaceholderText = "John";
            momIdLabel.ReadOnly = true;
            momIdLabel.Size = new Size(135, 26);
            momIdLabel.TabIndex = 35;
            // 
            // dadIdLabel
            // 
            dadIdLabel.BackColor = SystemColors.ControlLight;
            dadIdLabel.BorderStyle = BorderStyle.None;
            dadIdLabel.Enabled = false;
            dadIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dadIdLabel.Location = new Point(159, 160);
            dadIdLabel.Name = "dadIdLabel";
            dadIdLabel.PlaceholderText = "John";
            dadIdLabel.ReadOnly = true;
            dadIdLabel.Size = new Size(135, 26);
            dadIdLabel.TabIndex = 34;
            // 
            // cageIdLabel
            // 
            cageIdLabel.BackColor = SystemColors.ControlLight;
            cageIdLabel.BorderStyle = BorderStyle.None;
            cageIdLabel.Enabled = false;
            cageIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cageIdLabel.Location = new Point(159, 134);
            cageIdLabel.Name = "cageIdLabel";
            cageIdLabel.PlaceholderText = "John";
            cageIdLabel.ReadOnly = true;
            cageIdLabel.Size = new Size(135, 26);
            cageIdLabel.TabIndex = 33;
            // 
            // genderLabel
            // 
            genderLabel.BackColor = SystemColors.ControlLight;
            genderLabel.BorderStyle = BorderStyle.None;
            genderLabel.Enabled = false;
            genderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderLabel.Location = new Point(159, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.PlaceholderText = "John";
            genderLabel.ReadOnly = true;
            genderLabel.Size = new Size(111, 26);
            genderLabel.TabIndex = 32;
            // 
            // subTypeLabel
            // 
            subTypeLabel.BackColor = SystemColors.ControlLight;
            subTypeLabel.BorderStyle = BorderStyle.None;
            subTypeLabel.Enabled = false;
            subTypeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            subTypeLabel.Location = new Point(159, 60);
            subTypeLabel.Name = "subTypeLabel";
            subTypeLabel.PlaceholderText = "John";
            subTypeLabel.ReadOnly = true;
            subTypeLabel.Size = new Size(188, 26);
            subTypeLabel.TabIndex = 31;
            // 
            // typeLabel
            // 
            typeLabel.BackColor = SystemColors.ControlLight;
            typeLabel.BorderStyle = BorderStyle.None;
            typeLabel.Enabled = false;
            typeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.Location = new Point(159, 35);
            typeLabel.Name = "typeLabel";
            typeLabel.PlaceholderText = "John";
            typeLabel.ReadOnly = true;
            typeLabel.Size = new Size(188, 26);
            typeLabel.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(saveButton);
            flowLayoutPanel2.Controls.Add(editButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(300, 128);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(80, 95);
            flowLayoutPanel2.TabIndex = 30;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(3, 52);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(70, 40);
            saveButton.TabIndex = 29;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(3, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(70, 40);
            editButton.TabIndex = 28;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // idLabel
            // 
            idLabel.BackColor = SystemColors.ControlLight;
            idLabel.BorderStyle = BorderStyle.None;
            idLabel.Enabled = false;
            idLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(159, 9);
            idLabel.Name = "idLabel";
            idLabel.PlaceholderText = "John";
            idLabel.ReadOnly = true;
            idLabel.Size = new Size(188, 26);
            idLabel.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(nameLabel);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(14, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(142, 210);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(99, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(40, 25);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Id: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 7;
            label1.Text = "Type: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 50);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 8;
            label3.Text = "Sub-Type: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(50, 100);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 10;
            label7.Text = "Gender: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(50, 125);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 11;
            label6.Text = "Cage Id: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 150);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 12;
            label5.Text = "Dad's Id: ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 175);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 13;
            label4.Text = "Mom's Id: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(26, 3);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 23;
            label8.Text = "Offsprings: ";
            // 
            // mainPic
            // 
            mainPic.Location = new Point(753, 75);
            mainPic.Name = "mainPic";
            mainPic.Size = new Size(450, 450);
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;
            mainPic.TabIndex = 17;
            mainPic.TabStop = false;
            // 
            // offspringList
            // 
            offspringList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            offspringList.FormattingEnabled = true;
            offspringList.ItemHeight = 25;
            offspringList.Location = new Point(26, 32);
            offspringList.Name = "offspringList";
            offspringList.Size = new Size(630, 204);
            offspringList.TabIndex = 24;
            // 
            // addOffspringButton
            // 
            addOffspringButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addOffspringButton.Location = new Point(486, 242);
            addOffspringButton.Name = "addOffspringButton";
            addOffspringButton.Size = new Size(170, 40);
            addOffspringButton.TabIndex = 25;
            addOffspringButton.Text = "Add an Offspring";
            addOffspringButton.UseVisualStyleBackColor = true;
            addOffspringButton.Click += addOffspringButton_Click;
            // 
            // offspringsPanel
            // 
            offspringsPanel.Controls.Add(offspringList);
            offspringsPanel.Controls.Add(addOffspringButton);
            offspringsPanel.Controls.Add(label8);
            offspringsPanel.Location = new Point(50, 283);
            offspringsPanel.Name = "offspringsPanel";
            offspringsPanel.Size = new Size(680, 285);
            offspringsPanel.TabIndex = 26;
            // 
            // fledglingLabel
            // 
            fledglingLabel.AutoSize = true;
            fledglingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fledglingLabel.Location = new Point(312, 270);
            fledglingLabel.Name = "fledglingLabel";
            fledglingLabel.Size = new Size(181, 25);
            fledglingLabel.TabIndex = 27;
            fledglingLabel.Text = "I am still a fledgling";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(682, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // MoreDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(fledglingLabel);
            Controls.Add(offspringsPanel);
            Controls.Add(mainPic);
            Controls.Add(panel1);
            Name = "MoreDetails";
            Size = new Size(1264, 611);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).EndInit();
            offspringsPanel.ResumeLayout(false);
            offspringsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private Label nameLabel;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label8;
        private PictureBox mainPic;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox offspringList;
        private Button addOffspringButton;
        public Panel offspringsPanel;
        public Label fledglingLabel;
        private Button editButton;
        private TextBox idLabel;
        private Button saveButton;
        private FlowLayoutPanel flowLayoutPanel2;
        public DateTimePicker dateLabel;
        private TextBox momIdLabel;
        private TextBox dadIdLabel;
        private TextBox cageIdLabel;
        private TextBox genderLabel;
        private TextBox subTypeLabel;
        private TextBox typeLabel;
        public DateTimePicker dateTimePicker1;
    }
}

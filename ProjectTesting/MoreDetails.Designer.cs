using System.Windows.Forms;

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
            datePicker = new DateTimePicker();
            momIdLabel = new TextBox();
            dadIdLabel = new TextBox();
            cageIdLabel = new TextBox();
            genderLabel = new TextBox();
            subTypeLabel = new TextBox();
            typeLabel = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveBirdButton = new Button();
            editBirdButton = new Button();
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
            birdPanel = new Panel();
            progressBarPanel = new Panel();
            prograssBarLabel = new Label();
            progressBar = new ProgressBar();
            cagePanel = new Panel();
            editPanel = new FlowLayoutPanel();
            editCageButton = new Button();
            saveCageButton = new Button();
            listLabel = new Label();
            birdList = new ListBox();
            panel3 = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            cageValue = new TextBox();
            materialValue = new TextBox();
            lengthValue = new TextBox();
            widthValue = new TextBox();
            heightValue = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            cageLabel = new Label();
            materialLabel = new Label();
            lengthLabel = new Label();
            widthLabel = new Label();
            heightLabel = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).BeginInit();
            offspringsPanel.SuspendLayout();
            birdPanel.SuspendLayout();
            progressBarPanel.SuspendLayout();
            cagePanel.SuspendLayout();
            editPanel.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(momIdLabel);
            panel1.Controls.Add(dadIdLabel);
            panel1.Controls.Add(cageIdLabel);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(subTypeLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(167, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 223);
            panel1.TabIndex = 16;
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Enabled = false;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(159, 87);
            datePicker.Margin = new Padding(1);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(111, 23);
            datePicker.TabIndex = 38;
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
            flowLayoutPanel2.Controls.Add(saveBirdButton);
            flowLayoutPanel2.Controls.Add(editBirdButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(300, 128);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(80, 95);
            flowLayoutPanel2.TabIndex = 30;
            // 
            // saveBirdButton
            // 
            saveBirdButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBirdButton.Location = new Point(3, 52);
            saveBirdButton.Name = "saveBirdButton";
            saveBirdButton.Size = new Size(70, 40);
            saveBirdButton.TabIndex = 29;
            saveBirdButton.Text = "Save";
            saveBirdButton.UseVisualStyleBackColor = true;
            saveBirdButton.Click += saveBirdButton_Click;
            // 
            // editBirdButton
            // 
            editBirdButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBirdButton.Location = new Point(3, 6);
            editBirdButton.Name = "editBirdButton";
            editBirdButton.Size = new Size(70, 40);
            editBirdButton.TabIndex = 28;
            editBirdButton.Text = "Edit";
            editBirdButton.UseVisualStyleBackColor = true;
            editBirdButton.Click += editBirdButton_Click;
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
            mainPic.Location = new Point(705, 44);
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
            offspringList.Size = new Size(630, 179);
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
            offspringsPanel.Location = new Point(2, 252);
            offspringsPanel.Name = "offspringsPanel";
            offspringsPanel.Size = new Size(680, 285);
            offspringsPanel.TabIndex = 26;
            // 
            // fledglingLabel
            // 
            fledglingLabel.AutoSize = true;
            fledglingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fledglingLabel.Location = new Point(264, 239);
            fledglingLabel.Name = "fledglingLabel";
            fledglingLabel.Size = new Size(181, 25);
            fledglingLabel.TabIndex = 27;
            fledglingLabel.Text = "I am still a fledgling";
            // 
            // birdPanel
            // 
            birdPanel.Controls.Add(progressBarPanel);
            birdPanel.Controls.Add(panel1);
            birdPanel.Controls.Add(fledglingLabel);
            birdPanel.Controls.Add(mainPic);
            birdPanel.Controls.Add(offspringsPanel);
            birdPanel.Location = new Point(55, 46);
            birdPanel.Name = "birdPanel";
            birdPanel.Size = new Size(1160, 539);
            birdPanel.TabIndex = 28;
            // 
            // progressBarPanel
            // 
            progressBarPanel.BackColor = Color.Moccasin;
            progressBarPanel.Controls.Add(prograssBarLabel);
            progressBarPanel.Controls.Add(progressBar);
            progressBarPanel.Location = new Point(427, 196);
            progressBarPanel.Name = "progressBarPanel";
            progressBarPanel.Size = new Size(310, 90);
            progressBarPanel.TabIndex = 30;
            progressBarPanel.Visible = false;
            // 
            // prograssBarLabel
            // 
            prograssBarLabel.AutoSize = true;
            prograssBarLabel.Location = new Point(37, 10);
            prograssBarLabel.Name = "prograssBarLabel";
            prograssBarLabel.Size = new Size(237, 15);
            prograssBarLabel.TabIndex = 29;
            prograssBarLabel.Text = "checking your input and saving the data . . .";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(24, 27);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(261, 50);
            progressBar.TabIndex = 28;
            progressBar.Value = 100;
            // 
            // cagePanel
            // 
            cagePanel.Controls.Add(editPanel);
            cagePanel.Controls.Add(listLabel);
            cagePanel.Controls.Add(birdList);
            cagePanel.Controls.Add(panel3);
            cagePanel.Location = new Point(22, 18);
            cagePanel.Margin = new Padding(1);
            cagePanel.Name = "cagePanel";
            cagePanel.Size = new Size(1218, 569);
            cagePanel.TabIndex = 29;
            cagePanel.Visible = false;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editCageButton);
            editPanel.Controls.Add(saveCageButton);
            editPanel.Location = new Point(748, 117);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(162, 45);
            editPanel.TabIndex = 5;
            // 
            // editCageButton
            // 
            editCageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editCageButton.Location = new Point(3, 3);
            editCageButton.Name = "editCageButton";
            editCageButton.Size = new Size(75, 40);
            editCageButton.TabIndex = 3;
            editCageButton.Text = "Edit";
            editCageButton.UseVisualStyleBackColor = true;
            editCageButton.Click += editCageButton_Click;
            // 
            // saveCageButton
            // 
            saveCageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveCageButton.Location = new Point(84, 3);
            saveCageButton.Name = "saveCageButton";
            saveCageButton.Size = new Size(75, 40);
            saveCageButton.TabIndex = 4;
            saveCageButton.Text = "Save";
            saveCageButton.UseVisualStyleBackColor = true;
            saveCageButton.Visible = false;
            saveCageButton.Click += saveCageButton_Click;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            listLabel.Location = new Point(192, 189);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(218, 25);
            listLabel.TabIndex = 2;
            listLabel.Text = "List of birds in this cage:";
            // 
            // birdList
            // 
            birdList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            birdList.FormattingEnabled = true;
            birdList.ItemHeight = 25;
            birdList.Location = new Point(192, 217);
            birdList.Name = "birdList";
            birdList.Size = new Size(867, 254);
            birdList.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(flowLayoutPanel5);
            panel3.Controls.Add(flowLayoutPanel4);
            panel3.Location = new Point(504, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 141);
            panel3.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(cageValue);
            flowLayoutPanel5.Controls.Add(materialValue);
            flowLayoutPanel5.Controls.Add(lengthValue);
            flowLayoutPanel5.Controls.Add(widthValue);
            flowLayoutPanel5.Controls.Add(heightValue);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(105, 6);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 2, 0, 0);
            flowLayoutPanel5.Size = new Size(132, 134);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // cageValue
            // 
            cageValue.BackColor = SystemColors.ActiveCaption;
            cageValue.BorderStyle = BorderStyle.None;
            cageValue.Enabled = false;
            cageValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cageValue.Location = new Point(3, 5);
            cageValue.Name = "cageValue";
            cageValue.Size = new Size(120, 19);
            cageValue.TabIndex = 10;
            cageValue.Text = "A5342G";
            // 
            // materialValue
            // 
            materialValue.BackColor = SystemColors.ActiveCaption;
            materialValue.BorderStyle = BorderStyle.None;
            materialValue.Enabled = false;
            materialValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialValue.Location = new Point(3, 30);
            materialValue.Name = "materialValue";
            materialValue.Size = new Size(120, 19);
            materialValue.TabIndex = 11;
            materialValue.Text = "WOOD";
            // 
            // lengthValue
            // 
            lengthValue.BackColor = SystemColors.ActiveCaption;
            lengthValue.BorderStyle = BorderStyle.None;
            lengthValue.Enabled = false;
            lengthValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lengthValue.Location = new Point(3, 55);
            lengthValue.Name = "lengthValue";
            lengthValue.Size = new Size(120, 19);
            lengthValue.TabIndex = 12;
            lengthValue.Text = "35";
            // 
            // widthValue
            // 
            widthValue.BackColor = SystemColors.ActiveCaption;
            widthValue.BorderStyle = BorderStyle.None;
            widthValue.Enabled = false;
            widthValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            widthValue.Location = new Point(3, 80);
            widthValue.Name = "widthValue";
            widthValue.Size = new Size(120, 19);
            widthValue.TabIndex = 13;
            widthValue.Text = "25";
            // 
            // heightValue
            // 
            heightValue.BackColor = SystemColors.ActiveCaption;
            heightValue.BorderStyle = BorderStyle.None;
            heightValue.Enabled = false;
            heightValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            heightValue.Location = new Point(3, 105);
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(120, 19);
            heightValue.TabIndex = 14;
            heightValue.Text = "68";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(cageLabel);
            flowLayoutPanel4.Controls.Add(materialLabel);
            flowLayoutPanel4.Controls.Add(lengthLabel);
            flowLayoutPanel4.Controls.Add(widthLabel);
            flowLayoutPanel4.Controls.Add(heightLabel);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(8, 7);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(95, 126);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // cageLabel
            // 
            cageLabel.AutoSize = true;
            cageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cageLabel.Location = new Point(3, 0);
            cageLabel.Name = "cageLabel";
            cageLabel.Size = new Size(82, 25);
            cageLabel.TabIndex = 0;
            cageLabel.Text = "Cage Id:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(3, 25);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(89, 25);
            materialLabel.TabIndex = 2;
            materialLabel.Text = "Material:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lengthLabel.Location = new Point(3, 50);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(76, 25);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(3, 75);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(69, 25);
            widthLabel.TabIndex = 6;
            widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            heightLabel.Location = new Point(3, 100);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(75, 25);
            heightLabel.TabIndex = 8;
            heightLabel.Text = "Height:";
            // 
            // MoreDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cagePanel);
            Controls.Add(birdPanel);
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
            birdPanel.ResumeLayout(false);
            birdPanel.PerformLayout();
            progressBarPanel.ResumeLayout(false);
            progressBarPanel.PerformLayout();
            cagePanel.ResumeLayout(false);
            cagePanel.PerformLayout();
            editPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
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
        private Button editBirdButton;
        private TextBox idLabel;
        private Button saveBirdButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox momIdLabel;
        private TextBox dadIdLabel;
        private TextBox cageIdLabel;
        private TextBox genderLabel;
        private TextBox subTypeLabel;
        private TextBox typeLabel;
        private Panel birdPanel;
        private Panel cagePanel;
        private ListBox birdList;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label cageLabel;
        private Label materialLabel;
        private Label lengthLabel;
        private Label widthLabel;
        private Label heightLabel;
        private Label listLabel;
        public Panel progressBarPanel;
        public ProgressBar progressBar;
        private Label prograssBarLabel;
        private FlowLayoutPanel editPanel;
        private Button editCageButton;
        private Button saveCageButton;
        private TextBox cageValue;
        private TextBox materialValue;
        private TextBox lengthValue;
        private TextBox widthValue;
        private TextBox heightValue;
        private DateTimePicker datePicker;
    }
}

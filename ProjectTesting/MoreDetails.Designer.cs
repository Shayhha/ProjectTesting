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
            saveBirdButton = new RJControls.RJButton();
            editBirdButton = new RJControls.RJButton();
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
            offspringsPanel = new Panel();
            addOffspringButton = new RJControls.RJButton();
            fledglingLabel = new Label();
            birdPanel = new Panel();
            cagePanel = new Panel();
            listLabel = new Label();
            birdList = new ListBox();
            panel3 = new Panel();
            editPanel = new FlowLayoutPanel();
            saveCageButton = new RJControls.RJButton();
            editCageButton = new RJControls.RJButton();
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
            cagePanel.SuspendLayout();
            panel3.SuspendLayout();
            editPanel.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 135, 110);
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
            momIdLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            dadIdLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            cageIdLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            genderLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            subTypeLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            typeLabel.BackColor = Color.FromArgb(97, 135, 110);
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
            saveBirdButton.BackColor = Color.FromArgb(145, 199, 136);
            saveBirdButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            saveBirdButton.BorderColor = Color.FromArgb(115, 165, 100);
            saveBirdButton.BorderRadius = 10;
            saveBirdButton.BorderSize = 2;
            saveBirdButton.Cursor = Cursors.Hand;
            saveBirdButton.FlatAppearance.BorderSize = 0;
            saveBirdButton.FlatStyle = FlatStyle.Flat;
            saveBirdButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveBirdButton.ForeColor = Color.Black;
            saveBirdButton.Location = new Point(3, 52);
            saveBirdButton.Name = "saveBirdButton";
            saveBirdButton.Size = new Size(75, 40);
            saveBirdButton.TabIndex = 46;
            saveBirdButton.Text = "Save";
            saveBirdButton.TextColor = Color.Black;
            saveBirdButton.UseVisualStyleBackColor = false;
            saveBirdButton.Visible = false;
            saveBirdButton.Click += saveBirdButton_Click;
            // 
            // editBirdButton
            // 
            editBirdButton.BackColor = Color.FromArgb(145, 199, 136);
            editBirdButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            editBirdButton.BorderColor = Color.FromArgb(115, 165, 100);
            editBirdButton.BorderRadius = 10;
            editBirdButton.BorderSize = 2;
            editBirdButton.Cursor = Cursors.Hand;
            editBirdButton.FlatAppearance.BorderSize = 0;
            editBirdButton.FlatStyle = FlatStyle.Flat;
            editBirdButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            editBirdButton.ForeColor = Color.Black;
            editBirdButton.Location = new Point(3, 6);
            editBirdButton.Name = "editBirdButton";
            editBirdButton.Size = new Size(75, 40);
            editBirdButton.TabIndex = 45;
            editBirdButton.Text = "Edit";
            editBirdButton.TextColor = Color.Black;
            editBirdButton.UseVisualStyleBackColor = false;
            editBirdButton.Click += editBirdButton_Click;
            // 
            // idLabel
            // 
            idLabel.BackColor = Color.FromArgb(97, 135, 110);
            idLabel.BorderStyle = BorderStyle.None;
            idLabel.Enabled = false;
            idLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.ForeColor = SystemColors.WindowText;
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
            mainPic.Location = new Point(750, 0);
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
            offspringList.Location = new Point(3, 32);
            offspringList.Name = "offspringList";
            offspringList.Size = new Size(677, 179);
            offspringList.TabIndex = 24;
            // 
            // offspringsPanel
            // 
            offspringsPanel.Controls.Add(addOffspringButton);
            offspringsPanel.Controls.Add(offspringList);
            offspringsPanel.Controls.Add(label8);
            offspringsPanel.Location = new Point(2, 252);
            offspringsPanel.Name = "offspringsPanel";
            offspringsPanel.Size = new Size(697, 285);
            offspringsPanel.TabIndex = 26;
            // 
            // addOffspringButton
            // 
            addOffspringButton.BackColor = Color.FromArgb(145, 199, 136);
            addOffspringButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            addOffspringButton.BorderColor = Color.FromArgb(115, 165, 100);
            addOffspringButton.BorderRadius = 10;
            addOffspringButton.BorderSize = 2;
            addOffspringButton.Cursor = Cursors.Hand;
            addOffspringButton.FlatAppearance.BorderSize = 0;
            addOffspringButton.FlatStyle = FlatStyle.Flat;
            addOffspringButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            addOffspringButton.ForeColor = Color.Black;
            addOffspringButton.Location = new Point(482, 220);
            addOffspringButton.Name = "addOffspringButton";
            addOffspringButton.Size = new Size(198, 40);
            addOffspringButton.TabIndex = 47;
            addOffspringButton.Text = "Add an Offspring";
            addOffspringButton.TextColor = Color.Black;
            addOffspringButton.UseVisualStyleBackColor = false;
            addOffspringButton.Visible = false;
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
            birdPanel.Controls.Add(panel1);
            birdPanel.Controls.Add(fledglingLabel);
            birdPanel.Controls.Add(mainPic);
            birdPanel.Controls.Add(offspringsPanel);
            birdPanel.Location = new Point(15, 46);
            birdPanel.Name = "birdPanel";
            birdPanel.Size = new Size(1200, 539);
            birdPanel.TabIndex = 28;
            // 
            // cagePanel
            // 
            cagePanel.Controls.Add(listLabel);
            cagePanel.Controls.Add(birdList);
            cagePanel.Controls.Add(panel3);
            cagePanel.Location = new Point(15, 25);
            cagePanel.Margin = new Padding(1);
            cagePanel.Name = "cagePanel";
            cagePanel.Size = new Size(1218, 569);
            cagePanel.TabIndex = 29;
            cagePanel.Visible = false;
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
            birdList.BackColor = Color.WhiteSmoke;
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
            panel3.BackColor = Color.FromArgb(97, 135, 110);
            panel3.Controls.Add(editPanel);
            panel3.Controls.Add(flowLayoutPanel5);
            panel3.Controls.Add(flowLayoutPanel4);
            panel3.Location = new Point(501, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 170);
            panel3.TabIndex = 0;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(saveCageButton);
            editPanel.Controls.Add(editCageButton);
            editPanel.FlowDirection = FlowDirection.BottomUp;
            editPanel.Location = new Point(241, 72);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(87, 95);
            editPanel.TabIndex = 5;
            // 
            // saveCageButton
            // 
            saveCageButton.BackColor = Color.FromArgb(145, 199, 136);
            saveCageButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            saveCageButton.BorderColor = Color.FromArgb(115, 165, 100);
            saveCageButton.BorderRadius = 10;
            saveCageButton.BorderSize = 2;
            saveCageButton.Cursor = Cursors.Hand;
            saveCageButton.FlatAppearance.BorderSize = 0;
            saveCageButton.FlatStyle = FlatStyle.Flat;
            saveCageButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveCageButton.ForeColor = Color.Black;
            saveCageButton.Location = new Point(3, 52);
            saveCageButton.Name = "saveCageButton";
            saveCageButton.Size = new Size(75, 40);
            saveCageButton.TabIndex = 45;
            saveCageButton.Text = "Save";
            saveCageButton.TextColor = Color.Black;
            saveCageButton.UseVisualStyleBackColor = false;
            saveCageButton.Visible = false;
            saveCageButton.Click += saveCageButton_Click;
            // 
            // editCageButton
            // 
            editCageButton.BackColor = Color.FromArgb(145, 199, 136);
            editCageButton.BackgroundColor = Color.FromArgb(145, 199, 136);
            editCageButton.BorderColor = Color.FromArgb(115, 165, 100);
            editCageButton.BorderRadius = 10;
            editCageButton.BorderSize = 2;
            editCageButton.Cursor = Cursors.Hand;
            editCageButton.FlatAppearance.BorderSize = 0;
            editCageButton.FlatStyle = FlatStyle.Flat;
            editCageButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            editCageButton.ForeColor = Color.Black;
            editCageButton.Location = new Point(3, 6);
            editCageButton.Name = "editCageButton";
            editCageButton.Size = new Size(75, 40);
            editCageButton.TabIndex = 44;
            editCageButton.Text = "Edit";
            editCageButton.TextColor = Color.Black;
            editCageButton.UseVisualStyleBackColor = false;
            editCageButton.Click += editCageButton_Click;
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
            cageValue.BackColor = Color.FromArgb(97, 135, 110);
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
            materialValue.BackColor = Color.FromArgb(97, 135, 110);
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
            lengthValue.BackColor = Color.FromArgb(97, 135, 110);
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
            widthValue.BackColor = Color.FromArgb(97, 135, 110);
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
            heightValue.BackColor = Color.FromArgb(97, 135, 110);
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
            BackColor = Color.FromArgb(210, 230, 200);
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
            cagePanel.ResumeLayout(false);
            cagePanel.PerformLayout();
            panel3.ResumeLayout(false);
            editPanel.ResumeLayout(false);
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
        public Panel offspringsPanel;
        public Label fledglingLabel;
        private TextBox idLabel;
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
        private FlowLayoutPanel editPanel;
        private TextBox cageValue;
        private TextBox materialValue;
        private TextBox lengthValue;
        private TextBox widthValue;
        private TextBox heightValue;
        private DateTimePicker datePicker;
        private RJControls.RJButton saveCageButton;
        private RJControls.RJButton editCageButton;
        private RJControls.RJButton saveBirdButton;
        private RJControls.RJButton editBirdButton;
        private RJControls.RJButton addOffspringButton;
    }
}

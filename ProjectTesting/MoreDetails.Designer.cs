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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreDetails));
            panel1 = new Panel();
            idLabel = new TextBox();
            nameLabel = new Label();
            momIdLabel = new TextBox();
            label5 = new Label();
            typeLabel = new TextBox();
            label3 = new Label();
            label7 = new Label();
            dadIdLabel = new TextBox();
            label6 = new Label();
            datePicker = new DateTimePicker();
            label2 = new Label();
            genderLabel = new TextBox();
            cageIdLabel = new TextBox();
            label4 = new Label();
            subTypeLabel = new TextBox();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveBirdButton = new RJControls.RJButton();
            editBirdButton = new RJControls.RJButton();
            label8 = new Label();
            mainPic = new PictureBox();
            offspringList = new ListBox();
            offspringsPanel = new Panel();
            addOffspringButton = new RJControls.RJButton();
            fledglingLabel = new Label();
            birdPanel = new Panel();
            myPic = new RJControls.RJCircularPictureBox();
            cagePanel = new Panel();
            listLabel = new Label();
            birdList = new ListBox();
            panel3 = new Panel();
            heightLabel = new Label();
            widthLabel = new Label();
            lengthLabel = new Label();
            materialLabel = new Label();
            cageLabel = new Label();
            editPanel = new FlowLayoutPanel();
            saveCageButton = new RJControls.RJButton();
            editCageButton = new RJControls.RJButton();
            flowLayoutPanel5 = new FlowLayoutPanel();
            cageValue = new RJControls.RJTextBox();
            materialValue = new RJControls.RJTextBox();
            lengthValue = new RJControls.RJTextBox();
            widthValue = new RJControls.RJTextBox();
            heightValue = new RJControls.RJTextBox();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).BeginInit();
            offspringsPanel.SuspendLayout();
            birdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myPic).BeginInit();
            cagePanel.SuspendLayout();
            panel3.SuspendLayout();
            editPanel.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 135, 110);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(momIdLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dadIdLabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(cageIdLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(subTypeLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 190);
            panel1.TabIndex = 16;
            // 
            // idLabel
            // 
            idLabel.BackColor = Color.White;
            idLabel.Enabled = false;
            idLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.ForeColor = SystemColors.WindowText;
            idLabel.Location = new Point(171, 17);
            idLabel.Name = "idLabel";
            idLabel.PlaceholderText = "John";
            idLabel.ReadOnly = true;
            idLabel.Size = new Size(188, 33);
            idLabel.TabIndex = 28;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(128, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(40, 25);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Id: ";
            // 
            // momIdLabel
            // 
            momIdLabel.BackColor = Color.White;
            momIdLabel.Enabled = false;
            momIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            momIdLabel.Location = new Point(509, 138);
            momIdLabel.Name = "momIdLabel";
            momIdLabel.PlaceholderText = "John";
            momIdLabel.ReadOnly = true;
            momIdLabel.Size = new Size(135, 33);
            momIdLabel.TabIndex = 35;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(409, 101);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 12;
            label5.Text = "Dad's Id: ";
            // 
            // typeLabel
            // 
            typeLabel.BackColor = Color.White;
            typeLabel.Enabled = false;
            typeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.Location = new Point(171, 57);
            typeLabel.Name = "typeLabel";
            typeLabel.PlaceholderText = "John";
            typeLabel.ReadOnly = true;
            typeLabel.Size = new Size(188, 33);
            typeLabel.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 101);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 8;
            label3.Text = "Sub-Type: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(414, 20);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 10;
            label7.Text = "Gender: ";
            // 
            // dadIdLabel
            // 
            dadIdLabel.BackColor = Color.White;
            dadIdLabel.Enabled = false;
            dadIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dadIdLabel.Location = new Point(509, 98);
            dadIdLabel.Name = "dadIdLabel";
            dadIdLabel.PlaceholderText = "John";
            dadIdLabel.ReadOnly = true;
            dadIdLabel.Size = new Size(135, 33);
            dadIdLabel.TabIndex = 34;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(414, 60);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 11;
            label6.Text = "Cage Id: ";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Enabled = false;
            datePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(169, 136);
            datePicker.Margin = new Padding(1);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(190, 33);
            datePicker.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 141);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth: ";
            // 
            // genderLabel
            // 
            genderLabel.BackColor = Color.White;
            genderLabel.Enabled = false;
            genderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderLabel.Location = new Point(509, 17);
            genderLabel.Name = "genderLabel";
            genderLabel.PlaceholderText = "John";
            genderLabel.ReadOnly = true;
            genderLabel.Size = new Size(135, 33);
            genderLabel.TabIndex = 32;
            // 
            // cageIdLabel
            // 
            cageIdLabel.BackColor = Color.White;
            cageIdLabel.Enabled = false;
            cageIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cageIdLabel.Location = new Point(509, 57);
            cageIdLabel.Name = "cageIdLabel";
            cageIdLabel.PlaceholderText = "John";
            cageIdLabel.ReadOnly = true;
            cageIdLabel.Size = new Size(135, 33);
            cageIdLabel.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(398, 141);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 13;
            label4.Text = "Mom's Id: ";
            // 
            // subTypeLabel
            // 
            subTypeLabel.BackColor = Color.White;
            subTypeLabel.Enabled = false;
            subTypeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            subTypeLabel.Location = new Point(171, 97);
            subTypeLabel.Name = "subTypeLabel";
            subTypeLabel.PlaceholderText = "John";
            subTypeLabel.ReadOnly = true;
            subTypeLabel.Size = new Size(188, 33);
            subTypeLabel.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 7;
            label1.Text = "Type: ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(saveBirdButton);
            flowLayoutPanel2.Controls.Add(editBirdButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(631, 153);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(3, 4);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 23;
            label8.Text = "Offsprings: ";
            // 
            // mainPic
            // 
            mainPic.Location = new Point(1019, 423);
            mainPic.Name = "mainPic";
            mainPic.Size = new Size(450, 450);
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;
            mainPic.TabIndex = 17;
            mainPic.TabStop = false;
            mainPic.Visible = false;
            // 
            // offspringList
            // 
            offspringList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            offspringList.FormattingEnabled = true;
            offspringList.ItemHeight = 25;
            offspringList.Location = new Point(3, 32);
            offspringList.Name = "offspringList";
            offspringList.Size = new Size(680, 179);
            offspringList.TabIndex = 24;
            // 
            // offspringsPanel
            // 
            offspringsPanel.Controls.Add(addOffspringButton);
            offspringsPanel.Controls.Add(offspringList);
            offspringsPanel.Controls.Add(label8);
            offspringsPanel.Location = new Point(27, 263);
            offspringsPanel.Name = "offspringsPanel";
            offspringsPanel.Size = new Size(705, 267);
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
            addOffspringButton.Location = new Point(485, 217);
            addOffspringButton.Name = "addOffspringButton";
            addOffspringButton.Size = new Size(198, 40);
            addOffspringButton.TabIndex = 47;
            addOffspringButton.Text = "Add an Offspring";
            addOffspringButton.TextColor = Color.Black;
            addOffspringButton.UseVisualStyleBackColor = false;
            addOffspringButton.Click += addOffspringButton_Click;
            // 
            // fledglingLabel
            // 
            fledglingLabel.AutoSize = true;
            fledglingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fledglingLabel.Location = new Point(284, 246);
            fledglingLabel.Name = "fledglingLabel";
            fledglingLabel.Size = new Size(181, 25);
            fledglingLabel.TabIndex = 27;
            fledglingLabel.Text = "I am still a fledgling";
            // 
            // birdPanel
            // 
            birdPanel.Controls.Add(panel1);
            birdPanel.Controls.Add(fledglingLabel);
            birdPanel.Controls.Add(offspringsPanel);
            birdPanel.Controls.Add(myPic);
            birdPanel.Controls.Add(mainPic);
            birdPanel.Controls.Add(flowLayoutPanel2);
            birdPanel.Location = new Point(15, 33);
            birdPanel.Name = "birdPanel";
            birdPanel.Size = new Size(1233, 575);
            birdPanel.TabIndex = 28;
            // 
            // myPic
            // 
            myPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            myPic.BorderColor = Color.FromArgb(145, 199, 136);
            myPic.BorderColor2 = Color.FromArgb(50, 80, 57);
            myPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            myPic.BorderSize = 6;
            myPic.GradientAngle = 20F;
            myPic.Image = (Image)resources.GetObject("myPic.Image");
            myPic.Location = new Point(755, 27);
            myPic.Name = "myPic";
            myPic.Size = new Size(475, 475);
            myPic.SizeMode = PictureBoxSizeMode.Zoom;
            myPic.TabIndex = 28;
            myPic.TabStop = false;
            // 
            // cagePanel
            // 
            cagePanel.Controls.Add(listLabel);
            cagePanel.Controls.Add(birdList);
            cagePanel.Controls.Add(panel3);
            cagePanel.Location = new Point(10, 17);
            cagePanel.Margin = new Padding(1);
            cagePanel.Name = "cagePanel";
            cagePanel.Size = new Size(1242, 581);
            cagePanel.TabIndex = 29;
            cagePanel.Visible = false;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            listLabel.Location = new Point(208, 249);
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
            birdList.Location = new Point(208, 277);
            birdList.Name = "birdList";
            birdList.Size = new Size(867, 254);
            birdList.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(97, 135, 110);
            panel3.Controls.Add(heightLabel);
            panel3.Controls.Add(widthLabel);
            panel3.Controls.Add(lengthLabel);
            panel3.Controls.Add(materialLabel);
            panel3.Controls.Add(cageLabel);
            panel3.Controls.Add(editPanel);
            panel3.Controls.Add(flowLayoutPanel5);
            panel3.Location = new Point(501, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 231);
            panel3.TabIndex = 0;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            heightLabel.Location = new Point(31, 187);
            heightLabel.Name = "heightLabel";
            heightLabel.Padding = new Padding(0, 4, 0, 0);
            heightLabel.Size = new Size(75, 29);
            heightLabel.TabIndex = 8;
            heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(37, 143);
            widthLabel.Name = "widthLabel";
            widthLabel.Padding = new Padding(0, 4, 0, 0);
            widthLabel.Size = new Size(69, 29);
            widthLabel.TabIndex = 6;
            widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lengthLabel.Location = new Point(30, 99);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Padding = new Padding(0, 4, 0, 0);
            lengthLabel.Size = new Size(76, 29);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(17, 55);
            materialLabel.Name = "materialLabel";
            materialLabel.Padding = new Padding(0, 4, 0, 0);
            materialLabel.Size = new Size(89, 29);
            materialLabel.TabIndex = 2;
            materialLabel.Text = "Material:";
            // 
            // cageLabel
            // 
            cageLabel.AutoSize = true;
            cageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cageLabel.Location = new Point(24, 12);
            cageLabel.Name = "cageLabel";
            cageLabel.Padding = new Padding(0, 4, 0, 0);
            cageLabel.Size = new Size(82, 29);
            cageLabel.TabIndex = 0;
            cageLabel.Text = "Cage Id:";
            // 
            // editPanel
            // 
            editPanel.Controls.Add(saveCageButton);
            editPanel.Controls.Add(editCageButton);
            editPanel.FlowDirection = FlowDirection.BottomUp;
            editPanel.Location = new Point(241, 132);
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
            saveCageButton.TabIndex = 6;
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
            flowLayoutPanel5.Location = new Point(109, 1);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 2, 0, 0);
            flowLayoutPanel5.Size = new Size(132, 223);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // cageValue
            // 
            cageValue.BackColor = SystemColors.Window;
            cageValue.BorderColor = Color.FromArgb(145, 199, 136);
            cageValue.BorderFocusColor = Color.FromArgb(97, 135, 110);
            cageValue.BorderRadius = 5;
            cageValue.BorderSize = 2;
            cageValue.Enabled = false;
            cageValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cageValue.ForeColor = Color.FromArgb(64, 64, 64);
            cageValue.Location = new Point(4, 6);
            cageValue.Margin = new Padding(4);
            cageValue.Multiline = false;
            cageValue.Name = "cageValue";
            cageValue.Padding = new Padding(10, 7, 10, 7);
            cageValue.PasswordChar = false;
            cageValue.PlaceholderColor = Color.DarkGray;
            cageValue.PlaceholderText = "";
            cageValue.Size = new Size(120, 36);
            cageValue.TabIndex = 1;
            cageValue.Texts = "";
            cageValue.UnderlinedStyle = false;
            // 
            // materialValue
            // 
            materialValue.BackColor = SystemColors.Window;
            materialValue.BorderColor = Color.FromArgb(145, 199, 136);
            materialValue.BorderFocusColor = Color.FromArgb(97, 135, 110);
            materialValue.BorderRadius = 5;
            materialValue.BorderSize = 2;
            materialValue.Enabled = false;
            materialValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialValue.ForeColor = Color.FromArgb(64, 64, 64);
            materialValue.Location = new Point(4, 50);
            materialValue.Margin = new Padding(4);
            materialValue.Multiline = false;
            materialValue.Name = "materialValue";
            materialValue.Padding = new Padding(10, 7, 10, 7);
            materialValue.PasswordChar = false;
            materialValue.PlaceholderColor = Color.DarkGray;
            materialValue.PlaceholderText = "";
            materialValue.Size = new Size(120, 36);
            materialValue.TabIndex = 2;
            materialValue.Texts = "";
            materialValue.UnderlinedStyle = false;
            // 
            // lengthValue
            // 
            lengthValue.BackColor = SystemColors.Window;
            lengthValue.BorderColor = Color.FromArgb(145, 199, 136);
            lengthValue.BorderFocusColor = Color.FromArgb(97, 135, 110);
            lengthValue.BorderRadius = 5;
            lengthValue.BorderSize = 2;
            lengthValue.Enabled = false;
            lengthValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lengthValue.ForeColor = Color.FromArgb(64, 64, 64);
            lengthValue.Location = new Point(4, 94);
            lengthValue.Margin = new Padding(4);
            lengthValue.Multiline = false;
            lengthValue.Name = "lengthValue";
            lengthValue.Padding = new Padding(10, 7, 10, 7);
            lengthValue.PasswordChar = false;
            lengthValue.PlaceholderColor = Color.DarkGray;
            lengthValue.PlaceholderText = "";
            lengthValue.Size = new Size(120, 36);
            lengthValue.TabIndex = 3;
            lengthValue.Texts = "";
            lengthValue.UnderlinedStyle = false;
            // 
            // widthValue
            // 
            widthValue.BackColor = SystemColors.Window;
            widthValue.BorderColor = Color.FromArgb(145, 199, 136);
            widthValue.BorderFocusColor = Color.FromArgb(97, 135, 110);
            widthValue.BorderRadius = 5;
            widthValue.BorderSize = 2;
            widthValue.Enabled = false;
            widthValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            widthValue.ForeColor = Color.FromArgb(64, 64, 64);
            widthValue.Location = new Point(4, 138);
            widthValue.Margin = new Padding(4);
            widthValue.Multiline = false;
            widthValue.Name = "widthValue";
            widthValue.Padding = new Padding(10, 7, 10, 7);
            widthValue.PasswordChar = false;
            widthValue.PlaceholderColor = Color.DarkGray;
            widthValue.PlaceholderText = "";
            widthValue.Size = new Size(120, 36);
            widthValue.TabIndex = 4;
            widthValue.Texts = "";
            widthValue.UnderlinedStyle = false;
            // 
            // heightValue
            // 
            heightValue.BackColor = SystemColors.Window;
            heightValue.BorderColor = Color.FromArgb(145, 199, 136);
            heightValue.BorderFocusColor = Color.FromArgb(97, 135, 110);
            heightValue.BorderRadius = 5;
            heightValue.BorderSize = 2;
            heightValue.Enabled = false;
            heightValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            heightValue.ForeColor = Color.FromArgb(64, 64, 64);
            heightValue.Location = new Point(4, 182);
            heightValue.Margin = new Padding(4);
            heightValue.Multiline = false;
            heightValue.Name = "heightValue";
            heightValue.Padding = new Padding(10, 7, 10, 7);
            heightValue.PasswordChar = false;
            heightValue.PlaceholderColor = Color.DarkGray;
            heightValue.PlaceholderText = "";
            heightValue.Size = new Size(120, 36);
            heightValue.TabIndex = 5;
            heightValue.Texts = "";
            heightValue.UnderlinedStyle = false;
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
            ((System.ComponentModel.ISupportInitialize)mainPic).EndInit();
            offspringsPanel.ResumeLayout(false);
            offspringsPanel.PerformLayout();
            birdPanel.ResumeLayout(false);
            birdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myPic).EndInit();
            cagePanel.ResumeLayout(false);
            cagePanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            editPanel.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
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
        private Label cageLabel;
        private Label materialLabel;
        private Label lengthLabel;
        private Label widthLabel;
        private Label heightLabel;
        private Label listLabel;
        private FlowLayoutPanel editPanel;
        private DateTimePicker datePicker;
        private RJControls.RJButton saveCageButton;
        private RJControls.RJButton editCageButton;
        private RJControls.RJButton saveBirdButton;
        private RJControls.RJButton editBirdButton;
        private RJControls.RJButton addOffspringButton;
        private RJControls.RJCircularPictureBox myPic;
        private RJControls.RJTextBox cageValue;
        private RJControls.RJTextBox materialValue;
        private RJControls.RJTextBox heightValue;
        private RJControls.RJTextBox widthValue;
        private RJControls.RJTextBox lengthValue;
    }
}

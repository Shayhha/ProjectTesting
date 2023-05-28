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
            subTypeLabel = new ComboBox();
            typeLabel = new ComboBox();
            momIdLabel = new RJControls.RJTextBox();
            dadIdLabel = new RJControls.RJTextBox();
            cageIdLabel = new RJControls.RJTextBox();
            genderLabel = new RJControls.RJTextBox();
            idLabel = new RJControls.RJTextBox();
            nameLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            datePicker = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveBirdButton = new RJControls.RJButton();
            editBirdButton = new RJControls.RJButton();
            label8 = new Label();
            offspringList = new ListBox();
            offspringsPanel = new Panel();
            addOffspringButton = new RJControls.RJButton();
            fledglingLabel = new Label();
            birdPanel = new Panel();
            mainPic = new RJControls.RJCircularPictureBox();
            cagePanel = new Panel();
            listLabel = new Label();
            birdList = new ListBox();
            panel3 = new Panel();
            heightLabel = new Label();
            widthLabel = new Label();
            materialLabel = new Label();
            lengthLabel = new Label();
            cageLabel = new Label();
            editPanel = new FlowLayoutPanel();
            saveCageButton = new RJControls.RJButton();
            editCageButton = new RJControls.RJButton();
            flowLayoutPanel5 = new FlowLayoutPanel();
            cageValue = new RJControls.RJTextBox();
            lengthValue = new RJControls.RJTextBox();
            widthValue = new RJControls.RJTextBox();
            heightValue = new RJControls.RJTextBox();
            materialValue = new ComboBox();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            offspringsPanel.SuspendLayout();
            birdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).BeginInit();
            cagePanel.SuspendLayout();
            panel3.SuspendLayout();
            editPanel.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 135, 110);
            panel1.Controls.Add(subTypeLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(momIdLabel);
            panel1.Controls.Add(dadIdLabel);
            panel1.Controls.Add(cageIdLabel);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 283);
            panel1.TabIndex = 16;
            // 
            // subTypeLabel
            // 
            subTypeLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            subTypeLabel.Enabled = false;
            subTypeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            subTypeLabel.FormattingEnabled = true;
            subTypeLabel.Location = new Point(186, 153);
            subTypeLabel.Margin = new Padding(3, 4, 3, 4);
            subTypeLabel.Name = "subTypeLabel";
            subTypeLabel.Size = new Size(254, 40);
            subTypeLabel.TabIndex = 3;
            // 
            // typeLabel
            // 
            typeLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            typeLabel.Enabled = false;
            typeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.FormattingEnabled = true;
            typeLabel.Location = new Point(186, 96);
            typeLabel.Margin = new Padding(3, 4, 3, 4);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(254, 40);
            typeLabel.TabIndex = 2;
            typeLabel.SelectedIndexChanged += typeCombobox_ItemClicked;
            // 
            // momIdLabel
            // 
            momIdLabel.BackColor = SystemColors.Window;
            momIdLabel.BorderColor = Color.FromArgb(145, 199, 136);
            momIdLabel.BorderFocusColor = Color.FromArgb(97, 135, 110);
            momIdLabel.BorderRadius = 5;
            momIdLabel.BorderSize = 2;
            momIdLabel.Enabled = false;
            momIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            momIdLabel.ForeColor = Color.FromArgb(64, 64, 64);
            momIdLabel.Location = new Point(580, 201);
            momIdLabel.Margin = new Padding(5);
            momIdLabel.Multiline = false;
            momIdLabel.Name = "momIdLabel";
            momIdLabel.Padding = new Padding(11, 9, 11, 9);
            momIdLabel.PasswordChar = false;
            momIdLabel.PlaceholderColor = Color.DarkGray;
            momIdLabel.PlaceholderText = "";
            momIdLabel.Size = new Size(158, 51);
            momIdLabel.TabIndex = 8;
            momIdLabel.Texts = "";
            momIdLabel.UnderlinedStyle = false;
            // 
            // dadIdLabel
            // 
            dadIdLabel.BackColor = SystemColors.Window;
            dadIdLabel.BorderColor = Color.FromArgb(145, 199, 136);
            dadIdLabel.BorderFocusColor = Color.FromArgb(97, 135, 110);
            dadIdLabel.BorderRadius = 5;
            dadIdLabel.BorderSize = 2;
            dadIdLabel.Enabled = false;
            dadIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dadIdLabel.ForeColor = Color.FromArgb(64, 64, 64);
            dadIdLabel.Location = new Point(580, 144);
            dadIdLabel.Margin = new Padding(5);
            dadIdLabel.Multiline = false;
            dadIdLabel.Name = "dadIdLabel";
            dadIdLabel.Padding = new Padding(11, 9, 11, 9);
            dadIdLabel.PasswordChar = false;
            dadIdLabel.PlaceholderColor = Color.DarkGray;
            dadIdLabel.PlaceholderText = "";
            dadIdLabel.Size = new Size(158, 51);
            dadIdLabel.TabIndex = 7;
            dadIdLabel.Texts = "";
            dadIdLabel.UnderlinedStyle = false;
            // 
            // cageIdLabel
            // 
            cageIdLabel.BackColor = SystemColors.Window;
            cageIdLabel.BorderColor = Color.FromArgb(145, 199, 136);
            cageIdLabel.BorderFocusColor = Color.FromArgb(97, 135, 110);
            cageIdLabel.BorderRadius = 5;
            cageIdLabel.BorderSize = 2;
            cageIdLabel.Enabled = false;
            cageIdLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cageIdLabel.ForeColor = Color.FromArgb(64, 64, 64);
            cageIdLabel.Location = new Point(580, 87);
            cageIdLabel.Margin = new Padding(5);
            cageIdLabel.Multiline = false;
            cageIdLabel.Name = "cageIdLabel";
            cageIdLabel.Padding = new Padding(11, 9, 11, 9);
            cageIdLabel.PasswordChar = false;
            cageIdLabel.PlaceholderColor = Color.DarkGray;
            cageIdLabel.PlaceholderText = "";
            cageIdLabel.Size = new Size(158, 51);
            cageIdLabel.TabIndex = 6;
            cageIdLabel.Texts = "";
            cageIdLabel.UnderlinedStyle = false;
            // 
            // genderLabel
            // 
            genderLabel.BackColor = SystemColors.Window;
            genderLabel.BorderColor = Color.FromArgb(145, 199, 136);
            genderLabel.BorderFocusColor = Color.FromArgb(97, 135, 110);
            genderLabel.BorderRadius = 5;
            genderLabel.BorderSize = 2;
            genderLabel.Enabled = false;
            genderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderLabel.ForeColor = Color.FromArgb(64, 64, 64);
            genderLabel.Location = new Point(580, 29);
            genderLabel.Margin = new Padding(5);
            genderLabel.Multiline = false;
            genderLabel.Name = "genderLabel";
            genderLabel.Padding = new Padding(11, 9, 11, 9);
            genderLabel.PasswordChar = false;
            genderLabel.PlaceholderColor = Color.DarkGray;
            genderLabel.PlaceholderText = "";
            genderLabel.Size = new Size(158, 51);
            genderLabel.TabIndex = 5;
            genderLabel.Texts = "";
            genderLabel.UnderlinedStyle = false;
            // 
            // idLabel
            // 
            idLabel.BackColor = SystemColors.Window;
            idLabel.BorderColor = Color.FromArgb(145, 199, 136);
            idLabel.BorderFocusColor = Color.FromArgb(97, 135, 110);
            idLabel.BorderRadius = 5;
            idLabel.BorderSize = 2;
            idLabel.Enabled = false;
            idLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.ForeColor = Color.FromArgb(64, 64, 64);
            idLabel.Location = new Point(186, 29);
            idLabel.Margin = new Padding(5);
            idLabel.Multiline = false;
            idLabel.Name = "idLabel";
            idLabel.Padding = new Padding(11, 9, 11, 9);
            idLabel.PasswordChar = false;
            idLabel.PlaceholderColor = Color.DarkGray;
            idLabel.PlaceholderText = "";
            idLabel.Size = new Size(254, 51);
            idLabel.TabIndex = 1;
            idLabel.Texts = "";
            idLabel.UnderlinedStyle = false;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(139, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 32);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Id: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(464, 153);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 12;
            label5.Text = "Dad's Id: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 155);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 8;
            label3.Text = "Sub-Type: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(473, 35);
            label7.Name = "label7";
            label7.Size = new Size(112, 39);
            label7.TabIndex = 10;
            label7.Text = "Gender: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(471, 96);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 11;
            label6.Text = "Cage Id: ";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Enabled = false;
            datePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(186, 211);
            datePicker.Margin = new Padding(1);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(254, 39);
            datePicker.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 213);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth: ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(450, 211);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 13;
            label4.Text = "Mom's Id: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 97);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 7;
            label1.Text = "Type: ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(saveBirdButton);
            flowLayoutPanel2.Controls.Add(editBirdButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(721, 220);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(91, 127);
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
            saveBirdButton.Location = new Point(3, 70);
            saveBirdButton.Margin = new Padding(3, 4, 3, 4);
            saveBirdButton.Name = "saveBirdButton";
            saveBirdButton.Size = new Size(86, 53);
            saveBirdButton.TabIndex = 9;
            saveBirdButton.Text = "Save";
            saveBirdButton.TextColor = Color.Black;
            saveBirdButton.UseVisualStyleBackColor = false;
            saveBirdButton.Visible = false;
            saveBirdButton.Click += saveBird_Button_Click;
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
            editBirdButton.Location = new Point(3, 9);
            editBirdButton.Margin = new Padding(3, 4, 3, 4);
            editBirdButton.Name = "editBirdButton";
            editBirdButton.Size = new Size(86, 53);
            editBirdButton.TabIndex = 45;
            editBirdButton.Text = "Edit";
            editBirdButton.TextColor = Color.Black;
            editBirdButton.UseVisualStyleBackColor = false;
            editBirdButton.Click += editBird_Button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(3, 5);
            label8.Name = "label8";
            label8.Size = new Size(138, 32);
            label8.TabIndex = 23;
            label8.Text = "Offsprings: ";
            // 
            // offspringList
            // 
            offspringList.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            offspringList.FormattingEnabled = true;
            offspringList.ItemHeight = 30;
            offspringList.Location = new Point(3, 43);
            offspringList.Margin = new Padding(3, 4, 3, 4);
            offspringList.Name = "offspringList";
            offspringList.Size = new Size(777, 214);
            offspringList.TabIndex = 24;
            // 
            // offspringsPanel
            // 
            offspringsPanel.Controls.Add(addOffspringButton);
            offspringsPanel.Controls.Add(offspringList);
            offspringsPanel.Controls.Add(label8);
            offspringsPanel.Location = new Point(31, 372);
            offspringsPanel.Margin = new Padding(3, 4, 3, 4);
            offspringsPanel.Name = "offspringsPanel";
            offspringsPanel.Size = new Size(806, 356);
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
            addOffspringButton.Location = new Point(554, 289);
            addOffspringButton.Margin = new Padding(3, 4, 3, 4);
            addOffspringButton.Name = "addOffspringButton";
            addOffspringButton.Size = new Size(226, 53);
            addOffspringButton.TabIndex = 10;
            addOffspringButton.Text = "Add an Offspring";
            addOffspringButton.TextColor = Color.Black;
            addOffspringButton.UseVisualStyleBackColor = false;
            addOffspringButton.Click += addOffspring_Button_Click;
            // 
            // fledglingLabel
            // 
            fledglingLabel.AutoSize = true;
            fledglingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fledglingLabel.Location = new Point(325, 349);
            fledglingLabel.Name = "fledglingLabel";
            fledglingLabel.Size = new Size(228, 32);
            fledglingLabel.TabIndex = 27;
            fledglingLabel.Text = "I am still a fledgling";
            // 
            // birdPanel
            // 
            birdPanel.Controls.Add(panel1);
            birdPanel.Controls.Add(fledglingLabel);
            birdPanel.Controls.Add(offspringsPanel);
            birdPanel.Controls.Add(mainPic);
            birdPanel.Controls.Add(flowLayoutPanel2);
            birdPanel.Location = new Point(17, 29);
            birdPanel.Margin = new Padding(3, 4, 3, 4);
            birdPanel.Name = "birdPanel";
            birdPanel.Size = new Size(1409, 781);
            birdPanel.TabIndex = 28;
            // 
            // mainPic
            // 
            mainPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            mainPic.BorderColor = Color.FromArgb(145, 199, 136);
            mainPic.BorderColor2 = Color.FromArgb(50, 80, 57);
            mainPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            mainPic.BorderSize = 6;
            mainPic.GradientAngle = 20F;
            mainPic.Image = (Image)resources.GetObject("mainPic.Image");
            mainPic.Location = new Point(863, 60);
            mainPic.Margin = new Padding(3, 4, 3, 4);
            mainPic.Name = "mainPic";
            mainPic.Size = new Size(543, 543);
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;
            mainPic.TabIndex = 28;
            mainPic.TabStop = false;
            // 
            // cagePanel
            // 
            cagePanel.Controls.Add(listLabel);
            cagePanel.Controls.Add(birdList);
            cagePanel.Controls.Add(panel3);
            cagePanel.Location = new Point(13, 21);
            cagePanel.Margin = new Padding(1);
            cagePanel.Name = "cagePanel";
            cagePanel.Size = new Size(1419, 775);
            cagePanel.TabIndex = 29;
            cagePanel.Visible = false;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            listLabel.Location = new Point(238, 332);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(277, 32);
            listLabel.TabIndex = 2;
            listLabel.Text = "List of birds in this cage:";
            // 
            // birdList
            // 
            birdList.BackColor = Color.WhiteSmoke;
            birdList.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            birdList.FormattingEnabled = true;
            birdList.ItemHeight = 35;
            birdList.Location = new Point(238, 369);
            birdList.Margin = new Padding(3, 4, 3, 4);
            birdList.Name = "birdList";
            birdList.Size = new Size(990, 319);
            birdList.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(97, 135, 110);
            panel3.Controls.Add(heightLabel);
            panel3.Controls.Add(widthLabel);
            panel3.Controls.Add(materialLabel);
            panel3.Controls.Add(lengthLabel);
            panel3.Controls.Add(cageLabel);
            panel3.Controls.Add(editPanel);
            panel3.Controls.Add(flowLayoutPanel5);
            panel3.Location = new Point(573, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 308);
            panel3.TabIndex = 0;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            heightLabel.Location = new Point(36, 184);
            heightLabel.Name = "heightLabel";
            heightLabel.Padding = new Padding(0, 5, 0, 0);
            heightLabel.Size = new Size(94, 37);
            heightLabel.TabIndex = 8;
            heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(43, 126);
            widthLabel.Name = "widthLabel";
            widthLabel.Padding = new Padding(0, 5, 0, 0);
            widthLabel.Size = new Size(86, 37);
            widthLabel.TabIndex = 6;
            widthLabel.Text = "Width:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(19, 234);
            materialLabel.Name = "materialLabel";
            materialLabel.Padding = new Padding(0, 5, 0, 0);
            materialLabel.Size = new Size(111, 37);
            materialLabel.TabIndex = 2;
            materialLabel.Text = "Material:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lengthLabel.Location = new Point(33, 69);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Padding = new Padding(0, 5, 0, 0);
            lengthLabel.Size = new Size(96, 37);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // cageLabel
            // 
            cageLabel.AutoSize = true;
            cageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cageLabel.Location = new Point(27, 14);
            cageLabel.Name = "cageLabel";
            cageLabel.Padding = new Padding(0, 5, 0, 0);
            cageLabel.Size = new Size(103, 37);
            cageLabel.TabIndex = 0;
            cageLabel.Text = "Cage Id:";
            // 
            // editPanel
            // 
            editPanel.Controls.Add(saveCageButton);
            editPanel.Controls.Add(editCageButton);
            editPanel.FlowDirection = FlowDirection.BottomUp;
            editPanel.Location = new Point(275, 176);
            editPanel.Margin = new Padding(3, 4, 3, 4);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(99, 127);
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
            saveCageButton.Location = new Point(3, 70);
            saveCageButton.Margin = new Padding(3, 4, 3, 4);
            saveCageButton.Name = "saveCageButton";
            saveCageButton.Padding = new Padding(0, 3, 0, 0);
            saveCageButton.Size = new Size(86, 53);
            saveCageButton.TabIndex = 6;
            saveCageButton.Text = "Save";
            saveCageButton.TextColor = Color.Black;
            saveCageButton.UseVisualStyleBackColor = false;
            saveCageButton.Visible = false;
            saveCageButton.Click += saveCage_Button_Click;
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
            editCageButton.Location = new Point(3, 9);
            editCageButton.Margin = new Padding(3, 4, 3, 4);
            editCageButton.Name = "editCageButton";
            editCageButton.Padding = new Padding(0, 3, 0, 0);
            editCageButton.Size = new Size(86, 53);
            editCageButton.TabIndex = 44;
            editCageButton.Text = "Edit";
            editCageButton.TextColor = Color.Black;
            editCageButton.UseVisualStyleBackColor = false;
            editCageButton.Click += editCage_Button_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(cageValue);
            flowLayoutPanel5.Controls.Add(lengthValue);
            flowLayoutPanel5.Controls.Add(widthValue);
            flowLayoutPanel5.Controls.Add(heightValue);
            flowLayoutPanel5.Controls.Add(materialValue);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(125, 1);
            flowLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 3, 0, 0);
            flowLayoutPanel5.Size = new Size(151, 297);
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
            cageValue.Location = new Point(5, 8);
            cageValue.Margin = new Padding(5);
            cageValue.Multiline = false;
            cageValue.Name = "cageValue";
            cageValue.Padding = new Padding(11, 9, 11, 9);
            cageValue.PasswordChar = false;
            cageValue.PlaceholderColor = Color.DarkGray;
            cageValue.PlaceholderText = "";
            cageValue.Size = new Size(137, 47);
            cageValue.TabIndex = 1;
            cageValue.Texts = "";
            cageValue.UnderlinedStyle = false;
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
            lengthValue.Location = new Point(5, 65);
            lengthValue.Margin = new Padding(5);
            lengthValue.Multiline = false;
            lengthValue.Name = "lengthValue";
            lengthValue.Padding = new Padding(11, 9, 11, 9);
            lengthValue.PasswordChar = false;
            lengthValue.PlaceholderColor = Color.DarkGray;
            lengthValue.PlaceholderText = "";
            lengthValue.Size = new Size(137, 47);
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
            widthValue.Location = new Point(5, 122);
            widthValue.Margin = new Padding(5);
            widthValue.Multiline = false;
            widthValue.Name = "widthValue";
            widthValue.Padding = new Padding(11, 9, 11, 9);
            widthValue.PasswordChar = false;
            widthValue.PlaceholderColor = Color.DarkGray;
            widthValue.PlaceholderText = "";
            widthValue.Size = new Size(137, 47);
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
            heightValue.Location = new Point(5, 179);
            heightValue.Margin = new Padding(5);
            heightValue.Multiline = false;
            heightValue.Name = "heightValue";
            heightValue.Padding = new Padding(11, 9, 11, 9);
            heightValue.PasswordChar = false;
            heightValue.PlaceholderColor = Color.DarkGray;
            heightValue.PlaceholderText = "";
            heightValue.Size = new Size(137, 47);
            heightValue.TabIndex = 5;
            heightValue.Texts = "";
            heightValue.UnderlinedStyle = false;
            // 
            // materialValue
            // 
            materialValue.DropDownStyle = ComboBoxStyle.DropDownList;
            materialValue.Enabled = false;
            materialValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialValue.FormattingEnabled = true;
            materialValue.Location = new Point(6, 235);
            materialValue.Margin = new Padding(6, 4, 3, 4);
            materialValue.Name = "materialValue";
            materialValue.Size = new Size(135, 40);
            materialValue.TabIndex = 4;
            // 
            // MoreDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 230, 200);
            Controls.Add(cagePanel);
            Controls.Add(birdPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MoreDetails";
            Size = new Size(1445, 815);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            offspringsPanel.ResumeLayout(false);
            offspringsPanel.PerformLayout();
            birdPanel.ResumeLayout(false);
            birdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPic).EndInit();
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
        private ListBox offspringList;
        public Panel offspringsPanel;
        public Label fledglingLabel;
        private FlowLayoutPanel flowLayoutPanel2;
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
        private RJControls.RJCircularPictureBox mainPic;
        private RJControls.RJTextBox cageValue;
        private RJControls.RJTextBox heightValue;
        private RJControls.RJTextBox widthValue;
        private RJControls.RJTextBox lengthValue;
        private RJControls.RJTextBox idLabel;
        private RJControls.RJTextBox genderLabel;
        private RJControls.RJTextBox cageIdLabel;
        private RJControls.RJTextBox dadIdLabel;
        private RJControls.RJTextBox momIdLabel;
        private ComboBox typeLabel;
        private ComboBox subTypeLabel;
        private ComboBox materialValue;
    }
}

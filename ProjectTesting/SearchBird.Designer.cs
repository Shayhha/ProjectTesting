namespace ProjectTesting
{
    partial class SearchBird
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
            birdList = new ListBox();
            LogOut_button = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            backButton = new Button();
            comboBox = new ComboBox();
            Cage_label = new Label();
            Bird_label = new Label();
            SuspendLayout();
            // 
            // birdList
            // 
            birdList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            birdList.FormattingEnabled = true;
            birdList.ItemHeight = 32;
            birdList.Items.AddRange(new object[] { "Bird Id: 93754 , Type: Something , Gender: Male , Cage id: 991A13 | click for more details", "Bird Id: 72721 , Type: Australian Gouldian, Gender: Female , Cage id: BE318R | click for more details" });
            birdList.Location = new Point(114, 222);
            birdList.Name = "birdList";
            birdList.Size = new Size(1073, 356);
            birdList.TabIndex = 0;
            // 
            // LogOut_button
            // 
            LogOut_button.BackColor = Color.IndianRed;
            LogOut_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogOut_button.ForeColor = Color.White;
            LogOut_button.Location = new Point(1127, 25);
            LogOut_button.Name = "LogOut_button";
            LogOut_button.Size = new Size(90, 40);
            LogOut_button.TabIndex = 1;
            LogOut_button.Text = "Log-out";
            LogOut_button.UseVisualStyleBackColor = false;
            LogOut_button.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(489, 95);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(350, 33);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 98);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 3;
            label1.Text = "Search: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 181);
            label2.Name = "label2";
            label2.Size = new Size(769, 20);
            label2.TabIndex = 4;
            label2.Text = "( search by bird id, type, sub-type, date of birth (dd/mm/yyyy) , gender (Male, Female), cage id, dad's id, mom's id )";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(59, 25);
            backButton.Name = "backButton";
            backButton.Size = new Size(90, 40);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Bird", "Cage" });
            comboBox.Location = new Point(584, 134);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(147, 23);
            comboBox.TabIndex = 6;
            // 
            // Cage_label
            // 
            Cage_label.AutoSize = true;
            Cage_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cage_label.Location = new Point(963, 35);
            Cage_label.Name = "Cage_label";
            Cage_label.Size = new Size(59, 20);
            Cage_label.TabIndex = 10;
            Cage_label.Text = "Cage: X";
            // 
            // Bird_label
            // 
            Bird_label.AutoSize = true;
            Bird_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Bird_label.Location = new Point(1034, 35);
            Bird_label.Name = "Bird_label";
            Bird_label.Size = new Size(57, 20);
            Bird_label.TabIndex = 9;
            Bird_label.Text = "Brids: Y";
            // 
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(Cage_label);
            Controls.Add(Bird_label);
            Controls.Add(comboBox);
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(LogOut_button);
            Controls.Add(birdList);
            Name = "SearchBird";
            Size = new Size(1280, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox birdList;
        private Button LogOut_button;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button backButton;
        private ComboBox comboBox;
        private Label Cage_label;
        private Label Bird_label;
    }
}

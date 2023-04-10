﻿namespace ProjectTesting
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            backButton = new Button();
            comboBox = new ComboBox();
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
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1127, 25);
            button1.Name = "button1";
            button1.Size = new Size(90, 40);
            button1.TabIndex = 1;
            button1.Text = "Log-out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(comboBox);
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(birdList);
            Name = "SearchBird";
            Size = new Size(1280, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox birdList;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button backButton;
        private ComboBox comboBox;
    }
}

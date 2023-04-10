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
            materialBox = new TextBox();
            heightBox = new TextBox();
            widthBox = new TextBox();
            lengthBox = new TextBox();
            idBox = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            cancelButton = new Button();
            addButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(388, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(505, 417);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(230, 50);
            label9.TabIndex = 1;
            label9.Text = "Add a Cage:";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialBox);
            panel1.Controls.Add(heightBox);
            panel1.Controls.Add(widthBox);
            panel1.Controls.Add(lengthBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 240);
            panel1.TabIndex = 0;
            // 
            // materialBox
            // 
            materialBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialBox.Location = new Point(150, 187);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(250, 33);
            materialBox.TabIndex = 25;
            // 
            // heightBox
            // 
            heightBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heightBox.Location = new Point(150, 147);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(250, 33);
            heightBox.TabIndex = 24;
            // 
            // widthBox
            // 
            widthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            widthBox.Location = new Point(150, 104);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(250, 33);
            widthBox.TabIndex = 23;
            // 
            // lengthBox
            // 
            lengthBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lengthBox.Location = new Point(150, 65);
            lengthBox.Name = "lengthBox";
            lengthBox.Size = new Size(250, 33);
            lengthBox.TabIndex = 22;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(150, 20);
            idBox.Name = "idBox";
            idBox.Size = new Size(250, 33);
            idBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(54, 195);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 18;
            label7.Text = "Material:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 14;
            label1.Text = "Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(67, 155);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 17;
            label8.Text = "Height:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 15;
            label2.Text = "Length:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 112);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 16;
            label3.Text = "Width:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(cancelButton);
            flowLayoutPanel2.Controls.Add(addButton);
            flowLayoutPanel2.Location = new Point(3, 299);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(337, 91);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(3, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 75);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(159, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 75);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // AddCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "AddCage";
            Size = new Size(1280, 720);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private Panel panel1;
        private TextBox materialBox;
        private TextBox heightBox;
        private TextBox widthBox;
        private TextBox lengthBox;
        private TextBox idBox;
        private Label label7;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button cancelButton;
        private Button addButton;
    }
}

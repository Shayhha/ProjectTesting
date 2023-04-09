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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "lol lmao" }, -1);
            listBox1 = new ListBox();
            button1 = new Button();
            listView1 = new ListView();
            Bird_Id = new ColumnHeader();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "something", "more things", "last thing" });
            listBox1.Location = new Point(93, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1172, 184);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1160, 29);
            button1.Name = "button1";
            button1.Size = new Size(90, 40);
            button1.TabIndex = 1;
            button1.Text = "Log-out";
            button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Bird_Id });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(110, 287);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 231);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SearchBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "SearchBird";
            Size = new Size(1280, 720);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Bird_Id;
    }
}

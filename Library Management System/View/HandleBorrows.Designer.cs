namespace Library_Management_System.View
{
    partial class HandleBorrows
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            back = new Button();
            newBorrow = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1554756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.84452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Location = new Point(51, 250);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(693, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Location = new Point(51, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(355, 232);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // back
            // 
            back.Location = new Point(51, 409);
            back.Name = "back";
            back.Size = new Size(106, 29);
            back.TabIndex = 2;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // newBorrow
            // 
            newBorrow.Location = new Point(632, 409);
            newBorrow.Name = "newBorrow";
            newBorrow.Size = new Size(112, 29);
            newBorrow.TabIndex = 3;
            newBorrow.Text = "New Borrow";
            newBorrow.UseVisualStyleBackColor = true;
            newBorrow.Click += newBorrow_Click;
            // 
            // HandleBorrows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newBorrow);
            Controls.Add(back);
            Controls.Add(listView1);
            Controls.Add(tableLayoutPanel1);
            Name = "HandleBorrows";
            Text = "HandleBorrows";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private Button back;
        private Button newBorrow;
    }
}
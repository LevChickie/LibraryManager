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
            borrowList = new ListView();
            back = new Button();
            newBorrow = new Button();
            SuspendLayout();
            // 
            // borrowList
            // 
            borrowList.Location = new Point(51, 12);
            borrowList.Name = "borrowList";
            borrowList.Size = new Size(693, 391);
            borrowList.TabIndex = 1;
            borrowList.UseCompatibleStateImageBehavior = false;
            borrowList.SelectedIndexChanged += borrowList_SelectedIndexChanged;
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
            Controls.Add(borrowList);
            Name = "HandleBorrows";
            Text = "HandleBorrows";
            ResumeLayout(false);
        }

        #endregion
        private ListView borrowList;
        private Button back;
        private Button newBorrow;
    }
}
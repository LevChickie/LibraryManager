namespace Library_Management_System.View
{
    partial class LibraryApp
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
            newBorrow = new Button();
            activeBorrows = new Button();
            searchLibrary = new Button();
            activeVisitors = new Button();
            addMewVisitor = new Button();
            addNewBook = new Button();
            SuspendLayout();
            // 
            // newBorrow
            // 
            newBorrow.Location = new Point(258, 147);
            newBorrow.Name = "newBorrow";
            newBorrow.Size = new Size(151, 37);
            newBorrow.TabIndex = 0;
            newBorrow.Text = "New Borrow";
            newBorrow.UseVisualStyleBackColor = true;
            newBorrow.Click += createNewBorrow;
            // 
            // activeBorrows
            // 
            activeBorrows.Location = new Point(258, 68);
            activeBorrows.Name = "activeBorrows";
            activeBorrows.Size = new Size(151, 36);
            activeBorrows.TabIndex = 1;
            activeBorrows.Text = "Active Borrows";
            activeBorrows.UseVisualStyleBackColor = true;
            activeBorrows.Click += openActiveBorrows;
            // 
            // searchLibrary
            // 
            searchLibrary.Location = new Point(44, 68);
            searchLibrary.Name = "searchLibrary";
            searchLibrary.Size = new Size(151, 36);
            searchLibrary.TabIndex = 2;
            searchLibrary.Text = "Search Library";
            searchLibrary.UseVisualStyleBackColor = true;
            searchLibrary.Click += searchLibraryBooks;
            // 
            // activeVisitors
            // 
            activeVisitors.Location = new Point(481, 147);
            activeVisitors.Name = "activeVisitors";
            activeVisitors.Size = new Size(127, 37);
            activeVisitors.TabIndex = 3;
            activeVisitors.Text = "Register Visitor";
            activeVisitors.UseVisualStyleBackColor = true;
            activeVisitors.Click += activeVisitors_Click;
            // 
            // addMewVisitor
            // 
            addMewVisitor.Location = new Point(481, 68);
            addMewVisitor.Name = "addMewVisitor";
            addMewVisitor.Size = new Size(127, 36);
            addMewVisitor.TabIndex = 4;
            addMewVisitor.Text = "Active Visitors";
            addMewVisitor.UseVisualStyleBackColor = true;
            addMewVisitor.Click += addMewVisitor_Click;
            // 
            // addNewBook
            // 
            addNewBook.Location = new Point(44, 147);
            addNewBook.Name = "addNewBook";
            addNewBook.Size = new Size(151, 37);
            addNewBook.TabIndex = 5;
            addNewBook.Text = "New Book";
            addNewBook.UseVisualStyleBackColor = true;
            addNewBook.Click += addNewBook_Click;
            // 
            // LibraryApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addNewBook);
            Controls.Add(addMewVisitor);
            Controls.Add(activeVisitors);
            Controls.Add(searchLibrary);
            Controls.Add(activeBorrows);
            Controls.Add(newBorrow);
            Name = "LibraryApp";
            Text = "LibraryApp";
            ResumeLayout(false);
        }

        #endregion

        private Button newBorrow;
        private Button activeBorrows;
        private Button searchLibrary;
        private Button activeVisitors;
        private Button addMewVisitor;
        private Button addNewBook;
    }
}
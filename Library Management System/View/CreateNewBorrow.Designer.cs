namespace Library_Management_System
{
    partial class CreateNewBorrow
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
            saveBorrows = new Button();
            durationOfBorrowLabel = new Label();
            panel1 = new Panel();
            addNewBook = new Button();
            borrowedBooksLabel = new Label();
            borrowedBooks = new ListView();
            visitorId = new TextBox();
            visitorIdLabel = new Label();
            lastName = new TextBox();
            lastNameLabel = new Label();
            firstName = new TextBox();
            firstNameLabel = new Label();
            durationOfBorrow = new TextBox();
            cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveBorrows
            // 
            saveBorrows.BackColor = SystemColors.Menu;
            saveBorrows.Location = new Point(345, 381);
            saveBorrows.Name = "saveBorrows";
            saveBorrows.Size = new Size(94, 29);
            saveBorrows.TabIndex = 0;
            saveBorrows.Text = "Save";
            saveBorrows.UseVisualStyleBackColor = false;
            saveBorrows.Click += saveBorrows_Click;
            // 
            // durationOfBorrowLabel
            // 
            durationOfBorrowLabel.AutoSize = true;
            durationOfBorrowLabel.Location = new Point(30, 235);
            durationOfBorrowLabel.Name = "durationOfBorrowLabel";
            durationOfBorrowLabel.Size = new Size(67, 20);
            durationOfBorrowLabel.TabIndex = 1;
            durationOfBorrowLabel.Text = "Duration";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(addNewBook);
            panel1.Controls.Add(borrowedBooksLabel);
            panel1.Controls.Add(borrowedBooks);
            panel1.Controls.Add(visitorId);
            panel1.Controls.Add(visitorIdLabel);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(firstName);
            panel1.Controls.Add(firstNameLabel);
            panel1.Controls.Add(durationOfBorrow);
            panel1.Controls.Add(durationOfBorrowLabel);
            panel1.Location = new Point(85, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 331);
            panel1.TabIndex = 2;
            // 
            // addNewBook
            // 
            addNewBook.Location = new Point(397, 285);
            addNewBook.Name = "addNewBook";
            addNewBook.Size = new Size(94, 29);
            addNewBook.TabIndex = 11;
            addNewBook.Text = "New Book";
            addNewBook.UseVisualStyleBackColor = true;
            addNewBook.Click += addNewBook_Click;
            // 
            // borrowedBooksLabel
            // 
            borrowedBooksLabel.AutoSize = true;
            borrowedBooksLabel.Location = new Point(387, 12);
            borrowedBooksLabel.Name = "borrowedBooksLabel";
            borrowedBooksLabel.Size = new Size(118, 20);
            borrowedBooksLabel.TabIndex = 10;
            borrowedBooksLabel.Text = "Borrowed Books";
            // 
            // borrowedBooks
            // 
            borrowedBooks.Location = new Point(359, 35);
            borrowedBooks.Name = "borrowedBooks";
            borrowedBooks.Size = new Size(166, 244);
            borrowedBooks.TabIndex = 9;
            borrowedBooks.UseCompatibleStateImageBehavior = false;
            // 
            // visitorId
            // 
            visitorId.Location = new Point(118, 195);
            visitorId.Name = "visitorId";
            visitorId.Size = new Size(125, 27);
            visitorId.TabIndex = 8;
            // 
            // visitorIdLabel
            // 
            visitorIdLabel.AutoSize = true;
            visitorIdLabel.Location = new Point(30, 198);
            visitorIdLabel.Name = "visitorIdLabel";
            visitorIdLabel.Size = new Size(24, 20);
            visitorIdLabel.TabIndex = 7;
            visitorIdLabel.Text = "ID";
            // 
            // lastName
            // 
            lastName.Location = new Point(118, 160);
            lastName.Name = "lastName";
            lastName.Size = new Size(125, 27);
            lastName.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(30, 163);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name";
            // 
            // firstName
            // 
            firstName.BackColor = SystemColors.HighlightText;
            firstName.Location = new Point(118, 127);
            firstName.Name = "firstName";
            firstName.Size = new Size(125, 27);
            firstName.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(30, 130);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // durationOfBorrow
            // 
            durationOfBorrow.Location = new Point(118, 232);
            durationOfBorrow.Name = "durationOfBorrow";
            durationOfBorrow.Size = new Size(125, 27);
            durationOfBorrow.TabIndex = 2;
            // 
            // cancel
            // 
            cancel.Location = new Point(115, 381);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 12;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // CreateNewBorrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel);
            Controls.Add(panel1);
            Controls.Add(saveBorrows);
            Name = "CreateNewBorrow";
            Text = "CreateNewBorrow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button saveBorrows;
        private Label durationOfBorrowLabel;
        private Panel panel1;
        private TextBox lastName;
        private Label lastNameLabel;
        private TextBox firstName;
        private Label firstNameLabel;
        private TextBox durationOfBorrow;
        private Label borrowedBooksLabel;
        private ListView borrowedBooks;
        private TextBox visitorId;
        private Label visitorIdLabel;
        private Button addNewBook;
        private Button cancel;
    }
}
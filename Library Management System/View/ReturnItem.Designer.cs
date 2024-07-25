namespace Library_Management_System.View
{
    partial class ReturnItem
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
            panel1 = new Panel();
            getBorrows = new Button();
            returnItems = new Button();
            borrowedBooksLabel = new Label();
            borrowedItems = new ListView();
            email = new TextBox();
            emailLabel = new Label();
            lastName = new TextBox();
            lastNameLabel = new Label();
            firstName = new TextBox();
            firstNameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(getBorrows);
            panel1.Controls.Add(returnItems);
            panel1.Controls.Add(borrowedBooksLabel);
            panel1.Controls.Add(borrowedItems);
            panel1.Controls.Add(email);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(firstName);
            panel1.Controls.Add(firstNameLabel);
            panel1.Location = new Point(110, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 350);
            panel1.TabIndex = 3;
            // 
            // getBorrows
            // 
            getBorrows.Location = new Point(155, 210);
            getBorrows.Name = "getBorrows";
            getBorrows.Size = new Size(110, 29);
            getBorrows.TabIndex = 8;
            getBorrows.Text = "Get Borrows";
            getBorrows.UseVisualStyleBackColor = true;
            getBorrows.Click += getBorrows_Click;
            // 
            // returnItems
            // 
            returnItems.Location = new Point(214, 299);
            returnItems.Name = "returnItems";
            returnItems.Size = new Size(163, 29);
            returnItems.TabIndex = 11;
            returnItems.Text = "Return chosen items";
            returnItems.UseVisualStyleBackColor = true;
            returnItems.Click += returnItems_Click;
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
            // borrowedItems
            // 
            borrowedItems.Location = new Point(359, 35);
            borrowedItems.Name = "borrowedItems";
            borrowedItems.Size = new Size(166, 244);
            borrowedItems.TabIndex = 9;
            borrowedItems.UseCompatibleStateImageBehavior = false;
            // 
            // email
            // 
            email.Location = new Point(118, 166);
            email.Name = "email";
            email.Size = new Size(235, 27);
            email.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(30, 169);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // lastName
            // 
            lastName.Location = new Point(118, 131);
            lastName.Name = "lastName";
            lastName.Size = new Size(235, 27);
            lastName.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(30, 134);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name";
            // 
            // firstName
            // 
            firstName.BackColor = SystemColors.HighlightText;
            firstName.Location = new Point(118, 98);
            firstName.Name = "firstName";
            firstName.Size = new Size(235, 27);
            firstName.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(30, 101);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // ReturnItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ReturnItem";
            Text = "ReturnItem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button returnItems;
        private Label borrowedBooksLabel;
        private ListView borrowedItems;
        private TextBox email;
        private Label emailLabel;
        private TextBox lastName;
        private Label lastNameLabel;
        private TextBox firstName;
        private Label firstNameLabel;
        private Button getBorrows;
    }
}
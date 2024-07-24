namespace Library_Management_System
{
    partial class SearchBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            back = new Button();
            bookSearchList = new ListView();
            search = new Button();
            label4 = new Label();
            authorName = new TextBox();
            titleText = new TextBox();
            label3 = new Label();
            genrePicker = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            addToBorrows = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(back);
            panel1.Controls.Add(bookSearchList);
            panel1.Controls.Add(search);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(authorName);
            panel1.Controls.Add(titleText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(genrePicker);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(77, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 345);
            panel1.TabIndex = 0;
            // 
            // back
            // 
            back.Location = new Point(40, 285);
            back.Name = "back";
            back.Size = new Size(94, 49);
            back.TabIndex = 9;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // bookSearchList
            // 
            bookSearchList.Location = new Point(366, 57);
            bookSearchList.Name = "bookSearchList";
            bookSearchList.Size = new Size(215, 222);
            bookSearchList.TabIndex = 8;
            bookSearchList.UseCompatibleStateImageBehavior = false;
            bookSearchList.SelectedIndexChanged += bookSearchList_SelectedIndexChanged;
            // 
            // search
            // 
            search.Location = new Point(166, 191);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 7;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 21);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 6;
            label4.Text = "Search for new book";
            // 
            // authorName
            // 
            authorName.Location = new Point(147, 101);
            authorName.Name = "authorName";
            authorName.Size = new Size(151, 27);
            authorName.TabIndex = 5;
            // 
            // titleText
            // 
            titleText.Location = new Point(147, 57);
            titleText.Name = "titleText";
            titleText.Size = new Size(151, 27);
            titleText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Genre";
            // 
            // genrePicker
            // 
            genrePicker.FormattingEnabled = true;
            genrePicker.Location = new Point(147, 141);
            genrePicker.Name = "genrePicker";
            genrePicker.Size = new Size(151, 28);
            genrePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 101);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // addToBorrows
            // 
            addToBorrows.Location = new Point(498, 322);
            addToBorrows.Name = "addToBorrows";
            addToBorrows.Size = new Size(94, 49);
            addToBorrows.TabIndex = 1;
            addToBorrows.Text = "Check book out";
            addToBorrows.UseVisualStyleBackColor = true;
            addToBorrows.Click += addToBorrows_Click;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(addToBorrows);
            Controls.Add(panel1);
            Name = "SearchBook";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox authorName;
        private TextBox titleText;
        private Label label3;
        private ComboBox genrePicker;
        private ListView bookSearchList;
        private Button search;
        private Button addToBorrows;
        private Button back;
    }
}

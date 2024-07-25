namespace Library_Management_System.View
{
    partial class AddNewBook
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
            label1 = new Label();
            label2 = new Label();
            middleNameLabel = new Label();
            birthdayDate = new Label();
            titleLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            middleNameText = new TextBox();
            AuthorTitle = new ComboBox();
            titleText = new TextBox();
            lastNameText = new TextBox();
            birthdayDatePicker = new DateTimePicker();
            genre = new ComboBox();
            label3 = new Label();
            firstNameText = new TextBox();
            label4 = new Label();
            pageCount = new TextBox();
            label5 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 107);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Author Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 107);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Book Information";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(48, 228);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(103, 20);
            middleNameLabel.TabIndex = 16;
            middleNameLabel.Text = "Middle Name:";
            // 
            // birthdayDate
            // 
            birthdayDate.AutoSize = true;
            birthdayDate.Location = new Point(48, 307);
            birthdayDate.Name = "birthdayDate";
            birthdayDate.Size = new Size(71, 20);
            birthdayDate.TabIndex = 15;
            birthdayDate.Text = "Birth day:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(48, 144);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(90, 20);
            titleLabel.TabIndex = 14;
            titleLabel.Text = "Author Title:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(48, 260);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(449, 145);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(41, 20);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "Title:";
            // 
            // middleNameText
            // 
            middleNameText.Location = new Point(175, 227);
            middleNameText.Name = "middleNameText";
            middleNameText.Size = new Size(250, 27);
            middleNameText.TabIndex = 21;
            // 
            // AuthorTitle
            // 
            AuthorTitle.FormattingEnabled = true;
            AuthorTitle.Location = new Point(175, 141);
            AuthorTitle.Name = "AuthorTitle";
            AuthorTitle.Size = new Size(250, 28);
            AuthorTitle.TabIndex = 20;
            // 
            // titleText
            // 
            titleText.Location = new Point(538, 141);
            titleText.Name = "titleText";
            titleText.Size = new Size(250, 27);
            titleText.TabIndex = 19;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(175, 260);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(250, 27);
            lastNameText.TabIndex = 18;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(175, 302);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(250, 27);
            birthdayDatePicker.TabIndex = 17;
            // 
            // genre
            // 
            genre.FormattingEnabled = true;
            genre.Location = new Point(538, 181);
            genre.Name = "genre";
            genre.Size = new Size(250, 28);
            genre.TabIndex = 23;
            genre.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 189);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 22;
            label3.Text = "Genre:";
            label3.Click += label3_Click;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(175, 186);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(250, 27);
            firstNameText.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 189);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 24;
            label4.Text = "First Name:";
            // 
            // pageCount
            // 
            pageCount.Location = new Point(538, 250);
            pageCount.Name = "pageCount";
            pageCount.Size = new Size(250, 27);
            pageCount.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 254);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 26;
            label5.Text = "Page Count:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(556, 373);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 28;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(187, 373);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 29;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 215);
            textBox1.Name = "publicationYear";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 219);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 30;
            label6.Text = "Publication:";
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(pageCount);
            Controls.Add(label5);
            Controls.Add(firstNameText);
            Controls.Add(label4);
            Controls.Add(genre);
            Controls.Add(label3);
            Controls.Add(middleNameText);
            Controls.Add(AuthorTitle);
            Controls.Add(titleText);
            Controls.Add(lastNameText);
            Controls.Add(birthdayDatePicker);
            Controls.Add(middleNameLabel);
            Controls.Add(birthdayDate);
            Controls.Add(titleLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewBook";
            Text = "AddNewBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label middleNameLabel;
        private Label birthdayDate;
        private Label titleLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox middleNameText;
        private ComboBox AuthorTitle;
        private TextBox titleText;
        private TextBox lastNameText;
        private DateTimePicker birthdayDatePicker;
        private ComboBox genre;
        private Label label3;
        private TextBox firstNameText;
        private Label label4;
        private TextBox pageCount;
        private Label label5;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox textBox1;
        private Label label6;
    }
}
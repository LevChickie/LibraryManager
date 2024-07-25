namespace Library_Management_System.View
{
    partial class AddNewDVD
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
            CancelButton = new Button();
            SaveButton = new Button();
            runtime = new TextBox();
            label5 = new Label();
            firstNameText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            middleNameText = new TextBox();
            AuthorTitle = new ComboBox();
            titleText = new TextBox();
            lastNameText = new TextBox();
            birthdayDatePicker = new DateTimePicker();
            middleNameLabel = new Label();
            birthdayDate = new Label();
            titleLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(169, 344);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 49;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(538, 344);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 48;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // pageCount
            // 
            runtime.Location = new Point(520, 199);
            runtime.Name = "runtime";
            runtime.Size = new Size(250, 27);
            runtime.TabIndex = 47;
            runtime.TextChanged += pageCount_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 203);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 46;
            label5.Text = "Runtime:";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(157, 157);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(250, 27);
            firstNameText.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 44;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 51;
            // 
            // middleNameText
            // 
            middleNameText.Location = new Point(157, 198);
            middleNameText.Name = "middleNameText";
            middleNameText.Size = new Size(250, 27);
            middleNameText.TabIndex = 41;
            // 
            // AuthorTitle
            // 
            AuthorTitle.FormattingEnabled = true;
            AuthorTitle.Location = new Point(157, 112);
            AuthorTitle.Name = "AuthorTitle";
            AuthorTitle.Size = new Size(250, 28);
            AuthorTitle.TabIndex = 40;
            // 
            // titleText
            // 
            titleText.Location = new Point(520, 112);
            titleText.Name = "titleText";
            titleText.Size = new Size(250, 27);
            titleText.TabIndex = 39;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(157, 231);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(250, 27);
            lastNameText.TabIndex = 38;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(157, 273);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(250, 27);
            birthdayDatePicker.TabIndex = 37;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(30, 199);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(103, 20);
            middleNameLabel.TabIndex = 36;
            middleNameLabel.Text = "Middle Name:";
            // 
            // birthdayDate
            // 
            birthdayDate.AutoSize = true;
            birthdayDate.Location = new Point(30, 278);
            birthdayDate.Name = "birthdayDate";
            birthdayDate.Size = new Size(71, 20);
            birthdayDate.TabIndex = 35;
            birthdayDate.Text = "Birth day:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(30, 115);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(90, 20);
            titleLabel.TabIndex = 34;
            titleLabel.Text = "Author Title:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(30, 231);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 33;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(431, 116);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(41, 20);
            firstNameLabel.TabIndex = 32;
            firstNameLabel.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 78);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 31;
            label2.Text = "DVD Information";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 78);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 30;
            label1.Text = "Author Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(520, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 156);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 52;
            label6.Text = "Publication:";
            // 
            // AddNewDVD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(runtime);
            Controls.Add(label5);
            Controls.Add(firstNameText);
            Controls.Add(label4);
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
            Name = "AddNewDVD";
            Text = "AddNewDVD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private TextBox runtime;
        private Label label5;
        private TextBox firstNameText;
        private Label label4;
        private Label label3;
        private TextBox middleNameText;
        private ComboBox AuthorTitle;
        private TextBox titleText;
        private TextBox lastNameText;
        private DateTimePicker birthdayDatePicker;
        private Label middleNameLabel;
        private Label birthdayDate;
        private Label titleLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
    }
}
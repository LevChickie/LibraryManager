namespace Library_Management_System.View
{
    partial class AddNewVisitor
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
            titleChooser = new ComboBox();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            birthdayDatePicker = new DateTimePicker();
            birthdayDate = new Label();
            titleLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            titlePage = new Label();
            cancelButton = new Button();
            saveNewVisitor = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(saveNewVisitor);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(titleChooser);
            panel1.Controls.Add(firstNameText);
            panel1.Controls.Add(lastNameText);
            panel1.Controls.Add(birthdayDatePicker);
            panel1.Controls.Add(birthdayDate);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(firstNameLabel);
            panel1.Controls.Add(titlePage);
            panel1.Location = new Point(90, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 383);
            panel1.TabIndex = 0;
            // 
            // titleChooser
            // 
            titleChooser.FormattingEnabled = true;
            titleChooser.Location = new Point(117, 67);
            titleChooser.Name = "titleChooser";
            titleChooser.Size = new Size(250, 28);
            titleChooser.TabIndex = 8;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(117, 101);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(250, 27);
            firstNameText.TabIndex = 7;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(117, 134);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(250, 27);
            lastNameText.TabIndex = 6;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(117, 176);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(250, 27);
            birthdayDatePicker.TabIndex = 5;
            // 
            // birthdayDate
            // 
            birthdayDate.AutoSize = true;
            birthdayDate.Location = new Point(25, 181);
            birthdayDate.Name = "birthdayDate";
            birthdayDate.Size = new Size(71, 20);
            birthdayDate.TabIndex = 4;
            birthdayDate.Text = "Birth day:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(25, 69);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(41, 20);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(25, 134);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(25, 100);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // titlePage
            // 
            titlePage.AutoSize = true;
            titlePage.Location = new Point(25, 16);
            titlePage.Name = "titlePage";
            titlePage.Size = new Size(114, 20);
            titlePage.TabIndex = 0;
            titlePage.Text = "Add new Visitor";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(50, 315);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveNewVisitor
            // 
            saveNewVisitor.Location = new Point(469, 315);
            saveNewVisitor.Name = "saveNewVisitor";
            saveNewVisitor.Size = new Size(94, 29);
            saveNewVisitor.TabIndex = 10;
            saveNewVisitor.Text = "Save";
            saveNewVisitor.UseVisualStyleBackColor = true;
            saveNewVisitor.Click += saveNewVisitor_Click;
            // 
            // AddNewVisitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AddNewVisitor";
            Text = "AddNewVisitor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titlePage;
        private Label birthdayDate;
        private Label titleLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private ComboBox titleChooser;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private DateTimePicker birthdayDatePicker;
        private Button saveNewVisitor;
        private Button cancelButton;
    }
}
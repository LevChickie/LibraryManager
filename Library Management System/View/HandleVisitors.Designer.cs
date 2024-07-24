namespace Library_Management_System.View
{
    partial class HandleVisitors
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
            visitorListView = new ListView();
            Back = new Button();
            addNewVisitor = new Button();
            SuspendLayout();
            // 
            // visitorListView
            // 
            visitorListView.Location = new Point(87, 36);
            visitorListView.Name = "visitorListView";
            visitorListView.Size = new Size(610, 275);
            visitorListView.TabIndex = 0;
            visitorListView.UseCompatibleStateImageBehavior = false;
            visitorListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Back
            // 
            Back.Location = new Point(89, 379);
            Back.Name = "Back";
            Back.Size = new Size(94, 29);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // addNewVisitor
            // 
            addNewVisitor.Location = new Point(292, 379);
            addNewVisitor.Name = "addNewVisitor";
            addNewVisitor.Size = new Size(94, 29);
            addNewVisitor.TabIndex = 2;
            addNewVisitor.Text = "New Visitor";
            addNewVisitor.UseVisualStyleBackColor = true;
            addNewVisitor.Click += addNewVisitor_Click;
            // 
            // HandleVisitors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addNewVisitor);
            Controls.Add(Back);
            Controls.Add(visitorListView);
            Name = "HandleVisitors";
            Text = "HandleVisitors";
            ResumeLayout(false);
        }

        #endregion

        private ListView visitorListView;
        private Button Back;
        private Button addNewVisitor;
    }
}
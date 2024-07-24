using Library_Management_System.Controller;
using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.View
{
    public partial class AddNewVisitor : Form
    {
        private Form navigateNext;

        private LibraryController libraryController;
        public AddNewVisitor(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
            this.titleChooser.Items.Add("Mr.");
            this.titleChooser.Items.Add("Mrs.");
            this.titleChooser.Items.Add("Diverse");

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void saveNewVisitor_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.FirstName = this.firstNameText.Text;
            visitor.MiddleName = this.middleNameText.Text;
            visitor.LastName = this.lastNameText.Text;
            visitor.Birthday = this.birthdayDatePicker.Value;
            visitor.Title = this.titleChooser.Text;
            visitor.VisitorId = Guid.NewGuid();
            Console.Write("Created New Visitor");
            libraryController.AddNewVisitor(visitor);
            navigateNext = new HandleVisitors(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void middleNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

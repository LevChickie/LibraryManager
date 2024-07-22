using Library_Management_System.Controller;
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
        private LibraryController libraryController;
        public AddNewVisitor(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void saveNewVisitor_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.FirstName = this.firstNameText.Text;
            visitor.LastName = this.lastNameText.Text;
            visitor.Birthday = this.birthdayDatePicker.Value;
            visitor.Title = this.titleChooser.Text;
            
            libraryController.AddNewVisitor(visitor);
            
        }
    }
}

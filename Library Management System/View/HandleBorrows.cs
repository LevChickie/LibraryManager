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
    public partial class HandleBorrows : Form
    {
        private Form navigateNext;
        private LibraryController libraryController;

        public HandleBorrows(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
            this.borrowList.View = System.Windows.Forms.View.Details;
            this.borrowList.Columns.Add("Borrower First Name");
            this.borrowList.Columns.Add("Borrower Middle Name");
            this.borrowList.Columns.Add("Borrower Last Name");
            this.borrowList.Columns.Add("Book title");
            this.borrowList.Columns.Add("Author");
            this.borrowList.Columns.Add("Deadline");
            //string[] borrowedInformation;
            List<string> borrowedInformation = new List<string>();
            foreach (Visitor visitor in libraryController.GetVisitors())
            {
                foreach(Borrowable borrowedItem in visitor.BorrowConnectedToVisitor)
                {
                    borrowedInformation = visitor.GetString().ToList();
                    borrowedInformation.AddRange(borrowedItem.GetString(true).ToList());
                    this.borrowList.Items.Add(new ListViewItem(borrowedInformation.ToArray()));
                }
            }
            
        }

        private void newBorrow_Click(object sender, EventArgs e)
        {
            navigateNext = new CreateNewBorrow(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void borrowList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

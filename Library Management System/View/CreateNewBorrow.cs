using Library_Management_System.Controller;
using Library_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class CreateNewBorrow : Form
    {
        private Form navigateNext;
        private LibraryController libraryController;
        private List<Borrowable> items;
        public CreateNewBorrow(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
        }
        public CreateNewBorrow(LibraryController libraryController, List<Borrowable> items)
        {
            InitializeComponent();
            this.libraryController = libraryController;
            this.items = items;

            this.borrowedBooks.View = System.Windows.Forms.View.Details;
            this.borrowedBooks.Columns.Add("Title");
            this.borrowedBooks.Columns.Add("Author");

            foreach (Book book in items)
            {
                this.borrowedBooks.Items.Add(new ListViewItem(book.GetString()));
            }
        }
        private void addNewBook_Click(object sender, EventArgs e)
        {
            navigateNext = new SearchBook(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void saveBorrows_Click(object sender, EventArgs e)
        {
            BorrowDetails newBorrow = new BorrowDetails();
            newBorrow.Start = DateTime.Now;
            newBorrow.Extension = false;
            newBorrow.Deadline = newBorrow.Start;
            newBorrow.Deadline = newBorrow.Start.AddMonths(Int32.Parse(this.durationOfBorrow.Text));
            bool visitorExists = false;
            foreach (Visitor visitor in libraryController.GetVisitors())
            {
                if (visitor.FirstName == this.firstName.Text && visitor.LastName == this.lastName.Text /*&& visitor.Birthday.Equals(this.birthdayPicker)*/)
                {
                    newBorrow.BorrowedBy = visitor;
                    visitorExists = true;
                    break;
                }
            }
            if (!visitorExists)
            {
                Console.WriteLine("Visitor not registered in this library");

            }
            if (this.borrowedBooks.SelectedItems.Count > 0)
            {
                newBorrow.BorrowedItems = items;
            }
            else
            {
                Console.WriteLine("No item selected. Please select an item to borrow");
                return;
            }
            libraryController.AddNewBorrow(newBorrow);

            navigateNext = new HandleBorrows(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

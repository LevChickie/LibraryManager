using Library_Management_System.Controller;
using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.View
{
    public partial class ReturnItem : Form
    {
        private Visitor visitorReturned;
        private Form navigateNext;
        private LibraryController libraryController;

        public ReturnItem(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
        }

        private void getBorrows_Click(object sender, EventArgs e)
        {
            visitorReturned = libraryController.GetVisitors().Find(visitor => visitor.FirstName == this.firstName.Text && visitor.LastName == this.lastName.Text);
            if (visitorReturned != null)
            {
                List<Borrowable> borrowedItemsByVisitor = new List<Borrowable>();
                visitorReturned.BorrowConnectedToVisitor.ForEach(borrow => borrowedItemsByVisitor.AddRange(borrow.BorrowedItems));
                this.borrowedItems.Clear();
                this.borrowedItems.View = System.Windows.Forms.View.Details;
                this.borrowedItems.Columns.Add("Title");
                this.borrowedItems.Columns.Add("Author");
                //this.borrowedBooks.Columns.Add("Deadline");
                foreach (Borrowable item in borrowedItemsByVisitor)
                {
                    this.borrowedItems.Items.Add(new ListViewItem(item.GetString()));
                }
            }
            Debug.WriteLine("Debug");
        }

        private void returnItems_Click(object sender, EventArgs e)
        {
            List<Borrowable> itemsReturned = new List<Borrowable>();
            if (this.borrowedItems.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in this.borrowedItems.SelectedItems)
                {
                    itemsReturned.Add(libraryController.GetBookByTitle(item.SubItems[0].Text));
                }
                if(visitorReturned!= null)
                {
                    libraryController.ReturnBorrowedItems(visitorReturned, itemsReturned);
                }
            }
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

using Library_Management_System.Controller;
using Library_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            foreach (Borrowable item in items)
            {
                this.borrowedBooks.Items.Add(new ListViewItem(item.GetString()));
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
            foreach(Borrowable item in items)
            {
                item.Start = DateTime.Now;
                if (Regex.IsMatch(this.durationOfBorrow.Text, @"^\d+$"))
                {
                    item.Deadline = item.Start.AddMonths(Int32.Parse(this.durationOfBorrow.Text));
                }
                else
                {
                    item.Deadline = item.Start.AddMonths(2);
                }
                item.Extension = false;
            }
            bool visitorExists = false;
            foreach (Visitor visitor in libraryController.GetVisitors())
            {
                if (visitor.FirstName == this.firstName.Text && visitor.LastName == this.lastName.Text)
                {
                    
                    visitorExists = true;
                    break;
                }
            }
            Visitor borrowingVisitor = libraryController.GetVisitors().Find(visitor => visitor.FirstName == this.firstName.Text && visitor.LastName == this.lastName.Text);
            if (borrowingVisitor != null)
            {
                items = libraryController.AvailableItems(items, borrowingVisitor);
                Debug.WriteLine($"Visitor {this.lastName.Text} took {items.Count} items");
                libraryController.AddNewBorrow(items, borrowingVisitor); 
            }
            else
            { 
                Debug.WriteLine("Visitor not registered in this library");
                return;
            }
            navigateNext = new HandleBorrows(libraryController);
            navigateNext.Show();
            this.Hide();
        }
        
    }
}

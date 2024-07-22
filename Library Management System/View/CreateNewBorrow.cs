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
        public CreateNewBorrow(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
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
            navigateNext = new HandleBorrows(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

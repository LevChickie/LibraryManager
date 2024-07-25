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
    public partial class LibraryApp : Form
    {
        private Form navigateNext;
        private LibraryController libraryController;
        public LibraryApp(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
        }

        private void createNewBorrow(object sender, EventArgs e)
        {
            navigateNext = new CreateNewBorrow(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void closeForm()
        {
            this.Close();
        }

        private void openActiveBorrows(object sender, EventArgs e)
        {
            navigateNext = new HandleBorrows(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void searchLibraryBooks(object sender, EventArgs e)
        {
            navigateNext = new SearchBook(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void returnItems_Click(object sender, EventArgs e)
        {
            navigateNext = new ReturnItem(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            navigateNext = new AddNewBook(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void activeVisitors_Click(object sender, EventArgs e)
        {
            navigateNext = new HandleVisitors(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

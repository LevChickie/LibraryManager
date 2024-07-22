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
    }
}

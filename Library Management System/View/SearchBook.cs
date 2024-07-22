using Library_Management_System.Controller;
using Library_Management_System.View;

namespace Library_Management_System
{
    public partial class SearchBook : Form
    {
        private Form navigateNext;
        private LibraryController libraryController;
        public SearchBook(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void addToBorrows_Click(object sender, EventArgs e)
        {
            navigateNext = new CreateNewBorrow(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

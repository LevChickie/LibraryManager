using Library_Management_System.Controller;
using Library_Management_System.Model;
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
            this.genrePicker.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void back_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void addToBorrows_Click(object sender, EventArgs e)
        {
            List<Borrowable> items = new List<Borrowable>();
            if (this.itemSearchList.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in  this.itemSearchList.SelectedItems)
                {
                    items.Add(libraryController.GetBookByTitle(item.SubItems[0].Text));
                }
            }

            navigateNext = new CreateNewBorrow(libraryController, items);
            navigateNext.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.itemSearchList.Clear();
            this.itemSearchList.View = System.Windows.Forms.View.Details;
            this.itemSearchList.Columns.Add("Title");
            this.itemSearchList.Columns.Add("Author");

            if (this.titleText.Text != "")
            {
                foreach (Book book in libraryController.GetBooks().FindAll(b => b.Title == this.titleText.Text))
                {
                    this.itemSearchList.Items.Add(new ListViewItem(book.GetString()));
                }
            }
            if (this.authorName.Text != "")
            {
                foreach (Book book in libraryController.GetBooks().FindAll(b => this.authorName.Text.Contains(b.Author.FirstName) || this.authorName.Text.Contains(b.Author.LastName)))
                {
                    this.itemSearchList.Items.Add(new ListViewItem(book.GetString()));
                }
            }
        }

        private void bookSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

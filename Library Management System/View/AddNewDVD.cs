using Library_Management_System.Controller;
using Library_Management_System.Model;
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
    public partial class AddNewDVD : Form
    {
        private Form navigateNext;

        private LibraryController libraryController;

        public AddNewDVD(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;
            this.AuthorTitle.Items.Add("Mr.");
            this.AuthorTitle.Items.Add("Mrs.");
            this.AuthorTitle.Items.Add("Diverse");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pageCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            DVD dvd = new DVD();

            author.FirstName = this.firstNameText.Text;
            author.MiddleName = this.middleNameText.Text;
            author.LastName = this.lastNameText.Text;
            author.Title = this.AuthorTitle.Text;
            author.AuthorId = Guid.NewGuid();
            author.Birthday = this.birthdayDatePicker.Value;

            bool authorFound = false;
            foreach (Author authorInLibrary in libraryController.GetAuthors())
            {
                if (authorInLibrary.FirstName == author.FirstName && authorInLibrary.LastName == author.LastName)
                {
                    author = authorInLibrary;
                    authorFound = true;
                    break;
                }
            }
            if (!authorFound)
            {
                libraryController.AddNewAuthor(author);
            }
            dvd.Author = author;
            dvd.IsAvailable = true;
            dvd.Title = this.titleText.Text;
            dvd.Runtime = Int32.Parse(this.runtime.Text);
            //book.Genre = this.genre.
            libraryController.AddNewItem(dvd);
            navigateNext = new SearchBook(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

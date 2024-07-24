using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Controller
{
    public class LibraryController
    {

        private Library library;
        public LibraryController()
        {
            library = new Library();
        }
        public void AddNewVisitor(Visitor visitor)
        {
            library.AddNewVisitor(visitor);
        }

        public void AddNewBorrow(BorrowDetails borrow)
        {
            library.AddNewBorrow(borrow);
        }

        public List<BorrowDetails> GetBorrowDetails()
        {
            return library.BorrowList;
        }

        public List<Visitor> GetVisitors()
        {
            return library.VisitorList;
        }

        public List<Author> GetAuthors()
        {
            return library.AuthorList;
        }

        public void AddNewAuthor (Author author)
        {
            library.AuthorList.Add(author);
        }

        public List<Book> GetBooks()
        {
            return library.BookList;
        }

        public Book GetBookByTitle(string title)
        {
            return library.GetBookByTitle(title);
        }
        public void AddNewBook(Book book)
        {
            library.BookList.Add(book);
        }
    }
}

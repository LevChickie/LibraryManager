using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        List<Author> authorList;
        public List<Author> AuthorList { get { return authorList; } set { authorList = value; } }
        List<Visitor> visitorList;
        public List<Visitor> VisitorList { get { return visitorList; } set { visitorList = value; } }
        List<Book> storedBooks;
        public List<Book> BookList { get { return storedBooks; } set { storedBooks = value; } }
        List<BorrowDetails> borrowList;
        public List<BorrowDetails> BorrowList { get { return borrowList; } set { borrowList = value; } }

        public Library()
        {
            authorList = new List<Author>();
            visitorList = new List<Visitor>();
            storedBooks = new List<Book>();
            borrowList = new List<BorrowDetails>();
        }
        public void AddNewAuthor()
        {

        }
        public void AddNewVisitor(Visitor visitor)
        {
            visitorList.Add(visitor);
            Console.Write("Size of Visitors: " + visitorList.Count);
        }
        public void RemoveVisitor()
        {

        }
        public void AddNewBook()
        {

        }
        public void AddNewBorrow()
        {

        }
    }
}

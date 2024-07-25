using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System.Controller
{
    public class LibraryController
    {
        private WaitListController waitListController;


        private Library library;
        public LibraryController()
        {
            library = new Library();
            waitListController = new WaitListController();

        }
        public void AddNewVisitor(Visitor visitor)
        {
            library.AddNewVisitor(visitor);
        }

        public void AddNewBorrow(BorrowDetails borrow)
        {
            library.AddNewBorrow(borrow);
        }

        public void ReturnBorrowedItems(Visitor visitor, List<Borrowable> items) {
            //To HashSet due to unique Guid Id could reduce the complexity from O (j * k * l) to O (k * l)
            HashSet<Guid> returnedItemIds = new HashSet<Guid>(items.Select(item => item.Id));
            foreach (BorrowDetails borrowDetail in visitor.BorrowConnectedToVisitor)
            {
                var itemsToRemove = new List<Borrowable>();
                foreach (Borrowable item in borrowDetail.BorrowedItems)
                {
                    if (returnedItemIds.Contains(item.Id))
                    {
                        //notify observers
                        item.IsAvailable = true;
                        itemsToRemove.Add(item);
                    }
                }
                foreach (Borrowable item in itemsToRemove)
                {
                    borrowDetail.BorrowedItems.Remove(item);
                }
                borrowDetail.BorrowedItems.RemoveAll(item => returnedItemIds.Contains(item.Id));
            }
            visitor.BorrowConnectedToVisitor.RemoveAll(borrows => borrows.BorrowedItems.Count == 0);

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
        public bool ItemAvailable(Borrowable borrowable)
        {
            return library.ItemAvailable(borrowable);
        }

        public List<Borrowable> AvailableItems(List<Borrowable> itemsToBorrow, Visitor visitor)
        {
            List<Borrowable> availableItems = new List<Borrowable>();
            SortedDictionary<Borrowable, bool> evaluatedItems = library.AvailableItems(itemsToBorrow);
            foreach (Borrowable borrowable in itemsToBorrow)
            {
                if(evaluatedItems[borrowable])
                {
                    availableItems.Add(borrowable);
                }
                else
                {
                    waitListController.SetWaitlistItem(borrowable, visitor);
                }
            }
            return availableItems;
        }
    }
}

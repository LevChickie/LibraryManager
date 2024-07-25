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

        public void AddNewBorrow(Borrowable borrowedItem, Visitor visitor)
        {
            library.AddNewBorrow(borrowedItem, visitor);
        }
        public void AddNewBorrow(List<Borrowable> borrowedItems, Visitor visitor)
        {
            library.AddNewBorrow(borrowedItems, visitor);
        }
        public void AddNewItem(Borrowable item)
        {
            library.StoredItemsList.Add(item);
        }
        public void ReturnBorrowedItems(Visitor visitor, List<Borrowable> items) {
            //To HashSet due to unique Guid Id could reduce the complexity from O (j * k * l) to O (k * l)
            HashSet<Guid> returnedItemIds = new HashSet<Guid>(items.Select(item => item.Id));
            foreach (Borrowable item in visitor.BorrowConnectedToVisitor)
            {
                if (returnedItemIds.Contains(item.Id))
                {
                    //notify observers
                    item.IsAvailable = true;
                }
                
            }
            visitor.BorrowConnectedToVisitor.RemoveAll(borrowedItem => returnedItemIds.Contains(borrowedItem.Id));
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

        public List<Borrowable> GetItems()
        {
            return library.StoredItemsList;
        }
        public List<Book> GetBooks()
        {
            return library.StoredItemsList.Where(item => item.Type == BorrowableTypes.Book).ToList().Cast<Book>().ToList();
        }
        public Borrowable GetItemByTitle(string title)
        {
            return library.GetBorrowableByTitle(title);
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

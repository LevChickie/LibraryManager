using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Controller;

namespace Library_Management_System.Model
{
    public class Library
    {

        private List<Author> authorList;
        public List<Author> AuthorList { get { return authorList; } set { authorList = value; } }
        private List<Visitor> visitorList;
        public List<Visitor> VisitorList { get { return visitorList; } set { visitorList = value; } }
        private List<Borrowable> storedItems;
        public List<Borrowable> StoredItemsList { get { return storedItems; } set { storedItems = value; } }


        private List<BorrowDetails> borrowList;
        public List<BorrowDetails> BorrowList { get { return borrowList; } set { borrowList = value; } }

        public Library()
        {
            authorList = new List<Author>();
            visitorList = new List<Visitor>();
            storedItems = new List<Borrowable>();
            borrowList = new List<BorrowDetails>();
        }
        public void AddNewVisitor(Visitor visitor)
        {
            visitorList.Add(visitor);
            Console.Write("Size of Visitors: " + visitorList.Count);
        }
        public void AddNewItem(Borrowable borrowableItem)
        {
            storedItems.Add(borrowableItem);
        }

        public Borrowable GetBorrowableByTitle(string title)
        {
            return StoredItemsList.Find(x => x.Title == title);
        }
        

        public void AddNewBorrow(Borrowable borrowedItem, Visitor borrowedBy)
        {
            VisitorList.Find(person => person.VisitorId == borrowedBy.VisitorId).BorrowConnectedToVisitor.Add(borrowedItem);
        }

        public void AddNewBorrow(List<Borrowable> borrowedItems, Visitor borrowedBy)
        {
            VisitorList.Find(person => person.VisitorId == borrowedBy.VisitorId).BorrowConnectedToVisitor.AddRange(borrowedItems);
        }
        public bool ItemAvailable(Borrowable item)
        {
            if (StoredItemsList == null)
            {
                Console.WriteLine("No available items");
                return false;
            }
            return StoredItemsList.Find(x => x == item).IsAvailable;
        }
        public SortedDictionary<Borrowable, bool> AvailableItems(List<Borrowable> itemsToBorrow)
        {
            SortedDictionary<Borrowable, bool> availableItems = new SortedDictionary<Borrowable, bool>();
            foreach (Borrowable item in itemsToBorrow)
            {
                if (item.IsAvailable)
                {
                    item.IsAvailable = false;
                    availableItems.Add(item, true);
                }
                else
                {
                    availableItems.Add(item, false);
                }
            }
            return availableItems;
        }
    }
}

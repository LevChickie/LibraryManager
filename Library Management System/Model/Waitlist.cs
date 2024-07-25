using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    internal class Waitlist : IWaitListObserver
    {
        private Queue<Visitor> visitorsWaitingForItem;
        public Queue<Visitor> VisitorsWaitingForItem
        {
            get { return visitorsWaitingForItem; }
            set { visitorsWaitingForItem = value; }
        }

        private Borrowable item;

        public Borrowable Item
        {
            get { return item; }
            set { 
                item = value;
            }
        }

        public Waitlist(Borrowable item, Visitor visitor)
        {
            visitorsWaitingForItem = new Queue<Visitor>();
            visitorsWaitingForItem.Enqueue(visitor);

            this.item = item;
            this.item.Attach(this);

        }

        public void Update(Borrowable waitedItem)
        {
            if (item.IsAvailable && visitorsWaitingForItem.Count > 0)
            {
                Visitor nextVisitor = visitorsWaitingForItem.Dequeue();
                // Notify the next visitor
                // For example, send an email or a notification
                Debug.WriteLine($"Visitor {nextVisitor.FirstName} {nextVisitor.LastName} is notified that the item {item.Title} is available.");
            }

        }
    }
}

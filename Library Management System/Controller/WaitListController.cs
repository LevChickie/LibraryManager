using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Controller
{
    internal class WaitListController
    {
        private List<Waitlist> waitlists;
        public WaitListController()
        {
            waitlists = new List<Waitlist>();
        }

        public void SetWaitlistItem(Borrowable waitlistItem, Visitor visitor)
        {
            foreach (Waitlist waitlist in waitlists) {
                if (waitlist.Item == waitlistItem)
                {
                    waitlist.VisitorsWaitingForItem.Enqueue(visitor);
                    Debug.WriteLine($"Visitor {visitor.FirstName} {visitor.LastName} will be notified once {waitlistItem.Title} is returned");
                    return;
                }
            }
 
            Waitlist waitlistForItem = new Waitlist(waitlistItem, visitor);
            waitlists.Add(waitlistForItem);
            Debug.WriteLine($"Visitor {visitor.FirstName} {visitor.LastName} will be notified once {waitlistItem.Title} is returned");

        }

    }
}

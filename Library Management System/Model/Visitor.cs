using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System
{
    public class Visitor : Person
    {
        private int visitorId;
        public int VisitorId
        {
            get { return visitorId; }
            set { visitorId = value; }
        }
        private DateTime subscribedUntil;
        public DateTime SubscribedUntil
        {
            get { return subscribedUntil; }
            set {  subscribedUntil = value; }
        }
        private List<BorrowDetails> borrowConnectedToVisitor;
        public List<BorrowDetails> BorrowConnectedToVisitor
        {
            get { return borrowConnectedToVisitor; }
            set { borrowConnectedToVisitor = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;

namespace Library_Management_System
{
    public class Visitor : Person
    {
        private Guid visitorId;
        public Guid VisitorId
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
        private List<Borrowable> borrowedItems = new List<Borrowable>();
        public List<Borrowable> BorrowConnectedToVisitor
        {
            get { return borrowedItems; }
            set { borrowedItems = value; }
        }
        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public string[] GetString()
        {
            string[] resultString = new string[4];
            resultString[0] = FirstName;
            resultString[1] = MiddleName;
            resultString[2] = LastName;
            resultString[3] = VisitorId.ToString();
            //resultString[4] = subscribedUntil.ToString(new CultureInfo("de-DE"));
            //resultString[5] = BorrowConnectedToVisitor.Count.ToString();

            return resultString;
        }
    }
}

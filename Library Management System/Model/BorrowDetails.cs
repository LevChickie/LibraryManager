using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BorrowDetails
    {
        private DateTime start;
        public DateTime Start { get { return start; }
            set { start = value; }
        }
        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        private bool extension;
        public bool Extension { get { return extension; } set {  extension = value; } }

        private Visitor borrowedBy;
        public Visitor BorrowedBy
        {
            get { return borrowedBy; }
            set { borrowedBy = value; }
        }

        private List<Borrowable> borrowedItems;
        public List<Borrowable> BorrowedItems
        {
            get { return borrowedItems; }
            set { borrowedItems = value; }
        }
        public string[] GetString()
        {
            string[] resultString = new string[5];
            resultString[0] = borrowedBy.FirstName;
            resultString[1] = borrowedBy.LastName;
            resultString[2] = start.ToString(new CultureInfo("de-DE"));
            resultString[3] = deadline.ToString(new CultureInfo("de-DE"));
            resultString[4] = extension.ToString();

            return resultString;
        }
    }
}

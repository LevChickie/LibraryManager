using System;
using System.Collections.Generic;
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
    }
}

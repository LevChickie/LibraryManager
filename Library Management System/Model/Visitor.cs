using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Visitor : Person
    {
        private int visitorId;
        private DateTime subscribedUntil;
        private List<BorrowDetails> borrowConnectedToVisitor;
    }
}

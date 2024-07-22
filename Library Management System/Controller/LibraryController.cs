using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Controller
{
    public class LibraryController
    {

        private Library library;
        public LibraryController()
        {
            library = new Library();
        }
        public void AddNewVisitor(Visitor visitor)
        {
            library.AddNewVisitor(visitor);
        }
    }
}

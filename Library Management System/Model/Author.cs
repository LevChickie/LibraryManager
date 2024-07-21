using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Author : Person
    {
        private int authorId;
        private List<Genre> typicalGenres;
        private List<Book> books;
    }
}

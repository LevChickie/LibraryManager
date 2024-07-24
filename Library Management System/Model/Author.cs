using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management_System
{
    public class Author : Person
    {

        private Guid authorId;
        public Guid AuthorId
        {
            get { return authorId; }
            set
            {
                if (authorId != value)
                {
                    authorId = value;
                    //OnPropertyChanged("Data");
                }
            }
        }
        private List<Genre> typicalGenres;
        public List<Genre> TypicalGenres
        {
            get { return typicalGenres; }
            set
            {
                if (typicalGenres != value)
                {
                    typicalGenres = value;
                    //OnPropertyChanged("Data");
                }
            }
        }
        private List<Book> books;
        public List<Book> Books
        {
            get { return books; }
            set
            {
                if (books != value)
                {
                    books = value;
                    //OnPropertyChanged("Data");
                }
            }
        }
    }
}

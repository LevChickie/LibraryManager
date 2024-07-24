using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public class Book : Borrowable
    {
        private Author author;
        public Author Author { get { return author; } set {
                if (author != value)
                {
                    author = value;
                    //OnPropertyChanged("Data");
                }
            } }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    //OnPropertyChanged("Data");
                }
            }
        }
        private Genre genre;
        public Genre Genre
        {
            get { return genre; }
            set
            {
                if (genre != value)
                {
                    genre = value;
                    //OnPropertyChanged("Data");
                }
            }
        }

        private int pageCount;
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (pageCount != value)
                {
                    pageCount = value;
                    //OnPropertyChanged("Data");
                }
            }
        }

        public string[] GetString()
        {
            string[] resultString = new string[2];
            resultString[0] = Title;
            resultString[1] = Author.FirstName + " " + Author.LastName;
            //resultString[4] = subscribedUntil.ToString(new CultureInfo("de-DE"));
            //resultString[5] = BorrowConnectedToVisitor.Count.ToString();

            return resultString;
        }
    }
}

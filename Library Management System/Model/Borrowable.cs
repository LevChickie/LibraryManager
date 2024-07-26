using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Borrowable : IComparable<Borrowable>
    {
        private List<IWaitListObserver> waitlistObservers = new List<IWaitListObserver>();
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        private bool isAvailable;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set
            {
                if (isAvailable != value)
                {
                    Debug.WriteLine($"Availability for {Title} changed");
                    isAvailable = value;
                    NotifyObservers();
                }
            }
        }
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
        private int publicationYear;
        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }
        private Author author;
        public Author Author
        {
            get { return author; }
            set
            {
                if (author != value)
                {
                    author = value;
                    //OnPropertyChanged("Data");
                }
            }
        }

        private BorrowableTypes type;

        public BorrowableTypes Type
        {
            get { return type; }
            set { type = value; }
        }

        private DateTime start;
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        private bool extension;
        public bool Extension { get { return extension; } set { extension = value; } }

        public void Attach(IWaitListObserver observer)
        {
            waitlistObservers.Add(observer);
        }
        public void Detach(IWaitListObserver observer)
        {
            waitlistObservers.Remove(observer);
        }
        private void NotifyObservers()
        {
            foreach (var observer in waitlistObservers)
            {
                observer.Update(this);
            }
        }
        public string[] GetString()
        {
            string[] resultString = new string[2];
            resultString[0] = Title;
            resultString[1] = Author.FirstName + " " + Author.LastName;


            return resultString;
        }
        public string[] GetString(bool representDeadline)
        {
            string[] resultString = new string[3];
            resultString[0] = Title;
            resultString[1] = Author.FirstName + " " + Author.LastName;
            resultString[2] = Deadline.ToString(new CultureInfo("de-DE"));
            return resultString;
        }

        public int CompareTo(Borrowable? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}

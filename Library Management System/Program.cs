using Library_Management_System.Controller;
using Library_Management_System.View;
using Library_Management_System.Model;
using System.Diagnostics;
namespace Library_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Debug.WriteLine("constructor fired");

            ApplicationConfiguration.Initialize();
            LibraryController libraryController = new LibraryController();
            StreamReader sr;
            string[] data;
            string s;
            using (sr = File.OpenText("Database\\VisitorSet.txt"))
            {
                s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    data = s.Split("|");
                    Visitor visitor = new Visitor();
                    visitor.VisitorId = Guid.Parse(data[0]);
                    visitor.Title = data[1];
                    visitor.FirstName = data[2];
                    visitor.MiddleName = data[3];
                    visitor.LastName = data[4];
                    libraryController.AddNewVisitor(visitor);
                }
            }
            using (sr = File.OpenText("Database/BookSet.txt"))
            {
                s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    data = s.Split("|");
                    Book book = new Book();
                    Author author = libraryController.GetAuthors().Find(x => x.FirstName == data[1] && x.LastName == data[2]);
                    book.Author = author;
                    if (author == null)
                    {
                        author = new Author();
                        book.Author = author;
                        book.Id = Guid.Parse(data[0]);
                        book.Author.Title = data[1];
                        book.Author.FirstName = data[2];
                        book.Author.MiddleName = data[3];
                        book.Author.LastName = data[4];
                    }
                    //book.VisitorId = Guid.Parse(data[0]);
                    
                    book.Title = data[5];
                    book.IsAvailable = true;
                    book.Genre = (Genre)Enum.Parse(typeof(Genre), data[6]);
                    book.PageCount = Int32.Parse(data[7]);
                    libraryController.AddNewBook(book);
                    //do what you have to here
                }
            }
            using (sr = File.OpenText("Database/BorrowSet.txt"))
            {
                s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    data = s.Split("-");
                    //do what you have to here
                    BorrowDetails borrow = new BorrowDetails();
                    borrow.BorrowedBy = libraryController.GetVisitors().Find(x=>x.FirstName == data[2] && x.MiddleName == data[3] && x.LastName == data[4]);
                    
                    if (borrow.BorrowedBy == null)
                    {
                        borrow.BorrowedBy = new Visitor();
                        borrow.BorrowedBy.Title = data[1];
                        borrow.BorrowedBy.FirstName = data[2];
                        borrow.BorrowedBy.MiddleName = data[3];
                        borrow.BorrowedBy.LastName = data[4];
                    }                    

                    string[] borrowedItem = data[5].Split("/");
                    borrow.BorrowedItems = new List<Borrowable>();
                    foreach (string title in borrowedItem)
                    {
                        borrow.BorrowedItems.Add(libraryController.GetBookByTitle(title));
                        libraryController.GetBookByTitle(title).IsAvailable = false;
                    }
                    borrow.BorrowedBy.BorrowConnectedToVisitor.Add(borrow);
                    libraryController.AddNewBorrow(borrow);
                }
            }
            Application.Run(new LibraryApp(libraryController));
        }

    }
}
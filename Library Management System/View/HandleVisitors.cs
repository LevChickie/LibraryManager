using Library_Management_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.View
{
    public partial class HandleVisitors : Form
    {
        private Form navigateNext;

        private LibraryController libraryController;
        public HandleVisitors(LibraryController libraryController)
        {
            InitializeComponent();
            this.libraryController = libraryController;

            this.visitorListView.View = System.Windows.Forms.View.Details;
            this.visitorListView.Columns.Add("First Name");
            this.visitorListView.Columns.Add("Middle Name");
            this.visitorListView.Columns.Add("Last Name");
            this.visitorListView.Columns.Add("Visitor Id");
            //this.visitorListView.Columns.Add("Subscription Ends");
            //this.visitorListView.Columns.Add("Number of borrowed books");

            foreach (Visitor visitor in libraryController.GetVisitors())
            {
                this.visitorListView.Items.Add(new ListViewItem(visitor.GetString()));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            navigateNext = new LibraryApp(libraryController);
            navigateNext.Show();
            this.Hide();
        }

        private void addNewVisitor_Click(object sender, EventArgs e)
        {
            navigateNext = new AddNewVisitor(libraryController);
            navigateNext.Show();
            this.Hide();
        }
    }
}

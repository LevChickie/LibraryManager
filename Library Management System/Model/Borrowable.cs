using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Borrowable
    {
        private bool isAvailable;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set
            {
                if (isAvailable != value)
                {
                    isAvailable = value;
                    //OnPropertyChanged("Data");
                }
            }
        }
    }
}

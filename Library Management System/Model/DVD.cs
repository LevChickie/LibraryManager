using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Model
{
    public class DVD : Borrowable
    {
        private int runtime;
        public int Runtime
        {
            get { return runtime; }
            set { runtime = value; } 
        }
        //private Director / Author? director;
        private int publicationYear;
        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }
        public string[] GetString()
        {
            string[] resultString = new string[2];
            resultString[0] = Title;
            resultString[1] = "";


            return resultString;
        }

    }
}

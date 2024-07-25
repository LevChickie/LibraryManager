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
        //private Director / Author? director;
        private int publicationYear;

        public string[] GetString()
        {
            string[] resultString = new string[2];
            resultString[0] = Title;
            resultString[1] = "";


            return resultString;
        }
    }
}

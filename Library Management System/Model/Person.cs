﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Person
    {
        private string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string title;
        public string Title { get { return title; } set { title = value; } }
        private string middleName;
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        private string lastName;
        public string LastName { get { return lastName; } set { lastName = value; } }

        private DateTime birthday;
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
    }
}

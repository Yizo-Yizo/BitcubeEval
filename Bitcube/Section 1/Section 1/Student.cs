// This class is responsible for creating student
using System;
using System.Collections.Generic;
using System.Text;

namespace Section_1
{
    class Student : Individual
    {
       // Constructors
       public Student()
        {

        }

        public Student(string foreNames, string surname, string emailAddress, string dateOfBirth)
            : base(foreNames, surname, emailAddress, dateOfBirth)
        {

        }
    }
}

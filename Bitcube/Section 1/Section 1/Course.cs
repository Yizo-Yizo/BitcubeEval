// This is responsible for creating a course object
using System;
using System.Collections.Generic;
using System.Text;

namespace Section_1
{
    public class Course : Degree
    {
        // Constructor
        public Course(string degreeName, int duration, string courses, string lecturer)
            : base(degreeName, duration, courses, lecturer)
        {

        }


    }

        

}

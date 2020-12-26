// This class is is responsible for lecturer creation
using System;
using System.Collections.Generic;
using System.Text;

namespace Section_1
{
    public class Lecturer : Individual
    {
        // Properties unique to the lecturer
        private string degreesOffered = "";

        // Contructors
        public Lecturer()
        {

        }

        public Lecturer(string foreNames, string surname, string emailAddress, string dateOfBirth, string degreesOffered)
            : base( foreNames, surname, emailAddress, dateOfBirth)
        {
            this.degreesOffered = degreesOffered;
        }

        // Setters
        public void SetDegreeOffered(string degreesOffered)
        {
            this.degreesOffered = degreesOffered;
        }

        // Getters
        public string GetDegreesOffered()
        {
            return this.degreesOffered;
        }
    }
}

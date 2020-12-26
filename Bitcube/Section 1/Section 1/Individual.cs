// This class is responsible for creating individuals
using System;
using System.Collections.Generic;
using System.Text;

namespace Section_1
{
    public class Individual
    {
        // Individuals properties
        private string foreNames;
        private string surname = "";
        private string emailAddress = "";
        private string dateOfBirth = "";

        // Constructors
        public Individual()
        {

        }
 
        public Individual(string foreNames, string surname, string emailAddress, string dateOfBirth)
        {
            this.foreNames = foreNames; 
            this.surname = surname;
            this.emailAddress = emailAddress;
            this.dateOfBirth = dateOfBirth;
        }

        // Setters
        public void SetForenames(string foreNames)
        {
            this.foreNames = foreNames;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }

        public void SetDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        // Getters
        public string GetForenames()
        {
            return foreNames;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetEmailAddress()
        {
            return this.emailAddress;
        }

        public string GetDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public string GetFirstName()
        {
            string[] names = foreNames.Split(' ');
            return names[0];
        }
    }
}

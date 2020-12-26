using System;

namespace Section_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Lecturer lecturer1 = new Lecturer("Thapelo Saalih", "Selebedi", "selebedi.thapelo6@gmail.com", "26 / 09 / 1990", "math");
            Lecturer lecturer2 = new Lecturer();
            lecturer2.SetDegreeOffered("Mathematics");
            Course course1 = new Course("Calculus", 3, "Linear algebra, Discret Math", "Dr Makasu");
            Console.WriteLine(lecturer1.GetFirstName());
            Console.WriteLine(course1.GetDegreeName());
            Console.WriteLine(lecturer2.GetDegreesOffered());
        }
    }
}

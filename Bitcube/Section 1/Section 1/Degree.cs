// This class is responsible for creating a degree object
using System;
using System.Collections.Generic;
using System.Text;

namespace Section_1
{
    public class Degree
    {
        // Degree properties
        private string degreeName = "";
        private int duration = 0;
        private string courses = "";
        private string lecturer = "";

    public Degree()
        {

        }

    public Degree(string degreeName, int duration, string courses, string lecturer)
        {
            this.degreeName = degreeName;
            this.duration = duration;
            this.courses = courses;
            this.lecturer = lecturer;
        }

    // Setters
    public void SetDegreeName(string degreeName)
        {
            this.degreeName = degreeName;
        }

    public void SetDuration(int duration)
        {
            this.duration = duration;
        }

    public void SetCourse(string courses)
        {
            this.courses = courses;
        }

    public void SetLecturer(string lecturer)
        {
            this.lecturer = lecturer;
        }

    // Getters
    public string GetDegreeName()
        {
            return degreeName;
        }

    public int GetDuration()
        {
            return duration;
        }
    public string GetLecturer()
        {
            return lecturer;
        }
    }
}

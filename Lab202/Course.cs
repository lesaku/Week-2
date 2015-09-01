using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string course = "";
        private int max = 0;
        private int num = 0;
        public string Name;
        public string CourseID
        {
            get { return course; }
            set
            {
               if (value.Length == 6 && value != CourseID)
                {
                    course = value;
                }
                else
                    Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID);
            }

        }
        public string Lecturer;
        public int MaxStudents
        {
            get { return max; }
            set
            {
               if (value >= 0 && value <= 80 && value >= NumStudents)
                    max = value;
                else
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
            }
        }
        public int NumStudents
        {
            get { return num; }
            set
            {
                if (value >= 0 && value <= MaxStudents)
                    num = value;
                else
                    Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID);
           }
        }

        public Course()
        {
            this.Name = "";
            this.CourseID = "";
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }

        public Course(string Name, string CourseID)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }

        public Course(string Name, string CourseID, string Lecturer)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string Name, string CourseID, string Lecturer, int MaxStudents)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            this.MaxStudents = MaxStudents;
            this.NumStudents = 0;
        }
        public override string ToString()
        {
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
            return s;
        }
 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Student : IComparable
    {
        public string name { get; set; }
        private int points;
        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                if (value < 0)
                    throw new Exception();
                value = points;
            }

        }
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student; // преобразование переменной типа obj в переменную типа Student
            if (otherStudent == null)
                throw new ArgumentException();
            if (this.Points > otherStudent.Points)
                return -1;
            else if (this.Points < otherStudent.Points)
                return 1;
            else 
                return 0;

        }
        public Student (string name, int points)
        {
            this.name = name;
            this.points = points;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._27
{
    class StudentsSort
    {
        public static List<Student> Sort (List<Student> students)
        {
            var NewList = new List<Student>(students);
            NewList.Sort();


            return NewList;
        }
    }
}

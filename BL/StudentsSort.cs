using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StudentsSort
    {
        public static List<Student> Sort (List<Student> students)
        {
            var NewList = new List<Student>(students);
            NewList.Sort();


            return NewList;
        }
    }

    
}

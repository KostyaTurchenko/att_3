using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ExcludeStudents 
    {
        public static int minPoint { get; set; }
        public static int minsumOfStudents { get; set; }

        
        
        public List<string> Exclude(List<Student> students)
        {
            var ListPointsExcludedStudent = new List<string>();
            var ListExcludedStudent = new List<Student>();
            int CountStudents = students.Count;
            
            foreach (Student student in students)
            {
                if (SearchingForExclude(student))
                {
                    ListPointsExcludedStudent.Add(student.name);
                    ListExcludedStudent.Add(student);
                                       
                }
                

            }
            int CountExcluded = ListPointsExcludedStudent.Count;
            int CountLearning = CountStudents - CountExcluded;
            if (CountLearning < minsumOfStudents)
            {
                var NewList = ListPointsExcludedStudent;
                for (int i = CountLearning; i < minsumOfStudents; i++)
                {
                    for (int c = minPoint; c >= 0; c--)
                    {
                        foreach (Student student in ListExcludedStudent)
                        {
                            if (c == student.Points)
                            {
                                NewList.Remove(student.name);
                                if (CountStudents - NewList.Count == minsumOfStudents)
                                    return NewList;
                                
                            }
                            
                        }
                        
                        
                    }
                }
                return NewList;
            }
            else
                return ListPointsExcludedStudent;

            
        }

        

        public bool SearchingForExclude(Student student)
        {            
            return student.Points < minPoint;
        }

        public ExcludeStudents (int minPoint, int minsumOfStudents)
        {
            ExcludeStudents.minPoint = minPoint;
            ExcludeStudents.minsumOfStudents = minsumOfStudents;
        }

    }
}

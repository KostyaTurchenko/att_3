using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._27
{
    public class StudentsFiles
    {
        public static List<Student> ReadStudentsListFromFile (string path)
        {
            var studentsList = new List<Student>();
            string[] fileLines = File.ReadAllLines(path);

            foreach (string line in fileLines)
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0] + ' ' + parts[1];
                int points = int.Parse(parts[2]);

                studentsList.Add(new Student(name, points));
            }

            return studentsList;
        }

        public static void SaveStudentsListInFile(string path, List<Student> students)
        {
            var lines = new List<string>();

            foreach (Student student in students)
            {
                lines.Add(student.name + " " + student.Points);
            }

            File.WriteAllLines(path, lines);
        }
    }
}

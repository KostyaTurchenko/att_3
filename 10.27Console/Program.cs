using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Utils;
using System.IO;

namespace _10._27Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students;
            if (ConsoleUtils.Answer("Получить данные из файла?"))
            {
                while (true)
                {
                    try
                    {
                        string inputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу",
                            (path) => (File.Exists(path)));

                        // ввод списка студентов из файла
                        students = StudentsFiles.ReadStudentsListFromFile(inputFilePath);
                        break;
                    }
                    catch (Exception) { }
                }


                              
            }

            else //ввод из консоли
            {
                int studentsCount = ConsoleUtils.ReadValue<int>("количество студентов", (count) => (count > 0));

                students = new List<Student>(studentsCount);

                for (int i = 0; i <  studentsCount; i++)
                {
                    string name = ConsoleUtils.ReadValue<string>("ФИО студента",
                        (string fullName) => fullName != "");

                    int points = ConsoleUtils.ReadValue<int>("баллы", (int p) => p > 0);

                    students.Add(new Student(name, points));
                }
               
            }
            int minsumOfStudents = ConsoleUtils.ReadValue<int>("минимальное количество студентов", (int s) => s > 0);
            int minPoints = ConsoleUtils.ReadValue<int>("минимальное количество баллов", (int b) => b > 0);

            // сортируем список студентов
            List<Student> sortedStudents = StudentsSort.Sort(students);
            // cоздаем экземпляр класса 
            var instance = new ExcludeStudents(minPoints, minsumOfStudents);
            // получаем список исключенных студентов
            List<string> ExcludedStudens = instance.Exclude(sortedStudents);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.name + " " + student.Points);
            }

            Console.WriteLine();


            //вывод отчисленных студентов
            Console.WriteLine("Отчислены: ");
            foreach (string student in ExcludedStudens)
            {
                Console.WriteLine(student);
            }

            if (ConsoleUtils.Answer("Сохранить данные в файл?"))
            {
                while (true)
                {
                    try
                    {
                        string outputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу");

                        
                        StudentsFiles.SaveStudentsListInFile(outputFilePath, sortedStudents);
                        break;
                    }
                    catch (Exception) { }
                }

            }




        }
    }
}

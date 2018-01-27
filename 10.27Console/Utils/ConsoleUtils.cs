using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class ConsoleUtils
    {
        public static T ReadValue<T>(string name, Func<T, bool> valibator = null)
                                                  // передаём в метод функцию(возвращает bool)
        {
           
            while (true) 
            {
                // считываем строку(переводим её в указанный тип). Если перевод прошел успешно, то возвращаем 
                try
                {
                    Console.Write("Введите " + name + ": ");
                    T value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

                    if (valibator != null && !valibator(value))
                        throw new Exception();

                    return value;
                }
                catch (Exception)
                {

                }
            }
        }
        public static bool Answer (string question)
        {
            ConsoleKey key;

            do
            {
                Console.Write(question + " (y/n) ");
                key = Console.ReadKey(false).Key; // false - чтобы нажатая клавиша показывалась в консоле 
                 if (key != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }

            }
            while (key != ConsoleKey.Y && key != ConsoleKey.N);

            return key == ConsoleKey.Y;
        }
    }
}

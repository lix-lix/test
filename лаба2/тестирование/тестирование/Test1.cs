using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тестирование
{
    public class Three_words
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string average  = NewMethod(input);
            Console.WriteLine(average);
            Console.ReadLine();
        }

        public static string NewMethod(string input)
        {
            string[] splitStr = input.Split(' ', ',', '.');
            string s = "";
            foreach (var str in splitStr)
            {
                if (str.Length == 3)
                {
                    char output = (char)(((int)str[0] + (int)str[1] + (int)str[2]) / 3);
                    s += output;
                }
                else
                {
                    return "Ошибка!";
                }
            }
            return s;
        }

    }
}

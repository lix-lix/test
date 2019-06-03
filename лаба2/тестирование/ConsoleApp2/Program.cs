using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string average = NewMethod(input);
            Console.WriteLine(average);
            Console.ReadLine();
        }

        public static string NewMethod(string input)
        {
            string[] splitStr = input.Split(' ', '.', ',');
            for (int i = 0; i < splitStr.Length; i++)
            {
                string str = splitStr[i];
                if (str.Length == 3)
                {
                    char output = (char)(((int)str[0] + (int)str[1] + (int)str[2]) / 3);
                    Console.WriteLine(str + " = " + output);
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
               
            }
            return input;
        }
       
    }
}

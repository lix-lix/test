using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_letter_words_in_the_sims
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string [] splitStr = input.Split(' ', '.', ',');
            foreach (var str in splitStr)
            {
                if (str.Length == 3)
                {
                    char output = (char)(((int)str[0] + (int)str[1] + (int)str[2]) / 3);
                    Console.WriteLine(str + " = " + output);
                }
            }

            Console.ReadLine();

        }
    }
}

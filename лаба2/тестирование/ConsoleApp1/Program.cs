﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string New(string g)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string[] splitStr = input.Split(' ', '.', ',');
            foreach (var str in splitStr)
            {
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

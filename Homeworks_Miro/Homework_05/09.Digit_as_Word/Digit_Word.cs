﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Digit_as_Word
{
    class Digit_Word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string a = Console.ReadLine();
            double digit;
            
            bool parseSuccess = double.TryParse(a, out digit);
 
            Console.Write(parseSuccess ? a : "{0} not a digit!", a);
            Console.WriteLine();
          
            switch (a)
            {
                case "0": Console.WriteLine(" zero"); break;
                case "1": Console.WriteLine(" one"); break;
                case "2": Console.WriteLine(" two"); break;
                case "3": Console.WriteLine(" three"); break;
                case "4": Console.WriteLine(" four"); break;
                case "5": Console.WriteLine(" five"); break;
                case "6": Console.WriteLine(" six"); break;
                case "7": Console.WriteLine(" seven"); break;
                case "8": Console.WriteLine(" eight"); break;
                case "9": Console.WriteLine(" nine"); break;

                default: if ((digit > 9 || (digit < 0)))
                    {
                        Console.WriteLine(" invalid number"); ;
                    }
              
                    break;
                    




            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 > 0)
            {
                Console.WriteLine("odd = {0}",true);

            }
            else
            {
                Console.WriteLine("even = {0}",true);
            }

        }
    }
}

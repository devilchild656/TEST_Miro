﻿using System;

class OddOrEven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 1)
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Even");
        }
    }
}

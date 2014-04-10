using System;

class OddOrEvenInt
{
    static void Main()
    {
        int n = 4;

        Console.WriteLine("Odd?");

        if ((n % 2) == 0)
        {
            Console.WriteLine("false {0} is even" , n);
        }
        else
        {
            Console.WriteLine("true {0} is odd", n);
        }
    }
}
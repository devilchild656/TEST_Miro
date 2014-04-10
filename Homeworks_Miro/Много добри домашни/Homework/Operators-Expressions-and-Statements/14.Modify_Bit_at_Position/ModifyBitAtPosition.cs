using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value 0 o 1: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int vBit = v == 1 ? 1 : 0;

        if (vBit == 1)
        {
            int mask1 = 1 << p;
            int result1 = n | mask1;
            Console.WriteLine(result1);
        }
        else
        {
            int mask0 = ~(1 << p);
            int result0 = n & mask0;
            Console.WriteLine(result0);
        }
    }
}
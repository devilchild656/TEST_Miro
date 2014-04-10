using System;

class DivideBy7and5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 5 == 0 && n % 7 == 0);
    }
}

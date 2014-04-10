using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int r = 2;

        Console.WriteLine(x*x + y*y <= r*r);
    }
}

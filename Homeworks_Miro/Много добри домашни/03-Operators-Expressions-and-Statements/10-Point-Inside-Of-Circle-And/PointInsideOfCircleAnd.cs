using System;

class PointInsideOfCircleAnd
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double circleX = x - 1;
        double circleY = y - 1;
        double r = 1.5;

        Console.WriteLine(((circleX * circleX + circleY * circleY <= r * r) == true && ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1)) == false) ? "yes" : "no");
    }
}

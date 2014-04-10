using System;

class RectanglesPA
{
    static void Main()
    {
        double height = 5;
        double width = 5;

        double perimeter = 2*(height + width);
        double area = height * width;

        Console.WriteLine("Rectangle with:\nh={0} and w={1}\nHave P={2} nad A={3}" , height, width , perimeter, area);
    }
}
using System;

class PointInCircle
{
    static void Main()
    {
        double posX = 1;
        double posY = -1.655;
        double centX = 0;
        double centY = 0;
        double r = 2;
        double d = Math.Sqrt(((posX - centX) * (posX - centX)) + ((posY - centY) * (posY - centY)));

        if ( (d * d) <= (r * r))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
using System;

class MoonGravityCalc
{
    static void Main()
    {
        decimal weight = 86m;

        decimal moonWeight = (weight * 17) / 100;

        Console.WriteLine("Weight on the earth is: {0}.\nWeight on the Moon is: {1}." , weight, moonWeight);
    }
}
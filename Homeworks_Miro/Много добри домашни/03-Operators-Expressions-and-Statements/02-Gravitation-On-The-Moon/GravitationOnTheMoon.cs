using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double percentage = 0.17;
        Console.WriteLine(percentage*weight);
    }
}

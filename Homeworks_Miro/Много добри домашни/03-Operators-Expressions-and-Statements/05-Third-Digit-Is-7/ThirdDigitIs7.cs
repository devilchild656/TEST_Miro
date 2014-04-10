using System;

class ThirdDigitIs7
{
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(n[n.Length-3] == '7');
    }
}

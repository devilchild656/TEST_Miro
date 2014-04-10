using System;

class ExtractBitFormInt
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int numbRightPos = n >> p;
        int bit = numbRightPos & 1;

        Console.WriteLine("Bit at position p is: " + bit);
    }
}
using System;

class ChechBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        int numbRightPos = n >> p;
        int bit = numbRightPos & 1;

        bool bitCheck = bit == 1 ? true : false;
        Console.WriteLine(bitCheck);
    }
}
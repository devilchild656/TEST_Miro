using System;

class ModifyABitAtGiven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inBinary = Convert.ToString(n, 2);
        Console.WriteLine(inBinary);

        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        int result = 0;
        int output = 0;
        if (v==1)
        {
            result = Convert.ToInt32(n|mask);
        }
        else
        {
            result = Convert.ToInt32(n&(~mask));
        }
        Console.WriteLine(result);
    }
}

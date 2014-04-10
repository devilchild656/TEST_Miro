using System;

class CheckABitAtGivenPos
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bitN = n >> p;
        int bit = bitN & 1;
        string inString = Convert.ToString(n, 2);
        //Console.WriteLine(inString);
        Console.WriteLine(bit == 1);
    }
}

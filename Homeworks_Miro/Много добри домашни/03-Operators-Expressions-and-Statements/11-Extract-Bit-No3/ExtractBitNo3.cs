using System;

class ExtractBitNo3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3-1;
        int bitN = n >> p;
        int bit = bitN & 1;
        string inString = Convert.ToString(n, 2);
        //Console.WriteLine(inString);
        Console.WriteLine(bit);
    }
}

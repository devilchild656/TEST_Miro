using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        int n = 62241;
        int pos = 3;
        int nRightPos = n >> pos;
        int bit = nRightPos & 1;

        Console.WriteLine(bit);
    }
}
using System;

class DiveBySevenAndFive
{
    static void Main()
    {
        int n = 980;

        if (((n / 7.0) % 5.0 == 0) && ((n / 5.0) % 7.0 == 0) && n != 0)
        {
            Console.WriteLine("{0} divide by 7 and 5: true" , n);
        }
        else
        {
            Console.WriteLine("{0} divide by 7 and 5: false" , n);
        }
    }
}
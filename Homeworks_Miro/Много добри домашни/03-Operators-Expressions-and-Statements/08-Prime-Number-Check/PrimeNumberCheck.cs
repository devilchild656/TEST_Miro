using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        if (n <= 100)
        {
            if (n == 3)
            {
                counter = 2;
            }
            else
            {
                for (int i = 3; i <= n; i += 2)
                {
                    if (n % i == 0 && counter <= 2)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter == 2);
        }
    }
}

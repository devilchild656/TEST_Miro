using System;

class FourDigitNumber
{
    static void Main()
    {
        string n = Console.ReadLine();
        int a = (int)n[0] - 48;
        int b = (int)n[1] - 48;
        int c = (int)n[2] - 48;
        int d = (int)n[3] - 48;

        int sum = a + b + c + d;
        string reversedOrder = d + "" + c + "" + b + "" + a;
        string lastDigitFirst = d + "" + a + "" + b + "" + c;
        string exchangeSecondAndThird = a + "" + c + "" + b + "" + d;

        Console.WriteLine(sum);
        Console.WriteLine(reversedOrder);
        Console.WriteLine(lastDigitFirst);
        Console.WriteLine(exchangeSecondAndThird);
    }
}

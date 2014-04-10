using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int numbInt = 777877;
        string numbString = numbInt.ToString();
        int numbPosition = numbString.Length - 3;

        Console.WriteLine("Third digit 7?");

        if (numbPosition >= 0)                  //check if the number have less than 3 digit
        {
            char numbCheck = numbString[numbPosition];
            
            if (numbCheck == '7')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            Console.WriteLine("false");         //false because of less than 3 digits
        }
    }
}
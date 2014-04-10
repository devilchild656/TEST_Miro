using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter 4 digit number: ");
        
        string input = Console.ReadLine();
        int digits;

        if (int.TryParse(input, out digits))        //check fi the input can be parsed as int
        {
            if (input.Length == 4)                  //check if the lenght of the string is 4 chars only
            {
                int a = (int)Char.GetNumericValue(input[0]);
                int b = (int)Char.GetNumericValue(input[1]);
                int c = (int)Char.GetNumericValue(input[2]);
                int d = (int)Char.GetNumericValue(input[3]);

                if (a != 0)                         //check if first number of the digits is 0
                {
                    Console.WriteLine("four digit number: " + digits);
                    Console.WriteLine("sum of digits: " + (a + b + c + d));
                    Console.WriteLine("reversed digits: {0}{1}{2}{3}" , d, c, b, a);
                    Console.WriteLine("last digit in front: {0}{1}{2}{3}" , d, a, b, c);
                    Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}" , a, c, b, d);
                }
                else
                {
                    Console.WriteLine("The first digit of the number can't be 0.");
                }
            }
            else
            {
                Console.WriteLine("Number have to be 4 digits long.");
            }
        }
        else
        {
            Console.WriteLine("The input is not 4 digit number.");
        }
    }
}
using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int numb = 97;
        bool check = false;

        //check if the number is in range
        if (numb >= 0 && numb <= 100)
        {
            for ( int i = 2; i <= Math.Sqrt(numb); i++)
            {
                if (numb % i == 0)
                {
                    check = true;
                    break;
                }
            }

            if (check == false && numb != 0 && numb !=1)
            {
                //the numb is prime
                Console.WriteLine("{0} is Prime." , numb);
            }
            else
            {
                //the numb is not prime
                Console.WriteLine("{0} is not Prime." , numb);
            }
        }
        else
        {
            //if the number si negative or bigger than 100
            Console.WriteLine("Number have to be in range from 0 to 100");
        }
    }
}
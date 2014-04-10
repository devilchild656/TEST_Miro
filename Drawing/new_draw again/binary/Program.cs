using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ulong[] number = new ulong[b];


            for (int i = 0; i < b; i++)
            {

                number[i] = ulong.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
                ulong remainder = 0;
                string result = null;

                while (number[i] > 0)
                {
                    remainder = number[i] % 2;
                    number[i] /= 2;
                    result = remainder.ToString() + result;
                }

                int digitCounter = 0;
                for (int j = 0; j < result.Length; j++)
                {
                    if (int.Parse(result[j].ToString()) == n)
                    {
                        digitCounter++;
                    }
                }
                Console.WriteLine(digitCounter);
            }
        }
    }
}

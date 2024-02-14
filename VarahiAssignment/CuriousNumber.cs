using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarahiAssignment
{
    internal class CuriousNumber
    {
        
        static int Fact(int n)
        {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                return result;
            
        }
        static int FactOfDigits(int Num)
        {
            int result = 0;

            while (Num > 0)
            {
                int digit = Num % 10;

                int digitfact = Fact(digit);

                result = result + digitfact;

                Num = Num / 10;
            }

            return result;
        }
        static void Main(string[] args)
        
        {
            Console.Write("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = FactOfDigits(number);

            Console.WriteLine($"The sum of factorial of digits is {result}");
        }
    }
}

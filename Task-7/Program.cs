using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}

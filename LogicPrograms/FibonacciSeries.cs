using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public static void Fibonacci()
        {
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            int num1 = 0, num2 = 1, num3;
            if (a == 0)
                Console.WriteLine(0);
            if (a == 1)
                Console.WriteLine(1);
            else
            Console.WriteLine("Fibonacci Series of first {0} numbers are",a );
            {
                Console.WriteLine();
                for (int i = 1; i <= a; i++)
                {
                    num3 = num1 + num2;
                    Console.WriteLine(num3 + "");
                    num1 = num2;
                    num2 = num3;
                }
            }

        }
    }
}

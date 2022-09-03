using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int n, m;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;

            for (int i = 1; i <= m; i++)
            {
                if (n % i == 0 || n % i == n)
                {
                    int res = n / i;
                    Console.WriteLine("Divisor is " + res);
                }

            }

        }
    }
}
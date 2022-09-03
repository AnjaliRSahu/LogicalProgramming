using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % 2 == 0)
                    a++;
            }
            if (a == 2)
                Console.WriteLine("{0} is a prime number", a);
            else
                Console.WriteLine("{0} is not a prime number", a);
         }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Coupon
    {
        public static void CheckCoupon()
        {
            Console.WriteLine("Enter N dsintict times a coupon number  ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                int r= random.Next(1,n);
                if (!list.Contains(r))
                {
                    list.Add(r);
                    Console.WriteLine("Random generated number is " + r);
                }
                else 
                {
                    Console.WriteLine("Number is already there");

                }
                
            }
        }
    }
}

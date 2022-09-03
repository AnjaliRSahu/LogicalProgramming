using LogicPrograms;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose options \n 1.Fibonacci Series \t 2.Perfect Number \t3.Prime Number4\n 4.Reverse Number \t5.Coupon Numbers \t6.Simulate StopWatch");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
                case 2:
                   PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber.Reverse();
                    break;
                case 5:
                    Coupon1.CheckCoupon();
                    break;
                case 6:
                    StopWatch1.Simulate();
                    break;
                 default:
                    Console.WriteLine("Wrong Choice");
                    break;

            
            
            
            }
            
            
        
        }
    }
}
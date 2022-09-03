using LogicPrograms;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose options \n 1.Fibonacci Series \t 2.Perfect Number \t3.Prime Number ");
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
                     default:
                    Console.WriteLine("Wrong Choice");
                    break;

            
            
            
            }
            
            
        
        }
    }
}
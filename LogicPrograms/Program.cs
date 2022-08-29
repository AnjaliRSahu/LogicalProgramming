namespace LogicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logic Programs");
            Console.WriteLine("Choose options \n 1.Fibonacci Series ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }

        }
    }
}
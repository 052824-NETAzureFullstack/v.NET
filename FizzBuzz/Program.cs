using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt user to input lower and upper values

            Console.Write("Please enter a valid lower limit: ");
            string userIn = Console.ReadLine();
            int lower = Int32.Parse(userIn);

            Console.Write("Please enter a valid upper limit: ");
            userIn = Console.ReadLine();
            int upper = Int32.Parse(userIn);

            for (int i = lower; i <= upper; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else 
                    Console.WriteLine(i);
            }

        }
    }
}

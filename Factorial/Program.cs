using System;

namespace Factorial
{
    class Program
    {
        static int Fact(int number)
        {
            if (number == 0)
                return 1;

            else
                return (number * Fact(number - 1));

        }

         static void Main(string[] arg)
        {
            Console.WriteLine("Enter the Number :");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            int factorialNum = Fact(userInputNumber);
            Console.WriteLine("Factorial of Number is :: {0}", factorialNum);
        }
    }
}

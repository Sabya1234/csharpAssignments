using System;

namespace Utility
{
    class UtilityProgram
    {
        int number;
        public UtilityProgram(int n)
        {
            number = n;
        }

        public void Factorial()
        {
            int fact = 1;
            
                for (int i = 1;i<= number;i++)
                {
                   fact = fact * i;
                }

            Console.WriteLine("Factorial of {0} is {1}", number, fact);

        }
        public void DetermineOddEven()
        {
            if (number % 2 == 0)
                Console.WriteLine("Given number {0} is Even",number);
            else
                Console.WriteLine("Given number {0} is ODD",number);
        }


    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("==========Hello Welcome to UTILITY========");
            Console.WriteLine("Kindly enter a Number");
            int both = Convert.ToInt32(Console.ReadLine());
            UtilityProgram util2 = new UtilityProgram(both);
            util2.Factorial();
            util2.DetermineOddEven();
        }
    }
}

using System;

namespace Fibonacci
{
    class Program
    {

        static int num1 = 0, num2 = 1, num3 = 0;

        static void FibonacciPrint(int count)
        {
            for (int i = 2; i <= count;i++)
           {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(" " + num3);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter fibonacci series for : ");
            int userInputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series ::::::::");
            Console.WriteLine(" "+num1 + "\n" +" "+num2);
            FibonacciPrint(userInputNum);
        }
    }
}

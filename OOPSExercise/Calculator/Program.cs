using System;

namespace Calculator
{
    class Calculation
    {
        double num1, num2;
        public Calculation(double n1,double n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public void Addition()
        {
            Console.WriteLine("Result of addition of {0} and {1} is {2}",num1,num2, num1 + num2);
        }
        public void Substraction()
        {
            Console.WriteLine("Result of substraction of {0} and {1} is {2}", num1, num2, num1 - num2);
        }
        public void Multiplication()
        {
            Console.WriteLine("Result of multiplication of {0} and {1} is {2}", num1, num2, num1 * num2);
        }
        public void Division()
        {
            Console.WriteLine("Result of division of {0} and {1} is {2}", num1, num2, num1 / num2);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation(10, 20.5);
            calc.Addition();
            calc.Substraction();
            calc.Multiplication();
            calc.Division();
        }
    }
}

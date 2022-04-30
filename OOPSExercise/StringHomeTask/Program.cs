using System;

namespace StringHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly Enter First Name:");
            string first = Console.ReadLine().ToString();
            Console.WriteLine("Kindly Enter Last Name:");
            string last = Console.ReadLine().ToString();

            //Print Full name by concatenating first name and last name
            string fullName =first+" "+last;
            Console.WriteLine("Full name is ::{0}", fullName);

            //Printing Name in Upper case
            Console.WriteLine("Name in  Upper case :{0}", fullName.ToUpper());

            //Printing First character of Last Name
            char[] firstCharofLastName = last.ToCharArray();
            Console.WriteLine("First character of Last Name is :{0}", firstCharofLastName[0]);


        }
    }
}

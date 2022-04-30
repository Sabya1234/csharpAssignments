using System;
using System.Collections.Generic;

namespace LoopExcercise
{
    class Program
    {
        
        public static string longestName = "";
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine("Please Enter 4 Names :");
            for (int i = 0; i < 4; i++)
            {
                names.Add(Console.ReadLine().ToString());
            }
            Console.WriteLine("========User given 4 names are=========");
            foreach (string username in names)
            {
                Console.WriteLine(username);
                if (username.Length > longestName.Length)
                {
                    longestName = username;
                }
            }
            Console.WriteLine("The longest name is given input is ==> {0}", longestName);
        }
    }
}

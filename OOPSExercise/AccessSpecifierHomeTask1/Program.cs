using System;

namespace AccessSpecifierHomeTask1
{
    class Shield
    {
        private string _identifier;
        private int _power;
            
        public Shield()
        {
            _identifier = "default";
            _power = 10;
        }

        public string Details
        {
            get
            {
                return "The value of private string variable is -->" + _identifier + "The value of private int variable is--> " + _power;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Shield sh = new Shield();
            Console.WriteLine(sh.Details);
            Console.ReadLine();
        }
    }
}

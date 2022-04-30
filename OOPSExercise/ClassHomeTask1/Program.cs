using System;

namespace EmloyeeNameSalary
{
    class Employee
    {
        public string name;
        public Employee(string  empName)
            {
              name = empName;
            }

        public void PrintSalary()
        {
            Console.WriteLine("Salary of Employee {0} is 50,000 Rupees",name);
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kindly Enter Employee Name");
            
            string userInput = Console.ReadLine().ToString().ToUpper();

            Console.WriteLine("Employee name in Upper case {0}", userInput);

            Employee emp = new Employee(userInput);
            emp.PrintSalary();
            
            

        }
    }
}

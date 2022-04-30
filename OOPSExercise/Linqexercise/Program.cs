using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqexercise
{
   class Employee
    {
        public string name;
        public  int age, employeeID;

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listofEmployees = new List<Employee>();
            listofEmployees.Add(new Employee()
            {
                name="Sabyasachi",employeeID=123,age=28
            });

            listofEmployees.Add(new Employee()
            {
                name = "Yogesh",employeeID = 124,age = 32
            });

            listofEmployees.Add(new Employee()
            {
                name = "Ashutosh",employeeID = 125,age = 31
            });

            listofEmployees.Add(new Employee()
            {
                name = "Kranti",
                employeeID = 126,
                age = 37
            });
            listofEmployees.Add(new Employee()
            {
                name = "Gnanavivek",
                employeeID = 127,
                age = 26
            });

            foreach (Employee emp in listofEmployees)
            {
                Console.WriteLine("Employee name is {0} ID is {1} and age is {2}",emp.name,emp.employeeID,emp.age);
            }


            Console.WriteLine("No of Employess in  company is {0}", GetValidCount(listofEmployees));
            GetFirstValidValue(listofEmployees);
        }

        //No of Employees in organization --Valid Count 
        public static int GetValidCount(List<Employee> empcount)
        {
            return empcount.Count;
        }

        //First Employee data whose age is more than 30 
        public static void GetFirstValidValue(List<Employee> firstEmployeeResult)
        {
            var resultData = firstEmployeeResult.First(em => em.age > 30);
            Console.WriteLine("The First Employee in organization whose age is more than 30: {0}", resultData.name);
                           
        }

    }
}

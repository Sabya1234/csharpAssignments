using System;

namespace InterfaceTask
{
    
        public interface ICollege
        {
            public void PrintDegree();
        }
        public interface ISchool
        {
            public void PrintSSCMarkSheet();
        }

        public class Student : ICollege, ISchool
        {
            public void PrintDegree()
            {
                Console.WriteLine("Degree has printed and handed over");
            }

            public void PrintSSCMarkSheet()
            {
                Console.WriteLine("Marksheet has printed and handed over");
            }
        }
    class Program
    {

        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student();
            stu1.PrintDegree();
            stu2.PrintSSCMarkSheet();

        }
    }
    
}

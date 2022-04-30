using System;
using System.IO;

namespace FileHandlingExercise
{

    class Program
    {
        /// <summary>
        /// Writing into the file 
        /// </summary>
        /// <param name="filePath"></param>
        public static void WriteIntoFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("--------Enter The Student Details you want to save::-----");
                    Console.WriteLine("Enter Student ID");
                    string studentID = Console.ReadLine().ToString();
                    Console.WriteLine("Enter The Student Name");
                    string stuName = Console.ReadLine().ToString().ToUpper();
                    Console.WriteLine("Enter Student Department");
                    string studentDept = Console.ReadLine().ToString().ToUpper();
                    string finalValue = studentID + "," + stuName + "," + studentDept;
                    sw.WriteLine(finalValue);
                    sw.Flush();
                   

                }
            }

        }
        /// <summary>
        /// Reading the content from the File from filepath passed as an argument into the below function
        /// </summary>
        /// <param name="filePath"></param>
        public static void ReadandDisplayContentFile(string filePath)
        {
            
                    using (FileStream fs1 = new FileStream(filePath, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs1))
                        {
                            Console.WriteLine("====The FileCOntent is ======");
                            string content = sr.ReadToEnd();
                            Console.WriteLine(content);


                        }
                    }
                    

                
        }
        static void Main(string[] args)
        {

            string path = @"C:\Student";
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                if (dir.Exists)
                {
                    Console.WriteLine("The directory exists!! {0}", dir);
                    
                }
                else
                {
                    dir.Create();
                    Console.WriteLine("The Directory has been Created and the details is :{0}", dir);
                }

                //Adding the file Under Student Directory with the User Input name

                Console.WriteLine("Kindly Enter your Name that you want to registered as file:");
                string studentName = Console.ReadLine().ToString();
                string fileName = studentName + ".txt";
                string filePath = Path.Combine(path, fileName);
                Console.WriteLine("whole filepath is:{0}", filePath);

                //Writing into the File

                WriteIntoFile(filePath);

                //reading the content of saved file

                ReadandDisplayContentFile(filePath);


            }
            catch (IOException e)
            {
                Console.WriteLine("The execution stopped :{0}", e.ToString());
            }


        }
    }
}

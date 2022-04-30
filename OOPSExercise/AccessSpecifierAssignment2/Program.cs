using System;

namespace AccessSpecifierAssignment2
{
    class Test
    {
       
        public void TestChildPublicSpecifier()
        {
            Console.WriteLine("Test Public");
        }
        private void TestChildPrivateSpecifier()
        {
            Console.WriteLine("Test Private");

        }
    }

    class Program
    {
        public static string  checkIfmethodExists(string methodName)
        {
            string @namespace = "AccessSpecifierAssignment2";
            string @class = "Test";
            var myClassType = Type.GetType(string.Format("{0}.{1}", @namespace, @class));
            object instance = myClassType == null ? null : Activator.CreateInstance(myClassType); 
            var myMethodExists = myClassType.GetMethod(methodName) != null;
            return myMethodExists == true ? "AccessGranted" : "Access Denied";

        }
       
        static void Main(string[] args)
        {
            string method1 = "TestChildPublicSpecifier";
            string method2 = "TestChildPrivateSpecifier";
            Console.WriteLine(Program.checkIfmethodExists(method1));
            Console.WriteLine(Program.checkIfmethodExists(method2));
        }
    }
}

using System;

namespace ExtentionClassDemoPredefinedClass
{
    public static class ExtentionMethodString
    {
        public static string GetUpperCaseString(this string str)
        {
            return str.ToUpper();
        }
        public static string GetLowerCaseString(this string str)
        {
            return str.ToLower();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hi, Welcome to Extenstion Method Demo in C#";


            Console.WriteLine("Before Calling the extention Method");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(message);

            string messageUppercase= message.GetUpperCaseString();
            Console.WriteLine("After Calling the UpperCase extention Method");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(messageUppercase);

            string messageLowercase = message.GetLowerCaseString();
            Console.WriteLine("After Calling the LowerCase extention Method");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(messageLowercase);

            Console.ReadLine();
        }
    }
}
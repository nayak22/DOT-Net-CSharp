using System;

/*This is a C# program that demonstrates the use of optional parameters. Optional parameters allow you to specify default values for parameters in a method signature. When calling the method, you can choose to omit arguments for these parameters, and the default values will be used instead.*/

namespace Sample
{
    class Program
    {
        public static void PrintCountry(string country="India")
        {
            Console.WriteLine(country);
        }
        public static void Main(string[] args) {
            //calling methods

            PrintCountry();
            PrintCountry("Swedden");
            PrintCountry("Australia");
            PrintCountry("England");
            PrintCountry("USA");
            PrintCountry("Cannada");
            PrintCountry("South Africa");

            /* the PrintCountry method has one parameter, country, which has a default value of "India". This means that if you call the PrintCountry method without providing an argument, the default value of "India" will be used. In the Main method, the PrintCountry method is called several times, both with and without arguments. When called without an argument, the default value is used and "India" is printed to the console. When called with an argument, the provided value is used instead of the default value.*/

            Console.ReadKey();
        }
    }
}

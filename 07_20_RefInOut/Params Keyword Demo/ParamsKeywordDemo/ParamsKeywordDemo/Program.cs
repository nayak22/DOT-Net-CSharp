using System;
/*This is a C# program that demonstrates the use of the params keyword. The params keyword in C# allows a method to accept a variable number of arguments1. The parameter type must be a single-dimensional array2. No additional parameters are permitted after the params keyword in a method declaration, and only one params keyword is permitted in a method declaration2.*/
namespace Examples
{
    class Program
    {
        // function containing params parameters
        
        public static int Add(params int[] ListNumbers)
        {
            /* the Add method has a parameter ListNumbers that is declared with the params keyword. This means that you can call the Add method with any number of integer arguments. These arguments are stored in an array, and the method calculates the sum of these numbers.*/
            int sum = 0;
            // foreach loop
            foreach (int i in ListNumbers)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            // Calling function by passing 5
            // arguments as follows
            int result = Add(12, 45, 33, 64, 19, 11, 23, 27);

            Console.WriteLine("sum of supplied numbers "+ result);

            /* the Main method, the Add method is called with eight integer arguments. The sum of these numbers is calculated in the Add method and returned as a result. The result is then printed to the console.*/

            Console.ReadLine();


        }
    }
}
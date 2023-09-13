using System;

/*This is a C# program that demonstrates the use of the ref keyword. The ref keyword is used to pass an argument by reference, not by value. This means that any changes made to the parameter within the method will be reflected in the argument passed to the method.*/
namespace refKeyword
{
    class Program
    {
        //define addValue method
        // Parameters passed by value
        public static void addValue(int a)
        {
            a += 10;
        }
        // Define subtractValue
        // Parameters passed by ref

        public static void subValue(ref int b)
        {
            b -= 5;
        }
        /*addValue and subValue. The addValue method takes an int parameter passed by value, while the subValue method takes an int parameter passed by reference using the ref keyword. */

        //Main Method
        static void Main(string[] args)
        {
            //initialize a, b
            int a = 10, b = 12;

            // Display initial values
            Console.WriteLine("Initial value of a is {0}", a);
            Console.WriteLine("Initial value of b is {0}", b);
            Console.WriteLine();


            // Call addValue method by value

            addValue(a);
            // Display modified value of a
            Console.WriteLine("Value of a after addition" +
                                  " operation is {0}", a);
            Console.WriteLine();

            // Call subtractValue method by ref
            subValue(ref b);

           // Display modified value of b
            Console.WriteLine("Value of b after " +
                "subtraction operation is {0}", b);

            Console.ReadLine();
            /*he Main method, two variables a and b are initialized with values 10 and 12, respectively. The addValue method is called with a as an argument, and the value of a is displayed after the method call. Since the parameter is passed by value, the value of a remains unchanged. The subValue method is then called with b as an argument, and the value of b is displayed after the method call. Since the parameter is passed by reference using the ref keyword, the value of b is changed within the method and the change is reflected in the argument.*/



        }
    }
}

using System;
using System.Reflection;

/*This is a C# code snippet that demonstrates the use of the out keyword. The out keyword is used to pass an argument to a method by reference, with the intention that the method will assign a value to the argument. This means that the method must initialize the out parameter before returning.*/


namespace OutParameter
{
    class Program
    {
        //user defined method
        public void Show(out int value) //out parameter
        {
            int square = 5;
            value = square;
            value *= value;
            /*the Show method takes an out parameter of type int. Inside the method, an integer variable square is declared and assigned a value of 5. The out parameter val is then assigned the value of square, and its value is squared.*/
        }

        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();//creating objject
            Console.WriteLine("Value before passing out variable " + val);
            program.Show(out val);
            Console.WriteLine("Value after passing out variable " + val);

            /*In the Main method, an integer variable val is declared and assigned a value of 50. A new object of type Program is created, and the Show method is called with val as an out argument. Before and after the call to Show, the value of val is printed to the console. As a result, you will see that the value of val changes from 50 to 25, demonstrating that the Show method has modified its value.*/

            Console.ReadKey();


        }
    }

}
using System;

namespace ParameterizedConstructor
{
    class Sum
    {
        private int x;
        private int y;


        //paramterized constructor -The constructor initializes two private integer variables x and y with the values passed as parameters.
        public Sum(int a, int b)
        {
            x = a;
            y = b;
        }

        //method to calculate the sum
        public int getSum()
        {
            return x + y;

        }
        public static void Main(string[] args)
        {
            //first instance of sum class
            Sum sum1 = new Sum(15, 20);

            Console.WriteLine($"Sum of x and y for first instance is: {sum1.getSum()}");

            //second instance of sum class
            Sum sum2 = new Sum(19, 47);

            Console.WriteLine($"Sum of x and y for second instance is: {sum2.getSum()}");

            Console.ReadKey();
        }
    }
}
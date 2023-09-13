using System;

namespace DefaultConstructors
{
    class Sum
    {
        private int x;
        private int y;


        //creation of default constructor

        public Sum()
        {
            x = 5;
            y = 15;
        }

        public int getSum()
        {
            int sum=0;
            sum = x + y;
            return sum;
        }
        static void Main(string[] args)
        {
            //creating the instance of the class

            Sum sum1 = new Sum();

            Console.WriteLine($"Sum of the instance 1 variables {sum1.getSum()}");

            Sum sum2 = new Sum();

            Console.WriteLine($"Sum of the instance 1 variables {sum2.getSum()}");

            Console.ReadKey();
        }
    }
}


using System;

namespace CopyConstructor
{
    class Sum
    {
        private int x;
        private int y;

        //parameterized constructor
        public Sum(int a, int b)
        {
            x=a; 
            y = b;
        }

        //copy constructor

        public Sum(Sum sum)
        {
            x = sum.x;
            y=sum.y;
        }

        //method to get the sum
        public int getSum()
        {
            return x+y;
        }

        public static void Main(string[] args)
        {
            //creating the first instance of the class 

            Sum sum1 = new Sum(15, 25);

            Console.WriteLine($"sum from the first instance is : {sum1.getSum()}");

            //invoking  the copy constructor
            Sum sum2 = new Sum(sum1);
            Console.WriteLine($"sum from the second/copied instance is : {sum2.getSum()}");


            Console.ReadKey();
        }
    }

}
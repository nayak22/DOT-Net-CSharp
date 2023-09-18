using System;

namespace Anonymous
{
    class Program
    {
        //delgate   - defining delagte
        public delegate void MyDelgate(int x, int y);

        static void Main(string[] args)
        {
            //initializing the object

            MyDelgate myDelgate = delegate (int x, int y)
            {
                Console.WriteLine($"Anonymous method parameters are {x} and {y}");
            };

            myDelgate(7, 11);

            Console.ReadLine();
        }
    }
}
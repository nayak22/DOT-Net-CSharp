using System;

namespace OddInRange
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> oddNums = Enumerable.Range(20, 45).Where(x => x % 2 != 0);

            foreach(int num in oddNums)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();


            //Second way
            /*
             
            Console.WriteLine("Enter the start of the range:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end of the range:");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
             
             */
        }


    }
}
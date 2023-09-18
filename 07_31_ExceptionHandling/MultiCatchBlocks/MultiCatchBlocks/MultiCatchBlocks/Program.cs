using System;

namespace MultiCatchBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 0, 3, 4, 5 };

            try
            {
                int divide = numbers[2] / numbers[1];
            }
            catch (IndexOutOfRangeException ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
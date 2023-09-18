using System;

class Program
{
    public static void Main(string[] args)
    {
        int divisor = 0;
        //outer try catch blocks
        try
        { 
            //inner try catch blocks
            try
            {
                int dividedByzero = 6 / divisor;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Inner try catchblock executed "+ex.Message);
            }

            
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Outer try catchblock executed " + ex.Message);
        }

        Console.ReadKey();
    }
}

    
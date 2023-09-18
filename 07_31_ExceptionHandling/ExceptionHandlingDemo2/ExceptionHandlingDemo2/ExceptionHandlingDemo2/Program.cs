using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] colors = { "Red", "Blue", "Green" };

        try
        {
            Console.WriteLine(colors[5]);
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Occure "+ex.Message);
        }

        Console.ReadLine();
    }
}
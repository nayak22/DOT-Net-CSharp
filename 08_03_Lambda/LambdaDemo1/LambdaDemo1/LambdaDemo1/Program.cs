using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 64;
        int num2 = 128;

        //intialilizing the lamba expression
        Func<int, double> SquareRoot=x=>Math.Sqrt(x);

        //calling the Lamba Expression Delgate
        Console.WriteLine($"Square Root of {num1} is {SquareRoot(num1)}");
        Console.WriteLine($"Square Root of {num2} is {SquareRoot(num2)}");

        Console.ReadKey();
    }
}
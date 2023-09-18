using System;

namespace DelgatesDemo2
{
    class Program
    {
        //deligate 
        public delegate int ProdDelegate(int x, int y);
        //define method to multiply 2 numbers
        static int CalculateProd(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            ProdDelegate prodDelegate= new ProdDelegate(CalculateProd);

            int prod = prodDelegate(45, 4);
            Console.WriteLine($"Product of the supplied numbers: {prod}");

            Console.ReadLine();

        }
    }
}
using System;
class Program
{
    // declaring or defining the delegate
    public delegate void MyDelegate(int x, int y);

    // Add method declaration
    static void Addition(int v1, int v2)
    {
        Console.WriteLine("Sum of 2 numbers is : {0}", v1 + v2);
    }

    // Subtraction method declaration
    static void Subtraction(int v1, int v2)
    {
        Console.WriteLine("Subtraction of 2 numbers is : {0}", v1 - v2);
    }

    // Multiply method declaration
    static void Multiply(int v1, int v2)
    {
        Console.WriteLine("Multiply of 2 numbers is : {0}", v1 * v2);
    }

    // Division method declaration
    static void Divison(int v1, int v2)
    {
        Console.WriteLine("Divison of 2 numbers is : {0}", v1 / v2);
    }

    static void Main(string[] args)
    {
        //intilizing the delgate
        MyDelegate myDelegate = new MyDelegate(Addition);

        //Adding of multiple methods to delegate using operators

        myDelegate += Subtraction;
        myDelegate += Multiply;
        myDelegate += Divison;


        //invoking the delegate

        myDelegate(20, 10);

        // remove of method from composite delegate

        Console.WriteLine("---------------------------\n");

        Console.WriteLine("After removal of Multiply method");

        myDelegate -= Multiply;

        myDelegate(20, 10);

        Console.ReadLine();

    }
}
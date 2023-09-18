using System;

namespace AbstractClass
{
    public abstract class M1
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
    }

    public class M2:M1 { 
        public int Mul(int x,int y)
        {
            return x * y;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //M1 m1 = new M1();//can be instantiated
            M2 m2 = new M2();
            Console.WriteLine(m2.Add(1, 2)); ;
            Console.WriteLine(m2.Mul(9, 36)); ;


            Console.Read();
        }
    }
}
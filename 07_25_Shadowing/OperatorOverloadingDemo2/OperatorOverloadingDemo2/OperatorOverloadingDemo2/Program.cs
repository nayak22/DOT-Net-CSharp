using System;


namespace OperatorOverloadingDemo
{

    class Length
    {
        int feet;
        int inch;
        public Length()
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        void printLength()
        {
            Console.WriteLine("Length : {0}' {1}", feet, inch);
        }
        public static Length operator +(Length l1, Length l2)
        {
            Length l3 = new Length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l2.inch;

            if (l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }

        public static bool operator >(Length l1, Length l2)
        {
            if (l1.feet > l2.feet)
            {
                return true;
            }
            else if (l1.feet == l2.feet)
            {
                if (l1.inch > l2.inch)
                    return true;
                else
                    return false;
            }
            else
            { return false; }

        }
        public static bool operator <(Length l1, Length l2)
        {
            if (l1.feet < l2.feet)
            {
                return true;
            }
            else if (l1.feet == l2.feet)
            {
                if (l1.inch < l2.inch)
                    return true;
                else
                    return false;
            }
            else
            { return false; }

        }
        static void Main(string[] args)
        {
            Length l1 = new Length(2, 8);
            Length l2 = new Length(4, 5);
            Length l3 = l1 + l2; // operator applying for 2 object operands

            l1.printLength();
            l2.printLength();
            l3.printLength();

            if (l1 > l2)
            {
                Console.WriteLine("Len1 is greater than L2");
            }
            else
            {
                Console.WriteLine("Len1 is less than L2");
            }
            Console.Read();
        }
    }
}

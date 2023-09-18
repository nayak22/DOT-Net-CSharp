using System;

namespace StructDemo
{
    struct User
    {
        public const string name = "Harshit";
        public string location;
        public int age;

        public User(string loc, int ag)
        { location = loc; age = ag; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Declare object with new Keyword
            User user = new User("Hydrabad",45);

            Console.WriteLine($"Name:{User.name},Location:{user.location}, Age{user.age}");

            //Declare without the new Keyword
            User user1;
            user1.location = "Guntur";
            user1.age = 25;
            Console.WriteLine($"Name:{User.name},Location:{user1.location}, Age{user1.age}");

            Console.ReadKey();

        }
    }
}
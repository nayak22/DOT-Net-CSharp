using System;

class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // initializing List
        List<string> names = new List<string>();

        // defining Action Lambda Expression
        Action<string> myDelegate = name =>
        {

            Console.WriteLine($"Passed Name : {name}");
            names.Add(name);

        };

        myDelegate("Suresh");
        myDelegate("Naresh");
        myDelegate("Venkat");

        Console.ReadLine();

    }
}

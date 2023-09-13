using System;

/*.
 This is a C# code snippet that demonstrates the use of the in keyword. The in keyword is used to pass a readonly reference of a variable to a method. This means that the method cannot modify the value of the argument, but it can still read its value.
 */

class Student
{
    public string Name { get; set; }
    public bool Enrolled { get; set; }
}

class InKeywordDemo
{
    static void Enroll(in Student student)
    {
        //Assigning new object would throw error
        //student=new Student(); //student is readonly property

        //We can still modify the properties with reference values
        student.Enrolled = true;

        /* the Enroll method takes an in parameter of type Student. Inside the method, the student parameter is marked as readonly, so attempting to assign a new value to it would result in a compile-time error. However, the method can still read the value of the student parameter and modify its properties.*/
    }

    static void Main(string[] args)
    {
        Student student = new Student();
        student.Enrolled = false;
        student.Name = "Test";

        Enroll(student);
        /*In the Main method, a new Student object is created and its Name and Enrolled properties are initialized. The Enroll method is then called with the student object as an argument. Inside the Enroll method, the Enrolled property of the student object is set to true*/

        Console.ReadKey();
    }
}

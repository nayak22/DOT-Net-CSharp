using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PartialClassDemo
{
    public partial class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public Employee()
        {
            this.EmpID = 3330;
            this.Name = "Ramesh";
            GenerateEmployeeID();

        }
        public void displayEmpDetails()
        {
            Console.WriteLine($"Emp Id: {this.EmpID} and Emp Name: {this.Name}");
        }
        partial void GenerateEmployeeID();
        
    }
    public partial class Employee
    {
        partial void GenerateEmployeeID()
        {
            this.EmpID = 3333;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.displayEmpDetails();


            Console.ReadLine();
        }
    }






}
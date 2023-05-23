using System;

namespace ConsoleApp1
{
    class InheritanceMultilevel
    {
        public static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Name = "Ramesh";
            m.EmployeeId = 123;
            m.Age = 27;
            m.Department = "Sales";
            m.GetDetails();
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        virtual public void GetDetails()
        {
            Console.WriteLine($"Name of the person : {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"Employee ID : {EmployeeId}");
        }
    }
    class Manager : Employee
    {
        public string Department { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"Department : {Department}");
        }
    }
}

using System;


namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
   // Student Class - here the parameters for the student is defined 
   // - parameters with their type is defined here

    internal class Student
    {
        public string name;
        public int age;
        public string department;


        // Default Constructor
        public Student()
        {
            Console.WriteLine("Default Constructor called");
        }

         //Parameterized Constructor
         public Student (string name, int age, string department)
        {
            this.name = name;
            this.age = age;
            this.department = department;
        }
    }

    // Demo Class

    internal class Constructors 
    {
        public static void Run()
        {
            Console.WriteLine("----- Default Constructor-----");

            //Calls Default Constructor
            Student student1 = new Student();

            Console.WriteLine();

            Console.WriteLine("------- Parameterized Constructor-----");

            // Calls Parameterized Constructor
            Student student2 = new Student("Vaibhavi", 21, "IT");

            Console.WriteLine($"Name : {student2.name}");
            Console.WriteLine($"Age  : {student2.age}");
            Console.WriteLine($"Department : {student2.department}");


        }
    }
}

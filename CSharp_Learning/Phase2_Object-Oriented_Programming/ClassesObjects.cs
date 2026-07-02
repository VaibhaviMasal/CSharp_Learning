using System;



namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{

   //Student Class
   internal class Student
    {
        public string name;
        public int age;
        public string department;
    }

    //Demo class
    internal class ClassesObjects
    {
        public static void Run()
        {
            Student student1 = new Student();

            student1.name = "Vaibhavi";
            student1.age = 21;
            student1.department = "IT";

            Student student2 = new Student();

            student2.name = "Rahul";
            student2.age = 20;
            student2.department = "CS";

            Console.WriteLine("Student 1");
            Console.WriteLine($"Name       : {student1.name}");
            Console.WriteLine($"Age        : {student1.age}");
            Console.WriteLine($"Department : {student1.department}");

            Console.WriteLine();

            Console.WriteLine("Student 2");
            Console.WriteLine($"Name       : {student2.name}");
            Console.WriteLine($"Age        : {student2.age}");
            Console.WriteLine($"Department : {student2.department}");


        }
    }
    }


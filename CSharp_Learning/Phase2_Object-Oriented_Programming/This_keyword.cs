using System;


namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    internal class StudentThis
    {
        public string name;
        public int age;

        public StudentThis(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    internal class ThisKeyword
    {
        public static void Run()
        {
            StudentThis student = new StudentThis("Vaibhavi", 21);

            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
        }
    }
}

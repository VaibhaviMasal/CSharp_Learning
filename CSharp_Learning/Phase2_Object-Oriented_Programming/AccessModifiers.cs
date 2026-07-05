using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{

    internal class Person
    {
        public string Name = "Vaibhavi";
        private int Age = 21;
        protected string City = "Pune";
        internal string College = "Trinity";
    }
    internal class AccessModifiers
    {
        public static void Run()
        {
            Person person = new Person();

            Console.WriteLine(person.Name);
            Console.WriteLine(person.College);

            // Cannot access Age & City due to its protection level i.e. access modifiers
            //Console.WriteLine(person.Age);
            //Console.WriteLine(person.City);
        }
    }
}

using System;


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

            // Error: Age and City cannot be accessed because of their access modifiers.           
            
            // private -> Accessible only inside Person class.
            // protected -> Accessible only inside Person and its derived classes.

            //Console.WriteLine(person.Age);
           //Console.WriteLine(person.City);
        }
    }
}

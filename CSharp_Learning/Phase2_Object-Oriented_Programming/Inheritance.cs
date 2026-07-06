using System;



namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    internal class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is Sleeping");
        }
    }

    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    internal class Inheritance
    {
        public static void Run()
        {
            Dog dog = new Dog();
            dog.Name = "Tommy";

            dog.Eat();
            dog.Sleep();
            dog.Bark();
        }
    }
}

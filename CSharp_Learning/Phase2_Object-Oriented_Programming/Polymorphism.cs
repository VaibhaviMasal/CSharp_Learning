using System;

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    internal class Animals
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    internal class Dogs : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    internal class Cat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Polymorphism
    {
        public static void Run()
        {
            // This is not creating an object
            // It is only creating a reference variable of type Animals
            Animals animal;

            // A Dog object is created.
            // The animal reference points to that Dog.
            animal = new Dogs();

            // C# checks the actual object, not just the reference type
            // Since the object is a Dog, it runs: Dog.MakeSound(0
            animal.MakeSound();


            // A Cat object is created
            animal = new Cat();

            // The same reference now points to a Cat. -> calling animal.MakeSound()
            animal.MakeSound();
        }
    }
}
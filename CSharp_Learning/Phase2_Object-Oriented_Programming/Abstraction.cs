using System;

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{

    // This is the Parent Class
    // abstract keyword in here tells C# that this class is incomplete
    // Here, Start() is incomplete - the functionality inside it is defined further in the Car and Bike class
    internal abstract class Vehicle
    {
        // This is an abstract method
        public abstract void Start();
    }


    // Child class - Car inherits Vehicle
    // Car receives everything from vehicle
    internal class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Starts with Key");
        }
    }


    // Bike inherits Vehicle
    internal class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike Starts with Button");
        }
    }


    // Demo class
    internal class Abstraction
    {
        public static void Run()
        {

            // This is not an object
            // It is a reference variable
            Vehicle vehicle;


            // car object is created here 
            vehicle = new Car();
            vehicle.Start();

            vehicle = new Bike();
            vehicle.Start();
        }
    }
}
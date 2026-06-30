
// contains built-in classes like console, math, convert, datetime etc.
using System;



// namespace groups related classes together and prevents naimg conflicts. 
namespace CSharp_Learning.Phase0_Fundamentals
{

    //class --> blueprint that contains related code.
    internal class Basics
    {
        // This is a method named Run. Whenever Program.cs calls Basics.Run(); .the code inside this method executes. 
        public static void Run()
        {
            // prints text to the console and then moves the cursor to the next line.
            //Console.WriteLine("Welcome to C# Learning");
            //Console.WriteLine("My name is Vaibhavi");
            //Console.WriteLine("I will become a .NET Developer.");

           
            Console.Write("Enter your name: ");
            string name =  Console.ReadLine();
            
            Console.Write("Enter your college name: ");
            string college = Console.ReadLine();
            
            Console.Write("Enter your branch: ");
            string branch = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("====== Student Details=====");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("College : " + college);
            Console.WriteLine("Branch : " + branch);
            Console.WriteLine("==============================");

        }
    }
}

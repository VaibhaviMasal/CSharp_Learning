using System;


namespace CSharp_Learning.Phase0_Fundamentals
{
    internal class Operators
    {
        public static void Run()
        {
            int a = 5;
            int b = 6;

            // Arithmetic
            Console.WriteLine(a + b);

            // Assignment
            int x = 7;

            //Comparison
            Console.WriteLine(a == b);

            //Logical 
            int age = 21;
            Console.WriteLine(age >= 18 || age <= 60);

            //Increment 
            int y = 5;
            Console.WriteLine(++y);


        }
    }
}

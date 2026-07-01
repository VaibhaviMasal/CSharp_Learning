using System;

namespace CSharp_Learning.Phase1_Methods
{
    internal class ReturnTypes
    {
       
        public static void Run()
        {
            int sum = Add (10, 20);
            int multiplication = Multiply(10, 20);

            Console.WriteLine($"Sum             : {sum}");
            int total = sum * 5;
            Console.WriteLine($"Total           : {total}"); 

            
            Console.WriteLine($"Multiplication  : {multiplication}");
        }
 
        // Add
        public static int Add (int a, int b)
        {
            return a + b;
        }

        // Multiply
        public static int Multiply (int a, int b)
        {
            return a * b;
        }

    }
}

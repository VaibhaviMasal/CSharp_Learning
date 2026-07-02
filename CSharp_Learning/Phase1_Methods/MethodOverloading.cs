using System;



namespace CSharp_Learning.Phase1_Methods
{
    internal class MethodOverloading
    {
        public static void Run()
        {
            int sum1 = Add(10, 20);
            double sum2 = Add (20.5, 30.6);
            int sum3 = Add(10, 20, 30);

            Console.WriteLine($"Sum1 : {sum1}");
            Console.WriteLine($"Sum2 : {sum2}");
            Console.WriteLine($"Sum3 : {sum3}");


        
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add (double a, double b)
        {
            return a + b;
        }

        public static int Add (int a, int b, int c)
        {
            return a + b + c;
        }
    }

    //Method Overloading -  Methos overloading is the process of creating multiple methods witht the same name but different parameters 

    // Normal Parameter , ref

   
    }

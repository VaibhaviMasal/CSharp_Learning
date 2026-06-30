using System;


namespace CSharp_Learning.Phase0_Fundamentals
{
    internal class Typecasting
    {
        public static void Run()
        {

            Console.WriteLine("==== Part A ====");
            // Part A int --> double (Implicit casting example)
            int age = 21;
            double convertedAge = age;
            Console.WriteLine("Age in int    : " + age);
            Console.WriteLine("Age in double : " + convertedAge);

            Console.WriteLine();
            

            Console.WriteLine("==== Part B ====");
            //Part B  double --> int (Explicit casting example)

            double percentage = 95.55;
            int percent = (int)percentage;
            Console.WriteLine("Percentage in double       : " + percentage);
            Console.WriteLine("Converted Percentage in int: " + percent);

            Console.WriteLine();

            Console.WriteLine("===== Part C ====");



            //Part C --> Take user input --> convert --> using Int32

            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            int Age = Convert.ToInt32(input);

            Console.WriteLine("Current Age  : " + input);
            Console.WriteLine("Age next year: " + (Age+1));

            Console.WriteLine();

            Console.WriteLine("===== Part D ====");

            //Part D string input --> using tryParse


            // Tryparse() using bool checks the success if the input is the expected input it returns true or else returns false ; it then checks the expected output if the expected output is in the form expected it returns the value or else it return 0
            string inputs = "Hello";
            bool success = int.TryParse(inputs, out int result);
            Console.WriteLine("Conversion successful :" + success);
            Console.WriteLine("Converted Value       :" + result);
                



        }

    }
}

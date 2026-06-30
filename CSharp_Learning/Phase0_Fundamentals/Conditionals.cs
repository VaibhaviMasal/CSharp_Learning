using System;


namespace CSharp_Learning.Phase0_Fundamentals
{
    internal class Conditionals
    {
        public static void Run()
        {
            // Conditionals - Conditionals allow the program to make decisions based on conditions 


            // if - loop
            int age = 20;
            if (age >= 18);
            {
                Console.WriteLine("Eligible to vote");
            }

            // if-else
            int age1 = 15;
            if (age1 >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            // else-if Ladder

            int marks = 85;
            if (marks >= 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // Nested if

            int age2 = 20;
            bool hasLicense = true;

            if (age >= 18)
            {
               if (hasLicense)
                {
                    Console.WriteLine("Can Drive");

                }

                // Switch 

                int day = 3;

                switch(day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case2:
                        Console.WriteLine("Tuesday");
                        break;

                    case3:
                        Console.WriteLine("Wednesday");
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                // Ternary Operator

                string status = age >= 18 ? "Adult" : "Minor";

            }
        }
    }
}

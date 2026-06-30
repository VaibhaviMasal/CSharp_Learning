using System;



namespace CSharp_Learning.Phase0_Fundamentals
{
    internal class Loops
    {
        public static void Run()
        {
            Console.WriteLine("== for loop ==");
            // for loop
            for (int i = 1; i <= 5; i++) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("== while loop ==");
            // while loop
            int a = 1;

            while (a <= 5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine();


            Console.WriteLine("== do-while loop ==");
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= 5);

            Console.WriteLine();

            // for each
            Console.WriteLine("== for each ==");

            string[] namess =
            {
                "Tara",
                "Rahul",
                "Amit"
            };

             foreach(string names in namess)
             {
                  Console.WriteLine(names);
              }

            // Arrays 
            int[] numbers = {10,20,30,40,50};
             // access
            Console.WriteLine(numbers[0]);
            //update 
            numbers[1] = 50;
            //length
            Console.WriteLine(numbers.Length);
            //loop
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Multidimensioanal array

            int[,] matrix =
            {
                {1,2 },
                {3,4}
            };


            // Strings 

            string name = "Bob";

            ///length
            Console.WriteLine(name.Length);

            //Uppercase
            Console.WriteLine(name.ToUpper());

            //Lowercase
            Console.WriteLine(name.ToLower());

            //contains
            Console.WriteLine(name.Contains("bh"));

            //replace
            Console.WriteLine(name.Replace("V","M"));

            //substring
            Console.WriteLine(name.Substring(0,4));

            //split 
            string text = "HTML,CSS,JS";
            string[] skills = text.Split(',');
            Console.WriteLine(skills);

            //trim
            Console.WriteLine(name.Trim());

            //String interpolation
            Console.WriteLine($"Name : {name}");

        }
    }
}

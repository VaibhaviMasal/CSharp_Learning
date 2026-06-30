using System;

namespace CSharp_Learning.Phase0_Fundamentals
{
    internal class DataTypes
    {
        public static void Run()
        {
            // datatype -> specifies what kind of value a variable can store.
            // int ->  datatype , age -> variable name, 20 -> value
            // Types -> Value Types => stores actual value ,
            // Reference type => stores the address

            int age = 20;
            float cgpa = 9.5f;
            byte on_off = 1;
            short num = 234;
            long numbs = 123654;
            double percent = 95.45;
            decimal salary = 450000.55m;
            char grade = 'A';
            bool attendance = true;
            string name = "vaibhavi";

            Console.WriteLine("Output");
            Console.WriteLine();

            Console.WriteLine("Age            : " + age);
            Console.WriteLine("CGPA           : " + cgpa);
            Console.WriteLine("On&Off         : " + on_off);
            Console.WriteLine("Single_Number  : " + num);
            Console.WriteLine("large_number   : " + numbs);
            Console.WriteLine("Percentage     : " + percent);
            Console.WriteLine("Salary         : " + salary);
            Console.WriteLine("Grade          : " + grade);
            Console.WriteLine("Attendance     : " + attendance);
            Console.WriteLine("Name           : " + name);



        }
    }
}

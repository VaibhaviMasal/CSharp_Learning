using System;


namespace CSharp_Learning.Phase1_Methods
{
    internal class Methods
    {
        public static void Run()
        {
            Welcome();
            DisplayCourse();

            DisplayCompany("Google");
            DisplayCompany("Microsoft");
            DisplayCompany("JP Morgan");
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to C# Learning!");
        }

        public static void DisplayCourse()
        {
            string company = "Kanini Software Solutions";
            string location ="Kharadi";
            string domain = ".NET development";

            Console.WriteLine($"Company Name            : {company}");
            Console.WriteLine($"Location                :  {location}");
            Console.WriteLine($"Domain                  : {domain}"  );
        } 

        public static void DisplayCompany(string companyName)
        {
            Console.WriteLine($"Company Name : {companyName}");
        }

    }
}

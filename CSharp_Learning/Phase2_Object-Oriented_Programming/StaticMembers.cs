using System;


namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    // static :
    // belongs to class.
    // Access using ClassName.Member
    // Only one copy exists.

    // Class wheere only the variables are declared.

    // Represents a bank account



    internal class BankAccount
    {
        public string AccountHolder;
        public static string BankName = "State Bank Of India";


    }

    // Main class here ; objects are created and called
    internal class StaticMembers
    {
        public static void Run()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.AccountHolder = "Vaibhavi";
            account2.AccountHolder = "Rahul";

            Console.WriteLine(account1.AccountHolder);
            Console.WriteLine(account2.AccountHolder);

            Console.WriteLine(BankAccount.BankName);

        }
    }
}

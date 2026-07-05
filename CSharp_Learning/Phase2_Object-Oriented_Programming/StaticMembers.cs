using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    // static :
    // belongs to class.
    // Access using ClassName.Member
    // Only one copy exists.

    // Class wheere only the variables are declared.
    internal class BankAccount
    {
        public string accountHolder;
        public static string bankName = "State Bank Of India";


    }

    // Main class here ; objects are created and called
    internal class StaticMembers
    {
        public static void Run()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.accountHolder = "Vaibhavi";
            account2.accountHolder = "Rahul";

            Console.WriteLine(account1.accountHolder);
            Console.WriteLine(account2.accountHolder);

            Console.WriteLine(BankAccount.bankName);

        }
    }
}

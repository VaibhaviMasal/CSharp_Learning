using System;
 

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{

    // This class represents a bank account. It stores all the information and operations related to a bank account
    internal class BankAccounts
    {
        // step 1
        // private variable; only BankAccounts can access it
        private double balance;

        //step 2
        // This method allows the user to deposit money into the account
        // Instead of directly changing the balance, the user must use this method.
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        //step 3

        // This method displays the current balance
        // Instead of giving direct access to the variable, we provide a method to display it.
        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }
    }


    // Demo Class-
        internal class Encapsulation
        {
            public static void Run()
            {

            // This creates a BankAccouns object

                BankAccounts account = new BankAccounts();
                account.Deposit(5000);
                account.Deposit(-200);
                account.DisplayBalance();
            }
        }
}


using System;

namespace CSharp_Learning.Phase2_Object_Oriented_Programming
{
    internal interface IPayment
    {
        void Pay();
    }

    internal class UPIPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment through UPI");
        }
    }

    internal class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment through Card");
        }
    }

    internal class Interfaces
    {
        public static void Run()
        {
            IPayment payment;

            payment = new UPIPayment();
            payment.Pay();

            payment = new CardPayment();
            payment.Pay();
        }
    }
}
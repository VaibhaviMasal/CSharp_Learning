using System;


namespace CSharp_Learning.Phase1_Methods
{
    internal class Short_topics
    {
        public static void Run()
        {
            // ----- ref ------ 
            int x = 10;
            Change1(ref x);
            Console.WriteLine(x);
            Console.WriteLine("The original value: " + x);
            // ouput = 10; because C# sends a copy of x.


            // ---- out ------
            int age;
            GetValues(out age);
            Console.WriteLine(age);

            //---- params -----
            int sum1 = Add(10, 20);
            int sum2 = Add(10, 20, 30);
            int sum3 = Add(10, 20, 30, 40);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            //--- recursion -
            Print(5); 
        }

        // using ref

        public static void Change1 (ref int number)
        {
            number = 100;
        }


        // using out

        public static void GetValues(out int age)
        {
            age = 20;
        }
        
        // params
        public static int Add (params int[] numbers)
        {
            int sum = 0;

            foreach(int n in numbers)
            {
                sum = sum + n;
            }
            return sum;
        }

        // recursion -  is a method calling itself
        public static void Print (int n)
        {
            if (n==0)
                return;

            Console.WriteLine(n);
            Print(n - 1);

        }       

    }
}


// --------------------------------------------------
//| Feature     | Purpose                           |
//| ----------- | --------------------------------- |
//| Parameter   | Variable in method definition     |
//| Argument    | Value passed to method            |
//| Return      | Sends value back                  |
//| Overloading | Same method, different parameters |
//| Optional    | Default value                     |
//| Named       | Pass by parameter name            |
//| ref         | Pass original variable            |
//| out         | Return value through parameter    |
//| params      | Variable number of arguments      |
//| Recursion   | Method calling itself             |
//---------------------------------------------------
 

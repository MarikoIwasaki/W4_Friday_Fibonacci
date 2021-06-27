using System;

namespace W4_Friday_Fibonacci
{
    /*) Write a function called Fibonacci() that takes one integer number as parameter. The function will find Fibonacci series and then print the results on the screen.Input: 10
     */
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            //n represent number of fibonacci serieses
            for(int i=0; i<n; i++)
            {
                int tem = a;
                a = b;
                b = tem + b;
            }
            return a;
        }
        static void Main(string[]args)
        {
            // call fibonacci function in main

            for (int i=0; i < 10; i++)
                {
                //fibonacci series up to 10
                Console.WriteLine(Fibonacci(i));
            }
            Console.Read();
        }
    }
}

using System;

namespace TP1
{
    public class Exercise2
    {
        /// <summary>
        /// This function calculates and displays all the prime numbers from 0 to 1000.
        /// </summary>
        public void Prime()
        {
            for (int num = 2; num <= 1000; num++)
            {
                int divisorNumber = 0;
                for (int div = 1; div <= num; div++)
                {
                    if (num % div == 0)
                    {
                        divisorNumber++;
                    }
                }
                if (divisorNumber == 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
        /// <summary>
        /// This function calculates and diaplys the result of the fibonacci function on a positive integer.
        /// </summary>
        public void F()
        {
            int n = AskUserForParameter();

            if (n == 1)
            {
                Console.WriteLine("F(" + 1 + ") = " + 1);

            }
            else
            {
                int resultNmoins1 = 0;
                int resultNmoins2 = 1;
                int tmp = 0;
                for (int i = 0; i <= n; i++)
                {
                    tmp = resultNmoins1;
                    resultNmoins1 = resultNmoins1 + resultNmoins2;
                    resultNmoins2 = tmp;
                }
                Console.WriteLine("F(" + n + ") = " + resultNmoins2);
            }
        }
        /// <summary>
        /// This function calculates and displays the result of the factorial function on a positive integer.
        /// </summary>
        public void Factorial() {
            int n = AskUserForParameter();
            
            if (n == 0)
            {
                Console.WriteLine(0 + "! = " + 1);
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                Console.WriteLine(n + "! = " + result);
            }
        }
        
        /// <summary>
        /// This function asks an integer to the user and return this integer.
        /// </summary>
        /// <returns></returns>
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please enter a positive integer and press enter :");
            bool boolResult = int.TryParse(Console.ReadLine(), out var result);
            while(!boolResult || result < 0)
            {
                Console.WriteLine("You didn't enter an integer or it is negative. Please enter a positive integer and press enter :"); 
                boolResult = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
    }
}
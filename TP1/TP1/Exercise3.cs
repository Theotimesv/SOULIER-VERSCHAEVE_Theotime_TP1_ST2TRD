using System;

namespace TP1
{
    public class Exercise3
    {
        /// <summary>
        /// This function calculates and displays the result of the function  F(x) = 10/(x²-4) with -3 <= x <= 3.
        /// </summary>
        public void Function()
        {
            for (int x = -3; x <= 3; x++)
            {
                int denominator = PowerFunction(x);
                try
                {
                    Console.WriteLine(10 / denominator);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: dividing by 0");
                }
            }
        }
        
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
    }
}
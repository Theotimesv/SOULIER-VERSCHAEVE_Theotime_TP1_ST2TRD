using System;

namespace TP1
{
    public class Exercise1
    {
        /// <summary>
        /// This function calculates and displays all the multiplication tables from 1 to 10.
        /// </summary>
        public void PrintMultiplicationTable()
        {
            for(int i=1 ; i<=10 ;i++){
                Console.WriteLine("Table of " + i + ":");
                for (int j = 1; j <= 10; j++) {
                    Console.WriteLine(i + " * " + j + " = " + i*j);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This function calculates and displays all the odd result of multiplication tables from 1 to 10.
        /// </summary>
        public void PrintOddNumbers()
        {
            for(int i=1 ; i<=10 ;i++){
                for (int j = 1; j < 10; j++)
                {
                    int result = i * j;
                    if (result % 2 != 0)
                    {
                        Console.WriteLine(i + " * " + j + " = " + i*j);
                    }
                }
            }
        }

        /// <summary>
        /// This function calculates and displays the multiplication table of the user's choice.
        /// </summary>
        public void ChoseMyTable()
        {
            int number = AskUserForParameter();
            Console.WriteLine("Table of " + number + ":");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }
        }
        /// <summary>
        /// This function asks an integer to the user and return this integer.
        /// </summary>
        /// <returns></returns>
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please enter an integer and press enter :");
            bool boolResult = int.TryParse(Console.ReadLine(), out var result);
            while(!boolResult)
            {
                Console.WriteLine("You didn't enter an integer. Please enter an integer and press enter :"); 
                boolResult = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
    }
}
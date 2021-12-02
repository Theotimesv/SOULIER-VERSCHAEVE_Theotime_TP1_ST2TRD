using System;

namespace TP1
{
    public class Exercise1
    {
        public void PrintMultiplicationTable()
        {
            for(int i=1 ; i<=10 ;i++){
                Console.WriteLine("Table of " + i + ":");
                for (int j = 1; j < 10; j++) {
                    Console.WriteLine(i + " * " + j + " = " + i*j);
                }
                Console.WriteLine();
            }
        }

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

        public void ChoseMyTable()
        {
            int number = AskUserForParameter();
            Console.WriteLine("Table of " + number + ":");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }
        }

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
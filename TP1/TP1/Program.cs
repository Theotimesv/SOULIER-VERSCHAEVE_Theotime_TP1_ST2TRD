using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            
            Console.WriteLine("Exercise 1:\n");
            Exercise1 ex1 = new Exercise1();
            Console.WriteLine("Multiplication tables:\n");
            ex1.PrintMultiplicationTable();
            Console.WriteLine("\nOdd numbers:\n");
            ex1.PrintOddNumbers();
            Console.WriteLine("\nChoice of the Table:\n");
            ex1.ChoseMyTable();
            
            //Exercise 2
            Console.WriteLine("\nExercise 2:\n");
            Exercise2 ex2 = new Exercise2();
            Console.WriteLine("Prime numbers:\n");
            ex2.Prime();
            Console.WriteLine("\nFibonaci function:\n");
            ex2.F();
            Console.WriteLine("\nFactorial function:\n");
            ex2.Factorial();
            //C. 420000! returns 0.
            //D. A recursive function is a function that calls itself
            
            //Exercice 3
            Console.WriteLine("\nExercise 3:\n");
            Exercise3 ex3 = new Exercise3();
            ex3.Function();
            
            //Exercise 4
            Console.WriteLine("\nExercise 4:\n");
            Exercise4 ex4 = new Exercise4();
            ex4.DrawRectangle();
            
            //Exercise 5
            Console.WriteLine("\nExercise 5:\n");
            Exercise5 ex5 = new Exercise5();
            Console.WriteLine("Regular Tree:\n");
            ex5.DrawRegularTree();
            Console.WriteLine("\nTree with choice to decorate:\n");
            ex5.DrawDecoratedTree();
        }
    }
}
using System;
using System.Dynamic;

namespace TP1
{
    public class Exercise4
    {
        public void DrawRectangle()
        {

            Rectangle rectangle = getDimensions();

            int n = rectangle.GetN();
            int m = rectangle.GetM();
            
            Draw(n,m);

        }

        public Rectangle getDimensions()
        {
            Console.WriteLine("Please enter the dimensions in the following format: dim1,dim2");
            string answer = Console.ReadLine();
            
            answer = CheckCommaExists(answer);

            string[] splitted_answer = answer.Split(',');
            
            bool boolResult1;
            bool boolResult2;

            //check split en 3
            boolResult1 = int.TryParse(splitted_answer[0], out var dim1);
            boolResult2 = int.TryParse(splitted_answer[1], out var dim2);

            while(!boolResult1 || !boolResult2 || dim1 < 0 || dim2 < 0)
            {
                Console.WriteLine("The format is wrong. Please enter the dimensions in the following format: dim1,dim2 :");
                answer = Console.ReadLine();
                answer = CheckCommaExists(answer);
                splitted_answer = answer.Split(',');
                boolResult1 = int.TryParse(splitted_answer[0], out dim1);
                boolResult2 = int.TryParse(splitted_answer[1], out dim2);
            }
            return new Rectangle(dim1, dim2);
        }

        public string CheckCommaExists(string s)
        {
            while (!s.Contains(','))
            {
                Console.WriteLine("The format is wrong. Please enter the dimensions in the following format: dim1,dim2 :");
                s = Console.ReadLine();
            }
            return s;
        }
        
        public void Draw(int n, int m){
            for (int line = 0; line <= n; line++) {
                for (int col = 0; col <= m; col++) {
                    if (line == 0 || line == n) {
                        if (col == 0 || col == m) {
                            Console.Write(0);
                        }
                        else {
                            Console.Write("-");
                        }
                    }
                    else {
                        if (col == 0 || col == m) {
                            Console.Write("|");
                        }
                        else {
                            if (((col+line*2+3)%3 == 0))
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
    public class Rectangle
    {
        private int N;
        private int M;

        public Rectangle(int n, int m)
        {
            this.N = n;
            this.M = m;

        }
            
        public int GetN()
        {
            return N;
        }
            
        public int GetM()
        {
            return M;
        }
    }
}
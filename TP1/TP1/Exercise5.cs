using System;
namespace TP1
{
    public class Exercise5
    {
        public void DrawRegularTree()
        {
            int treeHight = AskUserForParameter();

            for (int line = 0; line < treeHight; line++)
            {
                string s = "*";
                for (int i = 1; i <= (line*2); i++)
                {
                    s += "*";
                }
                Console.WriteLine(s.PadLeft(treeHight*2-(treeHight-line)));
            }
            Console.WriteLine("| |".PadLeft(treeHight+1));
        }
        
        public void DrawDecoratedTree()
        {
            int treeHight = AskUserForParameter();
            bool answerDecoration = AskUserForDecoration();
            Draw(treeHight,answerDecoration);
        }

        public void Draw(int treeHight, bool answerDecoration)
        {
            int oNumber = 0;
            int iNumber = 0;
            int randomNum = 0;
            Random rd = new Random();
            
            for (int line = 0; line < treeHight; line++) {
                string s = "";
                for (int i = 0; i <= (line*2); i++) {
                    if ((((i)%3 + (line)%3))%3 == 1 && answerDecoration) {
                        if (oNumber >= (iNumber)) {
                            s += "i";
                            iNumber++;
                        } else {
                            randomNum = rd.Next(2);
                            if (randomNum == 0) {
                                s += "o";
                                oNumber++;
                            } else {
                                s += "i";
                                iNumber++;
                            }
                        }
                    } else {
                        s += "*";
                    }
                }
                Console.WriteLine(s.PadLeft(treeHight*2-(treeHight-line)));
            }
            Console.WriteLine("| |".PadLeft(treeHight+1));
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please enter the hight of the tree as an integer between 3 and 20 then press enter :");
            bool boolResult = int.TryParse(Console.ReadLine(), out var result);
            while(!boolResult || result < 3 || result > 20)
            {
                Console.WriteLine("You didn't enter an integer or it is out of bounds. Please enter an integer between 3 and 20 then press enter :"); 
                boolResult = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        public bool AskUserForDecoration()
        {
            Console.WriteLine("Do you want to decorate your tree ? y/n :");
            string answer = Console.ReadLine();

            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Please enter y or n :");
                answer = Console.ReadLine();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
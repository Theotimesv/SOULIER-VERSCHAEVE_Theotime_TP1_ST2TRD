using System;
namespace TP1
{
    public class Exercise5
    {
        /// <summary>
        /// This function asks to the user a hight and displays a regular christmas tree.
        /// </summary>
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
        
        /// <summary>
        /// This function asks to the user a hight, if he wants to decorate it, and displays a regular or a decorated
        /// christmas tree given the choice.
        /// </summary>
        public void DrawDecoratedTree()
        {
            int treeHight = AskUserForParameter();
            bool answerDecoration = AskUserForDecoration();
            Draw(treeHight,answerDecoration);
        }
        
        /// <summary>
        /// This function displays a christmas tree given the hight chosen by the user and his choice to decorate it or
        /// not.
        /// </summary>
        /// <param name="treeHight">Hight of the christmas tree</param>
        /// <param name="answerDecoration">Boolean correspond to the user's choice to decorate the tree or not.
        /// If answerDecoration is true, the tree is decorated, if not, the tree is not decorated.</param>
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
        
        /// <summary>
        /// This function asks an integer to the user and return this integer.
        /// </summary>
        /// <returns>Returns an integer between 3 and 20 included.</returns>
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

        /// <summary>
        /// This function asks the user to answer y or n and returns a boolean accordingly.
        /// </summary>
        /// <returns>Returns true if y is entered. Returns false if n is entered.</returns>
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
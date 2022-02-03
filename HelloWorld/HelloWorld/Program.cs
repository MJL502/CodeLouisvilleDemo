using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        public static string FunctionSelection = string.Empty;
        public static int functionToPerform;
        public static bool exit;

        static void Main(string[] args)
        {
            UserMenu();

            UserSelection();    
        }

        static void UserMenu()
        {
            Console.WriteLine("This program can perform 3 functions:");
            Console.WriteLine("If you would like to learn the Aphpabet enter '1'");
            Console.WriteLine("If you would like to learn the Alphabet backwards enter '2'");
            Console.WriteLine("If you would like to see the Alphabet with skipped letters enter '3'");
            Console.WriteLine("You can press '4' to exit this program.");
            Console.WriteLine("Please enter your selection and press enter.");
            FunctionSelection = Console.ReadLine();

            while ((int.TryParse(FunctionSelection, out functionToPerform) == false) || (functionToPerform <= 0) || (functionToPerform >= 5))
            {
                Console.WriteLine("You did not enter a valid selection.  Please type 1, 2, 3, or 4 and press enter.");
                FunctionSelection = Console.ReadLine();
            }

            functionToPerform = int.Parse(FunctionSelection);
        }

        static void UserSelection()
        {
            if (int.TryParse(FunctionSelection, out functionToPerform))
            {
                functionToPerform = int.Parse(FunctionSelection);

                while (exit == false)
                {
                    switch (functionToPerform)
                    {
                        case 1:
                            Console.WriteLine(CreateAlphabet());
                            Console.WriteLine("\n");
                            UserMenu();
                            break;

                        case 2:
                            string backwards = CreateAlphabetBackwards();
                            Console.WriteLine(backwards);
                            Console.WriteLine("\n");
                            UserMenu();
                            break;

                        case 3:
                            Console.Write("How many letters would you like to skip: ");
                            string userInput = Console.ReadLine();

                            int numberToSkip;

                            if (int.TryParse(userInput, out numberToSkip))
                            {
                                numberToSkip = int.Parse(userInput) + 1;
                            }
                            else
                                while (int.TryParse(userInput, out numberToSkip) == false)
                                {
                                    Console.WriteLine("You did not enter a number.  Please enter a number.");
                                    userInput = Console.ReadLine();
                                }
                            numberToSkip = int.Parse(userInput) + 1;

                            Console.WriteLine(CreateAlphabetSkip(numberToSkip));
                            Console.WriteLine("\n");
                            UserMenu();
                            break;

                        case 4:
                            exit = true;
                            Console.WriteLine("Good Bye.");
                            break;

                        default:
                            //is this default line necessary
                            break;

                    }
                }
            }
        }

        static string CreateAlphabet()
        {
            //Alphabet, all caps, in a string, without string builder

            string alphabet = "";

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabet += letter;
            }
                return alphabet;
        }

        static string CreateAlphabetBackwards()
        {
            //Alphabet, in reverse, all caps, in a string, using string builder
        
            StringBuilder alphabetReverse = new StringBuilder("");

            for (char letter = 'Z'; letter >= 'A'; letter--)
            {
                alphabetReverse.Append(new char[] {letter});
            }

            return alphabetReverse.ToString();
        }

        static string CreateAlphabetSkip(int skip)
        {
            //Alphabet, every other letter, all caps, in a string, using string builder

            StringBuilder alphabetEveryOther = new StringBuilder("");

            for (char letter = 'A'; letter <= 'Z'; letter = (char)(letter + skip))
            {
                alphabetEveryOther.Append(new char[] {letter});
            }
            return alphabetEveryOther.ToString();
        }
    }
}

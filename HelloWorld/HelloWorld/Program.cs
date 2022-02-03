using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateAlphabet());

            string backwards = CreateAlphabetBackwards();
            Console.WriteLine(backwards);

            Console.Write("How many letters would you like to skip: ");
            string userInput = Console.ReadLine();

            int numberToSkip;

            if (int.TryParse(userInput, out numberToSkip))
            {
                numberToSkip = int.Parse(userInput) + 1;
            }
            else
                while(int.TryParse(userInput, out numberToSkip) == false)
                {
                    Console.WriteLine("You did not enter a number.  Please enter a number.");
                    userInput = Console.ReadLine();
                }
            numberToSkip = int.Parse(userInput) + 1;

            Console.WriteLine(CreateAlphabetSkip(numberToSkip));

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

using System;
using System.Text;

namespace AlphabetWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alphabet, all caps, in a string, using string builder
            Console.WriteLine("This will create a string to write the alphabet.\nPress ENTER to continue.");
            Console.ReadLine();

            StringBuilder alphabet = new StringBuilder("");

            for (char letter = 'A'; letter <='Z'; letter++)
            {
                alphabet.Append(new char[] {letter});
            }
           
                Console.WriteLine($"{alphabet} \n \n");


            //Alphabet, in reverse, all caps, in a string, using srting builder
            Console.WriteLine("This will create a string to write the alphabet in reverse.\nPress ENTER to continue.");
            Console.ReadLine();

            StringBuilder alphabetReverse = new StringBuilder("");

            for (char letterReverse = 'Z'; letterReverse >= 'A'; letterReverse--)
            {
                alphabetReverse.Append(new char[] {letterReverse});
            }

                Console.WriteLine($"{alphabetReverse} \n \n");


            //Alphabet, every other letter, all caps, in a string, using string builder
            Console.WriteLine("This will create a string to write every other letter of the alphabet.\nPress ENTER to continue.");
            Console.ReadLine();

            StringBuilder alphabetEveryOther = new StringBuilder("");

            for (char letter = 'A'; letter <= 'Z'; letter++, letter++)
            {
                {
                    alphabetEveryOther.Append(new char[] {letter});
                }
            }
                Console.WriteLine($"{alphabetEveryOther}");

        }
    }
}

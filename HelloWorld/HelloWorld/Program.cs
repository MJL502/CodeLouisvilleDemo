namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nPress ENTER to continue.");

            Console.ReadLine();

            Console.WriteLine("You thought all I could say was Hello World?");

            Console.ReadLine();

            Console.WriteLine("How old are you?");

            string yourAgeText = Console.ReadLine();
            int myAge = 37;
            int yourAge;

            bool success = int.TryParse(yourAgeText, out yourAge);

            if (success == false)
            {
                Console.WriteLine("Your age must be entered as a whole number.\nPlease enter a whole number... and don't get fancy and write it out with words.\nJust type the number.\nHow old are you?");
            
            //add loop here
            
            
            }
            
            if (success == true)
                {
                    if (myAge > yourAge)
                    {
                        int iAmOlder = myAge - yourAge;
                        Console.WriteLine($"I am {iAmOlder} years older than you.  This bootcamp is kicking my old ass.  Maybe you could help me.");
                    }

                    if (myAge < yourAge)
                    {
                        int iAmYounger = yourAge - myAge;
                        Console.WriteLine($"You have {iAmYounger} years more experience than me.  I am struggling to undertand some of the more advanced conepts.  Maybe you could help me.");
                    }

                    if (myAge == yourAge)
                    {
                        Console.WriteLine($"We are the same age.  How do you understand this so well?  You must have technical background.  Maybe you could help me.");
                    }
                }
            }
        }
    }

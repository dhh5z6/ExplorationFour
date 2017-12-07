using System;

//Namespace
namespace NumerGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            string name = "David Heritage";
            int age = 23;
            //Start Here
            Console.WriteLine(name + " is " + age);

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David Heritage";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game... ", inputName);

            //int correctNumber = 7;

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an actual number.");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();

                    }

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You did it!");
                Console.ResetColor();

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}

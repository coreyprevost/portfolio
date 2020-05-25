using System;
//Namespace
namespace NumbersGuesser
{
    //Main Class
    class Program
    {   //Entry Point Method
        static void Main(string[] args)
        {
            //Run GetAPPINfo function to get info
            GetAppInfo();

            GreetUser(); //Ask for users name and greet

            while (true)
            {


                //Init correct number
                //int correctNumber = 7;

                //create random number to be guessed
                Random random = new Random();
                //init correct number
                int correctNumber = random.Next(1, 10);



                //Init guess var
                int guess = 0;
                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");
                //while guess is not correct
                while (guess != correctNumber)
                {

                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "That's not a number silly!");
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess

                    guess = Int32.Parse(input);

                    //Math guess to correct number 
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");

                    }


                }

                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You win ,shouts out to you");
                //ask to play again
                Console.WriteLine("Play again? [Y or N]");
                //Get Answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }
        }
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Corey Prevost";



            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;
            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //reset text color
            Console.ResetColor();

          
            }
        //Ask user name and greet
         static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;
            //Tell user its not a number
            Console.WriteLine(message);
            //reset text color
            Console.ResetColor();
        }
    }

}

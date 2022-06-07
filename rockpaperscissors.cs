using System;

namespace rockpaperscissors
{
    class MainClass
    {
        //Get player choice
        public static string playerChoice()
        {
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "rock":
                    return "Rock";
                case "paper":
                    return "Paper"; 
                case "scissors":
                    return "Scissors";
                default:
                    return "Quit";
            }
        }

        //Return the Computer random choice
        public static string computerChoice()
        {
            Random random = new Random();
            int choice = random.Next(3); //random int from 0 to 2

            switch (choice)
            {
                case 0:
                    return "Rock";
                case 1:
                    return "Paper";
                case 2:
                    return "Scissors";
                default:
                    return "Quit";
            }
        }

        //Verify if the player or the computer won
        public static string winner(string userInput, string computerInput)
        {
            if (userInput == computerInput)
            {
                return "Tie";
            } else if (userInput == "Rock" && computerInput == "Scissors")
            {
                return "You Win!";
            } else if (userInput == "Scissors" && computerInput == "Paper")
            {
                return "You Win!";
            } else if (userInput == "Paper" && computerInput == "Rock")
            {
                return "You Win!";
            }
            else
            {
                return "Computer Wins!";
            }
        }

        public static void solve()
        {
            while (true)
            {
                Console.WriteLine("Rock, Paper, Scissors!\n");
                string userInput = playerChoice();

                if (userInput == "Quit")
                {
                    Environment.Exit(0); //exit
                }

                Console.WriteLine($"You choose: {userInput}");
                string computerInput = computerChoice();
                Console.WriteLine($"Computer choose: {computerInput}");
                Console.WriteLine(winner(userInput, computerInput));

            }
        }

        public static void Main(string[] args)
        {
            solve();
        }
    }
}

using System;

namespace RandomGenerator
{
    class Entry:Core
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to digital Rock Paper Scissors Lizard Spock \n The rules of course, are as follows: \n Scissors cuts paper \n Paper covers rock \n Rock crushes lizard \n Lizard posions Spock \n Spock smashes scissors \n Scissors decapitates lizard \n Lizard eats paper \n Paper disproves Spock \n Spock vaporizes rock \n And as it always has, rock crushes scissors");
            Core.Init();
        }
    }
    class Core:Game
    {
        public static void Init()
        {
            Selection();
            Choice();
            Play();
        }
    }
    class Game:Outcome
    {
        public static void Play()
        {
            if (acceptedResponse == true)
            {
                Decide();
                Core.Init();
            }
            else
            {
                Console.WriteLine("That's not an option.");
                Choice();
                Core.Init();
            }
        }
    }
    class Selector:Selected
    {
        public static Random randGuess = new Random();
        public static int number;
        public static string opponentSelect;
        public static void Selection()
        {
            number = randGuess.Next(1, 5);
            if (number == 1)
                opponentSelect = "rock";
            else if (number == 2)
                opponentSelect = "paper";
            else if (number == 3)
                opponentSelect = "scissors";
            else if (number == 4)
                opponentSelect = "lizard";
            else
                opponentSelect = "spock";
        }
    }
    class Selected
    {
        public static bool acceptedResponse;
        public static string response;
        public static void Choice()
        {
            response = Console.ReadLine();
            response = response.ToLower();
            if (response.Equals("rock"))
                acceptedResponse = true;
            else if (response.Equals("paper"))
                acceptedResponse = true;
            else if (response.Equals("scissors"))
                acceptedResponse = true;
            else if (response.Equals("lizard"))
                acceptedResponse = true;
            else if (response.Equals("spock"))
                acceptedResponse = true;
            else
                acceptedResponse = false;
        }
    }
    class Outcome:Selector
    {
        public static void Decide()
        {
            if (opponentSelect == "rock")
            {
                if (response == "paper")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "spock")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "scissors")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else if (response == "lizard")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else
                {
                    Console.WriteLine("You... tied?");
                }
            }
            else if (opponentSelect == "paper")
            {
                if (response == "scissors")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "lizard")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "rock")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else if (response == "spock")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else
                {
                    Console.WriteLine("You... tied?");
                }
            }
            else if (opponentSelect == "scissors")
            {
                if (response == "rock")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "spock")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "scissors")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else if (response == "lizard")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else
                {
                    Console.WriteLine("You... tied?");
                }
            }
            else if (opponentSelect == "lizard")
            {
                if (response == "rock")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "scissors")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "paper")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else if (response == "spock")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else
                {
                    Console.WriteLine("You... tied?");
                }
            }
            else
            {
                if (response == "paper")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "lizard")
                {
                    Console.WriteLine("You win! They picked " + opponentSelect);
                }
                else if (response == "scissors")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else if (response == "rock")
                {
                    Console.WriteLine("You lost! They picked " + opponentSelect);
                }
                else
                {
                    Console.WriteLine("You... tied?");
                }
            }
        }
    }
}

using System;

namespace RockPaperScissorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ultimate Rock, Paper, Scissors!");
            Console.WriteLine("1) Play the game");
            Console.WriteLine("2) Calculate your winning percentage");
            Console.WriteLine("3) Exit");
            Console.WriteLine("Enter a number to choose an option: ");
            string option = Console.ReadLine();

            switch (option) :
            { 
                case 1:
                    option
            }

            Console.ReadLine();
        }

        static void Game()
        {
            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 5 && scoreCPU < 5)
                {



                    Console.WriteLine("choose between Rock, Paper and Scissors: ");
                    inputPlayer = Console.Readline();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                }

                if (scorePlayer == 5)
                {
                    Console.WriteLine("Player Won");
                }
                else if (scoreCPU == 5)
                {
                    Console.WriteLine("CPU Won");
                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string again = Console.ReadLine();
                if (again == "y")
                {
                    playAgain = true;
                }
                else if (again == "n") 
                {
                    playAgain = false;
                }
            }
        }
    }   
        
        
        static float WinPercentage() 
        {
        Console.WriteLine("How many games did you play? ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many games did you win? ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Convert.ToDecimal(Console.WriteLine(num2 / num1));






        Console.ReadLine();
        }
    }
}

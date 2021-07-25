﻿using System;

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

            while (option = 1)
            {
            
            }

            Console.ReadLine();
        }

        static void Game() 
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

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

        static void WinPercentage() 
        {
        
        }
    }
}

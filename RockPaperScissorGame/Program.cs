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

            while (option = 1)
            {
            
            }

            Console.ReadLine();
        }

        static void Game() 
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("choose between Rock, Paper and Scissors: ");
            inputPlayer = Console.Readline();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt) 
            {
            
            }

        }

        static void WinPercentage() 
        {
        
        }
    }
}

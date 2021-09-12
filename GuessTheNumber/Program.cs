using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        static void GameOver()
        {
            Console.WriteLine("Game Over!");
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("I'm thinking of a number between 1 and 100, you have 5 guesses");

            int number = RandNumber();
            bool won = false;
            int tries = 0;
            while ((won != true) || (tries < 5)) //keep looping while player hasnt won.
            {
                Console.Write($"Guess number {tries + 1}: Guess a Number..");
                System.Diagnostics.Debug.WriteLine($"tries = {tries}");
                
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < number)
                {
                    Console.WriteLine("You guessed too low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("You guessed too high");
                }
                else if (guess == number)
                {
                    Console.WriteLine($"Congratulations, You guessed correctly, I was indeed thinking of {number}");
                    won = true;
                }

                tries++;
            }

            GameOver();

            static int RandNumber()
            {
                Random RandomNumber = new System.Random();
                return RandomNumber.Next(1, 100); //random num between 1 and 100
            }


        }
    }
}

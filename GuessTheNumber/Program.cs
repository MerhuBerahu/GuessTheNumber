using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.ReadKey();
            Console.Clear();
            int number = ChooseDifficulty();


            //Console.WriteLine($"I'm thinking of a number between {num1} and {num2}, you have 5 guesses");

            
            
            int tries = 0;
            while ((tries < 5)) //keep looping while player hasnt won.
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
                    return;
                }

                tries++;
            }

            Console.WriteLine("You've lost!");

        }   
                
           


        static public int ChooseDifficulty()
        {
            Console.WriteLine("Choose a Difficulty:\n");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("4 - Insane");
            string difficulty = Console.ReadLine();

            int num = 0;
            Int32.TryParse(difficulty, out num);

            switch (num)
            {
                case 1:
                    num = RandNumber(0, 10);
                    return num; //return random number         

                case 2:
                    num = RandNumber(0, 100);
                    return num;                   

                case 3:
                    num = RandNumber(0, 500);
                    return num;

                case 4:
                    num = RandNumber(0, 1000);
                    return num;

                default:
                    Console.WriteLine("Invalid Choice");
                    return ChooseDifficulty();
                    
            }
        }

        /*public static int ChooseDifficulty(out int Min, out int Max)
        {
            while (true)
            {
                Console.WriteLine("Choose a Difficulty:\n");
                Console.WriteLine("1 - Easy");
                Console.WriteLine("2 - Medium");
                Console.WriteLine("3 - Hard");
                Console.WriteLine("4 - Insane");

                int difficulty = Convert.ToInt32(Console.ReadLine());

                Min = 0;

                switch (difficulty)
                {
                    case 1:
                        Max = 10;
                        return RandNumber(Min, Max);
                    case 2:
                        Max = 100;
                        return RandNumber(Min, Max);

                    case 3:
                        Max = 500;
                        return RandNumber(Min, Max);

                    case 4:
                        Max = 1000;
                        return RandNumber(Min, Max);

                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }
            }
        }*/

        static public int RandNumber(int num1, int num2)
        {
            Random RandomNumber = new System.Random();
            return RandomNumber.Next(num1, num2); //random num between 1 and whatever. TODO return num1 and num2 to programmatically write limits of guess
        }

        static void GameOver()
        {
            Console.WriteLine("Game Over!");
        }


    }
}


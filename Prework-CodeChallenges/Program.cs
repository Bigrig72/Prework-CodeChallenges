using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to play a numbers game, Guess 5 numbers bewtween 1 and 10");

            string []numbersArray = new string[5];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Now choose one of those numbers for your score");
            string guess = Console.ReadLine();

            int counter = 0;
            foreach (string number in numbersArray)
            {
                if(guess == number)
                {
                    counter++;
                }
            }

            int guessNumber = Convert.ToInt32(guess);
            int score = counter * guessNumber;

            Console.WriteLine($"Your score is: {score}");
            Console.ReadLine();
        }
    }
}

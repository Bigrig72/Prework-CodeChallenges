﻿using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
          
          //challenge-3
            bool incorrect = true;

            do
            {
                Console.WriteLine("Input 3 random numbers to find out if you have a perfect sequence?");

                string[] numbersArray = new string[3];

                for (int i = 0; i < numbersArray.Length; i++)
                {

                    numbersArray[i] = Console.ReadLine();

                }

                int[] myInts = Array.ConvertAll(numbersArray, int.Parse);




                int sum = 0, prod = 1;

                foreach (int value in myInts)

                {
                    sum += value;
                    prod *= value;

                }
                if (sum == prod)

                {
                    Console.WriteLine("This is a perfect sequence");
                }
                else
                {
                    Console.WriteLine("This is not a perfect sequence");
                }


            } while (incorrect);
            

// challenge-2
            bool incorrect = true;
            do
            {
            Console.WriteLine("Type in to see if the year is a leap year or not!");
            string yearInput = Console.ReadLine();
            int year = Convert.ToInt32(yearInput);

            if((year % 4 == 0)) 
            {
                if (year % 100 != 0)
                {
                        
                        Console.Write("This is a leap year");
                }
                else if (year % 400 == 0)
                {

                    Console.Write("This is a leap year");
                }
                else
                {
                    Console.Write("Sorry not a leap year");
                }
                    Console.ReadLine();
            }
            

            } while (incorrect);


            
//challenge 3
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

using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
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
            

        }
    }
}

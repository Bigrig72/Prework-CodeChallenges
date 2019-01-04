using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Random value = new Random();
            int[,] valueArray = new int[5, 3];

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    valueArray[row, col] = value.Next(1, 10);
                    Console.WriteLine("[{0}, {1}] = {2}", row, col, valueArray[row, col]);
                }
            }
                        
            int rowLength = valueArray.GetLength(0);
            int columnLength = valueArray.GetLength(1);

            int[] totalArray = new int[rowLength];

            for (int row = 0; row < rowLength; row++)
            {
                int total = 0;
                for (int col = 0; col < columnLength; col++)
                {
                    total += valueArray[row, col];
                }

                totalArray[row] = total;
                Console.WriteLine($"Total for row {row} is {total}");
            }

            
            Console.WriteLine("This is the total: [{0}]", string.Join(", ", totalArray));
            Console.ReadLine();
      
        }
    }
}

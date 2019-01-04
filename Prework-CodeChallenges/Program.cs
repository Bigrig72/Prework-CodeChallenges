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


            
        }
    }
}

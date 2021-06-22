using System;

namespace LoopsChallengeAverage
{
    /// <summary>
    /// Calculate the average score of students. The scores are added one at a
    /// time. The average is calculate once -1 is entered.
    /// Program needs to check that input is a number, and display the average
    /// to the console. The numbers should be between 0 and 20.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int testScore = 0;
            int totalOfScores = 0;
            int inputAmount = 0;
            double averageScore;
            while (testScore != -1)
            {
                Console.WriteLine("Please enter a valid test score: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out testScore);
                if (isNumber)
                {
                    if (testScore > -1 && testScore < 21)
                    {
                        totalOfScores += testScore;
                        inputAmount++;
                    }
                    else
                    {
                        Console.WriteLine("Not Valid Input");
                    }
                }
                else
                {
                    Console.WriteLine("Not Valid Input");
                }
            }
            averageScore = (double)totalOfScores / (double)inputAmount;
            Console.WriteLine($"There were {inputAmount} test results.");
            Console.WriteLine($"The average score was {averageScore}");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] scores = new int[11]; // extra space for new score
        int count = 10;

        Console.WriteLine("Enter 10 player scores:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        // Sort initial scores in descending order
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (scores[j] > scores[i])
                {
                    int temp = scores[i];
                    scores[i] = scores[j];
                    scores[j] = temp;
                }
            }
        }

        Console.WriteLine("\nLeaderboard BEFORE new score:");
        PrintScores(scores, count);

        Console.Write("\nEnter new player score: ");
        int newScore = int.Parse(Console.ReadLine());

        // Find correct position to insert new score
        int insertIndex = count;
        for (int i = 0; i < count; i++)
        {
            if (newScore > scores[i])
            {
                insertIndex = i;
                break;
            }
        }

        // Shift elements to the right to make space
        for (int i = count; i > insertIndex; i--)
        {
            scores[i] = scores[i - 1];
        }
        scores[insertIndex] = newScore;
        count++;

        Console.WriteLine("\nLeaderboard AFTER new score:");
        PrintScores(scores, count);
    }

    static void PrintScores(int[] arr, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Rank {i + 1}: {arr[i]}");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        float[] prices = new float[7];

        Console.WriteLine("Enter stock prices for 7 days:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Day {i + 1}: ");
            prices[i] = float.Parse(Console.ReadLine());
        }

        float maxGain = float.MinValue;
        int maxDay = 0;

        Console.WriteLine("\nPercentage Gains:");
        for (int i = 1; i < 7; i++)
        {
            float gain = ((prices[i] - prices[i - 1]) / prices[i - 1]) * 100;
            Console.WriteLine($"Day {i + 1}: {gain:F2}%");

            if (gain > maxGain)
            {
                maxGain = gain;
                maxDay = i + 1;
            }
        }

        Console.WriteLine($"\nHighest gain occurred on Day {maxDay} with {maxGain:F2}% increase.");
    }
}
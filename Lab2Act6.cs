using System;

class Program
{
    static void Main()
    {
        string[] inputNames = new string[15];
        string[] uniqueNames = new string[15];
        int uniqueCount = 0;

        Console.WriteLine("Enter 15 contact names (some may be duplicates):");

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Name {i + 1}: ");
            string name = Console.ReadLine().Trim();

            bool isDuplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (uniqueNames[j].ToLower() == name.ToLower())
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                uniqueNames[uniqueCount] = name;
                uniqueCount++;
            }
        }

        // Sort uniqueNames array (simple bubble sort)
        for (int i = 0; i < uniqueCount - 1; i++)
        {
            for (int j = i + 1; j < uniqueCount; j++)
            {
                if (string.Compare(uniqueNames[i], uniqueNames[j], true) > 0)
                {
                    string temp = uniqueNames[i];
                    uniqueNames[i] = uniqueNames[j];
                    uniqueNames[j] = temp;
                }
            }
        }

        Console.WriteLine("\nUnique and Sorted Contact Names:");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine("- " + uniqueNames[i]);
        }
    }
}
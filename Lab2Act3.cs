using System;

class Program
{
    static void Main()
    {
        const int SIZE = 20;
        int[] ages = new int[SIZE];

        int total = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        int countUnder18 = 0;
        int count18to35 = 0;
        int count36to60 = 0;
        int countAbove60 = 0;

        Console.WriteLine("Enter 20 ages for the survey:");

        for (int i = 0; i < SIZE; i++)
        {
            int age;
            while (true)
            {
                Console.Write($"Age #{i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age) && age >= 0 && age <= 120)
                    break;
                else
                    Console.WriteLine("Invalid age. Please enter a valid number between 0 and 120.");
            }

            ages[i] = age;
            total += age;

            if (age < min) min = age;
            if (age > max) max = age;

            // Age brackets
            if (age < 18) countUnder18++;
            else if (age <= 35) count18to35++;
            else if (age <= 60) count36to60++;
            else countAbove60++;
        }

        float average = (float)total / SIZE;

        // Output results
        Console.WriteLine("\nSurvey Summary");
        Console.WriteLine("--------------");
        Console.WriteLine($"Average Age : {average:F2}");
        Console.WriteLine($"Youngest Age: {min}");
        Console.WriteLine($"Oldest Age  : {max}");

        Console.WriteLine("\nAge Bracket Count");
        Console.WriteLine("------------------");
        Console.WriteLine($"Below 18       : {countUnder18}");
        Console.WriteLine($"18 to 35       : {count18to35}");
        Console.WriteLine($"36 to 60       : {count36to60}");
        Console.WriteLine($"Above 60       : {countAbove60}");
    }
}
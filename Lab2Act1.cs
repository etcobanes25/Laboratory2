using System;

public class Program
{
    public static void Main()
    {
        List<(string name, int score)> students = new List<(string, int)>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter name of student #{i}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter score of {name}: ");
            int score = int.Parse(Console.ReadLine());

            students.Add((name, score));
        }

        // Sort by score descending, then by name ascending
        var topStudents = students
            .OrderByDescending(s => s.score)
            .ThenBy(s => s.name)
            .Take(3)
            .ToList();

        Console.WriteLine("\nTop 3 Students:");
        for (int i = 0; i < topStudents.Count; i++)
        {
            Console.WriteLine($"Rank {i + 1}: {topStudents[i].name} - {topStudents[i].score}");
        }
    }
}
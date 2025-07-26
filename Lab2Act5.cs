using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter value of k (shift amount): ");
        int k = int.Parse(Console.ReadLine());

        // Adjust k in case it's larger than array size
        k = k % numbers.Length;

        int[] shifted = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            // New index after circular shift
            int newIndex = (i + k) % numbers.Length;
            shifted[newIndex] = numbers[i];
        }

        Console.WriteLine("\nOriginal Array: ");
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\nShifted Array: ");
        foreach (int n in shifted)
        {
            Console.Write(n + " ");
        }
    }
}
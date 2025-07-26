using System;

class Program
{
    static void Main()
    {
        const int transactionCount = 20;
        decimal total = 0;

        Console.WriteLine("Enter 20 transaction amounts:");

        for (int i = 1; i <= transactionCount; i++)
        {
        Console.Write($"Transaction {i}: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        if (amount > 10000)
          {
              Console.WriteLine($"  Accepted: {amount:F2}");
              total += amount;
            }
        }

        Console.WriteLine($"\nTotal of transactions above 10,000: ₱{total:F2}");
    }
}
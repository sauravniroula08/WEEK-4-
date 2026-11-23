using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        bool ok1 = int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        bool ok2 = int.TryParse(Console.ReadLine(), out int total);

        if (!ok1 || !ok2 || total == 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        double percentage = (double)marks / total * 100;
        Console.WriteLine("Percentage: " + percentage);
    }
}

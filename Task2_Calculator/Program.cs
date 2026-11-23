using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();
        Console.WriteLine("Add: " + calc.Add(5, 3));
        Console.WriteLine("Multiply (both): " + calc.Multiply(5, 3));
        Console.WriteLine("Multiply (default): " + calc.Multiply(5));
    }
}

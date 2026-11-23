using System;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();

        int value = 5;
        demo.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        demo.GetFullName(out string name);
        Console.WriteLine("Full name: " + name);

        Console.WriteLine("Sum: " + demo.SumAll(1, 2, 3, 4, 5));
    }
}

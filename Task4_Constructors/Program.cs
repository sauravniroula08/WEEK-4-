using System;

class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player();
        Player p2 = new Player("Hero", 5, 100);

        Console.WriteLine($"P1: {p1.playerName}, {p1.level}, {p1.health}");
        Console.WriteLine($"P2: {p2.playerName}, {p2.level}, {p2.health}");
    }
}

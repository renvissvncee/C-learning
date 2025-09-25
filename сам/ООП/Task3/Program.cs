using System;

interface IFlyable
{
    void Fly();
}

internal class Engine
{
    internal int HorsePower;
    
}

internal class Airplane : IFlyable {
    private Engine engine = new Engine();
    public Airplane(int horsePower) => engine.HorsePower = horsePower;
    public void Fly() => Console.WriteLine($"Самолет летит с мощностью {engine.HorsePower} л.с.");
}
    
internal class Program
{
    public static void Main()
    {
        Airplane plane = new Airplane(30);
        plane.Fly(); // Проверяем работу
    }
}
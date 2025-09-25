using System;

public class Car
{
    public string Model { get; set; }
    public static int TotalCars;

    public Car(string model)
    {
        Model = model;
        TotalCars++;
    }

    public int ShowTotalCars() => TotalCars;
}

class Program
{
    public static void Main()
    {
        Car car1 = new Car("bmw");
        Car car2 = new Car("merc");
        Console.WriteLine(Car.TotalCars);
    }
}
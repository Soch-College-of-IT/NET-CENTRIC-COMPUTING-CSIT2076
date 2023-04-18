using System;

public class Vehicle
{
    public double TraveledDistance { get; set; }
    public double FuelUsed { get; set; }
    public int NoOfSeats { get; set; }
    public string ActionToSteer { get; set; }

    public Vehicle(double traveledDistance, double fuelUsed, int noOfSeats, string actionToSteer)
    {
        TraveledDistance = traveledDistance;
        FuelUsed = fuelUsed;
        NoOfSeats = noOfSeats;
        ActionToSteer = actionToSteer;
    }

    public double KmPerLiter()
    {
        return TraveledDistance / FuelUsed;
    }

    public double FuelPer100Km()
    {
        return (FuelUsed / TraveledDistance) * 100;
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(double traveledDistance, double fuelUsed, string actionToSteer)
        : base(traveledDistance, fuelUsed, 2, actionToSteer)
    {
    }

    public void Steering(string direction)
    {
        ActionToSteer = "lean over " + direction;
    }
}

public class Car : Vehicle
{
    public Car(double traveledDistance, double fuelUsed, string actionToSteer)
        : base(traveledDistance, fuelUsed, 5, actionToSteer)
    {
    }

    public void Steering(string direction)
    {
        ActionToSteer = "rotate steering wheel " + direction;
    }
}

public class Program
{
    public static void Main()
    {
        // create a motorcycle object and test its methods
        Motorcycle bike = new Motorcycle(100, 5, "turn");
        Console.WriteLine("Km per liter: " + bike.KmPerLiter());
        Console.WriteLine("Fuel per 100 km: " + bike.FuelPer100Km());
        bike.Steering("left");
        Console.WriteLine("Action to steer: " + bike.ActionToSteer);

        // create a car object and test its methods
        Car car = new Car(200, 10, "turn");
        Console.WriteLine("Km per liter: " + car.KmPerLiter());
        Console.WriteLine("Fuel per 100 km: " + car.FuelPer100Km());
        car.Steering("right");
        Console.WriteLine("Action to steer: " + car.ActionToSteer);
    }
}


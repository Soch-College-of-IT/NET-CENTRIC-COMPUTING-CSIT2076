using System;

class Vehicle
{
    private double distanceTraveled;
    private double fuelUsed;
    private int numSeats;
    private string actionToSteer;

    public double DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }

    public double FuelUsed
    {
        get { return fuelUsed; }
        set { fuelUsed = value; }
    }

    public int NumSeats
    {
        get { return numSeats; }
        set { numSeats = value; }
    }

    public string ActionToSteer
    {
        get { return actionToSteer; }
        set { actionToSteer = value; }
    }

    public Vehicle()
    {
        distanceTraveled = 0;
        fuelUsed = 0;
        numSeats = 0;
        actionToSteer = "";
    }

    public double KilometersPerLiter()
    {
        if (fuelUsed == 0)
        {
            return 0;
        }
        else
        {
            return distanceTraveled / fuelUsed;
        }
    }

    public double FuelNeededFor100Km()
    {
        if (distanceTraveled == 0)
        {
            return 0;
        }
        else
        {
            return 100 / (distanceTraveled / fuelUsed);
        }
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        NumSeats = 2;
    }

    public void Steering(string direction)
    {
        ActionToSteer = "lean over " + direction;
    }
}

class Car : Vehicle
{
    public Car()
    {
        NumSeats = 5;
    }

    public void Steering(string direction)
    {
        ActionToSteer = "rotate steering wheel " + direction;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Motorcycle motorcycle = new Motorcycle();
        motorcycle.DistanceTraveled = 50;
        motorcycle.FuelUsed = 5;
        Console.WriteLine("Motorcycle:");
        Console.WriteLine("Kilometers per liter: {0}", motorcycle.KilometersPerLiter());
        Console.WriteLine("Fuel needed for 100 km: {0}", motorcycle.FuelNeededFor100Km());
        motorcycle.Steering("left");
        Console.WriteLine("Action to steer: {0}", motorcycle.ActionToSteer);

        Console.WriteLine();

        Car car = new Car();
        car.DistanceTraveled = 100;
        car.FuelUsed = 10;
        Console.WriteLine("Car:");
        Console.WriteLine("Kilometers per liter: {0}", car.KilometersPerLiter());
        Console.WriteLine("Fuel needed for 100 km: {0}", car.FuelNeededFor100Km());
        car.Steering("right");
        Console.WriteLine("Action

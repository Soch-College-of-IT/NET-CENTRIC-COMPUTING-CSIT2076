
/*Write a program, create a class named Vehicle with attribute members traveled distance,
fuel used, no of seats, action to steer. Add two methods to calculate the kilometers that
can be traveled with 1 liter of fuel, and the amount of fuel needed to travel 100 km.
Extend the class vehicle by making two new classes Motorcycle and Car. Two methods
added should work for Motorcycle and Car class. On object creation the Car class has to
set no of seats to 5 and the motorcycle class has to set to 2. Create a method called
Steering which takes parameter called direction, when this method is called it has to set
the variable action to steer to “lean over <direction>” for class motorcycle and “rotate
steering wheel <direction>” for class car. Use concept of OOP, properties, indexers,
constructors wherever applicable.*/








using System;

public class Vehicle
{
    private double _traveledDistance;
    private double _fuelUsed;
    private int _noOfSeats;
    private string _actionToSteer;

    public Vehicle(int noOfSeats)
    {
        _noOfSeats = noOfSeats;
    }

    public double TraveledDistance
    {
        get { return _traveledDistance; }
    }

    public double FuelUsed
    {
        get { return _fuelUsed; }
    }

    public int NoOfSeats
    {
        get { return _noOfSeats; }
    }

    public string ActionToSteer
    {
        get { return _actionToSteer; }
        set { _actionToSteer = value; }
    }

    public virtual double KilometersPerLiter()
    {
        return _traveledDistance / _fuelUsed;
    }

    public virtual double FuelNeededFor100Km()
    {
        return 100 / KilometersPerLiter();
    }
}

public class Car : Vehicle
{
    public Car() : base(5)
    {
    }

    public override double KilometersPerLiter()
    {
        return base.KilometersPerLiter() * 0.8; // assume car is 20% less efficient than motorcycle
    }

    public override double FuelNeededFor100Km()
    {
        return base.FuelNeededFor100Km() * 1.2; // assume car needs 20% more fuel per 100 km
    }

    public override string ToString()
    {
        return $"Car with {NoOfSeats} seats";
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle() : base(2)
    {
    }

    public override string ToString()
    {
        return $"Motorcycle with {NoOfSeats} seats";
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle car = new Car();
        car.ActionToSteer = "right";
        car._traveledDistance = 100;
        car._fuelUsed = 10;

        Console.WriteLine(car);
        Console.WriteLine($"Kilometers per liter: {car.KilometersPerLiter()}");
        Console.WriteLine($"Fuel needed for 100 km: {car.FuelNeededFor100Km()}");
        Console.WriteLine($"Action to steer: {car.ActionToSteer}");

        Vehicle motorcycle = new Motorcycle();
        motorcycle.ActionToSteer = "left";
        motorcycle._traveledDistance = 100;
        motorcycle._fuelUsed = 5;

        Console.WriteLine(motorcycle);
        Console.WriteLine($"Kilometers per liter: {motorcycle.KilometersPerLiter()}");
        Console.WriteLine($"Fuel needed for 100 km: {motorcycle.FuelNeededFor100Km()}");
        Console.WriteLine($"Action to steer: {motorcycle.ActionToSteer}");
    }
}

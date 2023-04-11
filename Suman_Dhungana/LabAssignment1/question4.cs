using System;

class Vehicle
{
    public double distance;
    public double fuel;
    public int seats;
    public string action;

    public Vehicle(double distance, double fuel, int seats, string action)
    {
        this.distance = distance;
        this.fuel = fuel;
        this.seats = seats;
        this.action = action;
    }

    public double KilometersPerLiter()
    {
        return distance / fuel;
    }

    public double FuelNeededFor100Km()
    {
        return 100 / KilometersPerLiter();
    }

    public void Steering(string direction)
    {
        action = "rotate steering wheel " + direction;
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(double distance, double fuel,int seats, string action)
        : base(distance, fuel, seats, action)
    {
    }

    public new void Steering(string direction)
    {
        action = "lean over " + direction;
    }
}

class Car : Vehicle
{
    public Car(double distance, double fuel,int seats, string action)
        : base(distance, fuel,seats, action)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("---------for MOtorcycle--------");
        Motorcycle myMotorcycle = new Motorcycle(300, 10,2, "lean over straight");
        Console.WriteLine("Kilometers per liter: " + myMotorcycle.KilometersPerLiter());
        Console.WriteLine("Fuel needed for 100 km: " + myMotorcycle.FuelNeededFor100Km());
        myMotorcycle.Steering("right");
        Console.WriteLine("Action to steer: " + myMotorcycle.action);

        Console.WriteLine("\r\n---------for Car--------");
        Car myCar = new Car(800, 40,5, "rotate steering wheel straight");
        Console.WriteLine("Kilometers per liter: " + myCar.KilometersPerLiter());
        Console.WriteLine("Fuel needed for 100 km: " + myCar.FuelNeededFor100Km());
        myCar.Steering("right");
        Console.WriteLine("Action to steer: " + myCar.action);
    }
}

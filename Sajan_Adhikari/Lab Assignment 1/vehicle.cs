using System;

namespace VehicleDemo
{
    // Base class
    class Vehicle
    {
        protected double distance;
        protected double fuel;
        public int NoOfSeats { get; set; }
        public string ActionToSteer { get; set; }

        // Constructor
        public Vehicle(double distance, double fuel, int noOfSeats)
        {
            this.distance = distance;
            this.fuel = fuel;
            NoOfSeats = noOfSeats;
        }

        // Method to calculate kilometers per liter
        public double CalculateKilometersPerLiter()
        {
            return distance / fuel;
        }

        // Method to calculate fuel needed to travel 100 km
        public double CalculateFuelFor100Km()
        {
            return 100 / CalculateKilometersPerLiter();
        }

        // Method to steer
        public virtual void Steering(string direction)
        {
            ActionToSteer = $"Rotate steering wheel {direction}";
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        // Constructor
        public Car(double distance, double fuel) : base(distance, fuel, 5)
        {

        }

        // Method to steer
        public override void Steering(string direction)
        {
            ActionToSteer = $"Rotate steering wheel {direction}";
        }
    }

    // Derived class Motorcycle
    class Motorcycle : Vehicle
    {
        // Constructor
        public Motorcycle(double distance, double fuel) : base(distance, fuel, 2)
        {

        }

        // Method to steer
        public override void Steering(string direction)
        {
            ActionToSteer = $"Lean over {direction}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(300, 20);
            Motorcycle motorcycle = new Motorcycle(200, 10);

            Console.WriteLine($"Car can travel {car.CalculateKilometersPerLiter()} km per liter of fuel.");
            Console.WriteLine($"It needs {car.CalculateFuelFor100Km()} liters of fuel to travel 100 km.");
            Console.WriteLine($"Car has {car.NoOfSeats} seats.");
            car.Steering("left");
            Console.WriteLine($"Action to steer the car: {car.ActionToSteer}");

            Console.WriteLine();

            Console.WriteLine($"Motorcycle can travel {motorcycle.CalculateKilometersPerLiter()} km per liter of fuel.");
            Console.WriteLine($"It needs {motorcycle.CalculateFuelFor100Km()} liters of fuel to travel 100 km.");
            Console.WriteLine($"Motorcycle has {motorcycle.NoOfSeats} seats.");
            motorcycle.Steering("right");
            Console.WriteLine($"Action to steer the motorcycle: {motorcycle.ActionToSteer}");
        }
    }
}

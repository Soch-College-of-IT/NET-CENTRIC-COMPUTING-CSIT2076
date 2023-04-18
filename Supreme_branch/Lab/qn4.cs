using System;

namespace VehicleApp
{
    class Vehicle
    {
        protected double traveledDistance;
        protected double fuelUsed;
        protected int noOfSeats;
        protected string actionToSteer;

        public Vehicle(double traveledDistance, double fuelUsed, int noOfSeats)
        {
            this.traveledDistance = traveledDistance;
            this.fuelUsed = fuelUsed;
            this.noOfSeats = noOfSeats;
        }

        public double KilometersPerLiter()
        {
            if (fuelUsed > 0)
            {
                return traveledDistance / fuelUsed;
            }
            else
            {
                return 0;
            }
        }

        public double FuelNeededFor100Km()
        {
            if (KilometersPerLiter() > 0)
            {
                return 100 / KilometersPerLiter();
            }
            else
            {
                return 0;
            }
        }

        public virtual void Steering(string direction)
        {
            actionToSteer = "Steering action not defined";
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(double traveledDistance, double fuelUsed)
            : base(traveledDistance, fuelUsed, 2)
        {
        }

        public override void Steering(string direction)
        {
            actionToSteer = "Lean over " + direction;
        }
    }

    class Car : Vehicle
    {
        public Car(double traveledDistance, double fuelUsed)
            : base(traveledDistance, fuelUsed, 5)
        {
        }

        public override void Steering(string direction)
        {
            actionToSteer = "Rotate steering wheel " + direction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle(150, 10);
            Car car = new Car(200, 15);

            Console.WriteLine("Motorcycle:");
            Console.WriteLine("Kilometers per liter: " + motorcycle.KilometersPerLiter());
            Console.WriteLine("Fuel needed for 100 km: " + motorcycle.FuelNeededFor100Km());
            motorcycle.Steering("left");
            Console.WriteLine("Action to steer: " + motorcycle.actionToSteer);

            Console.WriteLine("\nCar:");
            Console.WriteLine("Kilometers per liter: " + car.KilometersPerLiter());
            Console.WriteLine("Fuel needed for 100 km: " + car.FuelNeededFor100Km());
            car.Steering("right");
            Console.WriteLine("Action to steer: " + car.actionToSteer);

            Console.ReadLine();
        }
    }
}

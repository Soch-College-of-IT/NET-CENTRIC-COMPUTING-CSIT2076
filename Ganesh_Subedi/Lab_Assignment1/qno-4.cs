using System;

namespace VehicleApp
{
    class Vehicle
    {
        protected double traveledDistance;
        protected double fuelUsed;
        protected int noOfSeats;
        protected string actionToSteer;

        public double TraveledDistance
        {
            get { return traveledDistance; }
            set { traveledDistance = value; }
        }

        public double FuelUsed
        {
            get { return fuelUsed; }
            set { fuelUsed = value; }
        }

        public int NoOfSeats
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }

        public string ActionToSteer
        {
            get { return actionToSteer; }
            set { actionToSteer = value; }
        }

        // Constructor
        public Vehicle(double traveledDistance, double fuelUsed, int noOfSeats)
        {
            this.traveledDistance = traveledDistance;
            this.fuelUsed = fuelUsed;
            this.noOfSeats = noOfSeats;
        }

        // Method to calculate kilometers per liter
        public virtual double CalculateKilometersPerLiter()
        {
            return traveledDistance / fuelUsed;
        }

        // Method to calculate fuel needed to travel 100 km
        public virtual double CalculateFuelNeededFor100Km()
        {
            return 100 / (traveledDistance / fuelUsed);
        }

        // Indexer
        public string this[string direction]
        {
            get
            {
                return "Action to steer: " + actionToSteer + " " + direction;
            }
            set
            {
                actionToSteer = value;
            }
        }
    }

    class Motorcycle : Vehicle
    {
        // Constructor
        public Motorcycle(double traveledDistance, double fuelUsed)
            : base(traveledDistance, fuelUsed, 2)
        {
            // Setting default action to steer for Motorcycle
            actionToSteer = "lean over";
        }
    }

    class Car : Vehicle
    {
        // Constructor
        public Car(double traveledDistance, double fuelUsed)
            : base(traveledDistance, fuelUsed, 5)
        {
            // Setting default action to steer for Car
            actionToSteer = "rotate steering wheel";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Motorcycle motorcycle = new Motorcycle(300, 10);
            Console.WriteLine("Motorcycle - Kilometers per Liter: " + motorcycle.CalculateKilometersPerLiter());
            Console.WriteLine("Motorcycle - Fuel needed for 100 Km: " + motorcycle.CalculateFuelNeededFor100Km());
            Console.WriteLine(motorcycle["left"]);

        
            Car car = new Car(500, 20);
            Console.WriteLine("Car - Kilometers per Liter: " + car.CalculateKilometersPerLiter());
            Console.WriteLine("Car - Fuel needed for 100 Km: " + car.CalculateFuelNeededFor100Km());
            Console.WriteLine(car["right"]);

            Console.ReadLine();
        }
    }
}

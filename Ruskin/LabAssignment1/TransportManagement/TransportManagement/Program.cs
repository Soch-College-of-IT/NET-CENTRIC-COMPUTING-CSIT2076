using System;

namespace TransportManagement
{
    class Vehicle
    {   //Fields for Vehicle
        protected double distance_traveled;
        protected double fuel_used;
        public int num_of_seats;
        public string steer_action;

        //Constructor
        public Vehicle(double distance_traveled, double fuel_used, int num_of_seats, string steer_action)
        {
            this.distance_traveled = distance_traveled;
            this.fuel_used = fuel_used;
            this.num_of_seats = num_of_seats;
            this.steer_action = steer_action;
        }

        //Methods
        public double KilometersPerLiter()
        {
            return distance_traveled / fuel_used;
        }
        public double FuelNeededFor100Km()
        {
            return 100 / KilometersPerLiter();
        }
    }

    class Motorcycle : Vehicle  //child class of Vehicle
    {    //constructor
        public Motorcycle(double distance_traveled, double fuel_used, int num_of_seats, string steer_action)
            : base(distance_traveled, fuel_used, num_of_seats, steer_action)
        {
        }

        //methods
        public virtual void Steering(string direction)
        {
            steer_action = "lean over " + direction;
        }
    }

    class Car : Vehicle  //child class of Vehicle
    {   //constructor
        public Car(double distance_traveled, double fuel_used, int num_of_seats, string steer_action)
            : base(distance_traveled, fuel_used, num_of_seats, steer_action)
        {
        }
        //methods
        public void Steering(string direction)
        {
            steer_action = "rotate steering wheel " + direction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------For MOtorcycle--------");
            Motorcycle myMotorcycle = new Motorcycle(250, 8, 2, "Lean over straight");
            Console.WriteLine("Kilometers per liter: " + myMotorcycle.KilometersPerLiter());
            Console.WriteLine("Fuel needed for 100 km: " + myMotorcycle.FuelNeededFor100Km());
            myMotorcycle.Steering("right");
            Console.WriteLine("Action to steer: " + myMotorcycle.steer_action);

            Console.WriteLine("\r\n---------For Car--------");
            Car myCar = new Car(1000, 50, 5, "Rotate steering wheel straight");
            Console.WriteLine("Kilometers per liter: " + myCar.KilometersPerLiter());
            Console.WriteLine("Fuel needed for 100 km: " + myCar.FuelNeededFor100Km());
            myCar.Steering("right");
            Console.WriteLine("Action to steer: " + myCar.steer_action);
        }
    }
}

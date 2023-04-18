using system;
namespace vehicle
{
    public class Vehicle
        {
            private double Traveled_Distance;
            private double Fuel_Used;
            public int NoOfSeats { get; set; }
            public string ActionToSteer { get; set; }

            public Vehicle()
            {
                NoOfSeats = 0;
                ActionToSteer = "";
            }

            public double CalculateKmsPerLiter()
            {
                return Traveled_Distance / Fuel_Used;
            }

            public double CalculateFuelNeeded()
            {
                return (Fuel_Used / Traveled_Distance) * 100;
            }

            public void Drive(double distance, double fuel)
            {
                Traveled_Distance += distance;
                Fuel_Used += fuel;
            }

            public virtual void Steering(string direction)
            {
                // base implementation does nothing
            }
        }

        public class Car : Vehicle
        {
            public Car() : base()
            {
                NoOfSeats = 5;
            }

            public override void Steering(string direction)
            {
                ActionToSteer = $"rotate steering wheel {direction}";
            }
        }

        public class Motorcycle : Vehicle
        {
            public Motorcycle() : base()
            {
                NoOfSeats = 2;
            }

            public override void Steering(string direction)
            {
                ActionToSteer = $"lean over {direction}";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // creating the objects of cars
                Console.WriteLine("\n");


                Car car = new Car();
                car.Drive(200, 20);
                Console.WriteLine($"Kilometers per liter for car: {car.CalculateKmsPerLiter()}");
                Console.WriteLine($"Fuel needed to travel 100km for car: {car.CalculateFuelNeeded()} liters");
                car.Steering("left");
                Console.WriteLine($"Action to steer car: {car.ActionToSteer}");


                // creating the objects of motorcycle
                Console.WriteLine("\n\n");

                Motorcycle motorcycle = new Motorcycle();
                motorcycle.Drive(100, 5);
                Console.WriteLine($"Kilometers per liter for motorcycle: {motorcycle.CalculateKmsPerLiter()}");
                Console.WriteLine($"Fuel needed to travel 100km for motorcycle: {motorcycle.CalculateFuelNeeded()} liters");
                motorcycle.Steering("right");
                Console.WriteLine($"Action to steer motorcycle: {motorcycle.ActionToSteer}");

                Console.ReadLine();
            }
        }
    }
}
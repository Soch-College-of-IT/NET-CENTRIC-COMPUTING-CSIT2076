using System;

public class Vehicle {
    private double distanceTraveled;
    private double fuelUsed;
    public int NumSeats { get; set; }
    protected string steerAction;

    public Vehicle() {
        NumSeats = 0;
        steerAction = "";
    }

    public void Travel(double distance, double fuel) {
        distanceTraveled += distance;
        fuelUsed += fuel;
    }

    public double KmPerLiter() {
        if (fuelUsed == 0) {
            return 0;
        }
        return distanceTraveled / fuelUsed;
    }

    public double FuelPer100Km() {
        if (distanceTraveled == 0) {
            return 0;
        }
        return fuelUsed / (distanceTraveled / 100);
    }

    public void Steering(string direction) {
        steerAction = direction;
    }
}

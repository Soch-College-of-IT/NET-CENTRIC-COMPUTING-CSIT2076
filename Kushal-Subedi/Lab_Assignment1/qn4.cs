
 

using System;

class Vehicle{
public double travelledDistance = 0;
public double fuelUsed = 0;
public int noOfSeats = 0;
public string steeringAction = " ";


public double KmPerLitre(){
return travelledDistance/fuelUsed;
}
public double neededFuel(){
    return 100/KmPerLitre();
}
public virtual void Steering(string direction){}
}

class Motorcycle:Vehicle{
public override void Steering(string direction){
steeringAction = "Lean over " + direction;
}
}


class Car:Vehicle{
 public override void Steering(string direction){
        steeringAction = "Rotate steering wheel " + direction;
    }
}


class Qno4{
public static void Main(string[] args){
    Car myCar=new Car();
    myCar.travelledDistance=5000;
    myCar.fuelUsed=4300;
    Console.WriteLine("Kilometers per liter for car: {0}", myCar.KmPerLitre());
    Console.WriteLine("Fuel needed for 100 km for car: {0}", myCar.neededFuel());
    myCar.Steering("left");
    Console.WriteLine("Steering action for car: {0}", myCar.steeringAction);


    Motorcycle myBike=new Motorcycle();
    myBike.travelledDistance=1500;
    myBike.fuelUsed=50;
    Console.WriteLine("Kilometers per liter for Bike: {0}", myBike.KmPerLitre());
    Console.WriteLine("Fuel needed for 100 km for Bike: {0}", myBike.neededFuel());
    myBike.Steering("Right");
    Console.WriteLine("Steering action for Bike: {0}", myBike.steeringAction);
}
}


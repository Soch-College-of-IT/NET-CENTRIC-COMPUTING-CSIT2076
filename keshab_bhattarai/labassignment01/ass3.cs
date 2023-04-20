using System;

class Vehicle{
public double travelledDistance;
public double fuelUsed;
public int noOfSeats;
public string steeringAction;


public double KmPerLitre(){
return travelledDistance/fuelUsed;
}
public double neededFuel(){
return 100/KmPerLitre();
}
public virtual void Steering(string direction){
}
}

class Motorcycle:Vehicle{
public override void Steering(string direction){
steeringAction = "Lean over " + direction;
}
}


class Car:Vehicle{
 public override void Steering(string direction)
    {
        steeringAction = "Rotate steering wheel " + direction;
    }
}


class Qno4{
public static void Main(string[] args){
Car myCar=new Car();
myCar.travelledDistance=200;
myCar.fuelUsed=10;
 Console.WriteLine("Kilometers per liter for car: {0}", myCar.KmPerLitre());
  Console.WriteLine("Fuel needed for 100 km for car: {0}", myCar.neededFuel());
  myCar.Steering("left");
 Console.WriteLine("Steering action for car: {0}", myCar.steeringAction);


Motorcycle myBike=new Motorcycle();
myBike.travelledDistance=200;
myBike.fuelUsed=6;
Console.WriteLine("Kilometers per liter for Bike: {0}", myBike.KmPerLitre());
  Console.WriteLine("Fuel needed for 100 km for Bike: {0}", myBike.neededFuel());
  myBike.Steering("left");
 Console.WriteLine("Steering action for Bike: {0}", myBike.steeringAction);
}
}
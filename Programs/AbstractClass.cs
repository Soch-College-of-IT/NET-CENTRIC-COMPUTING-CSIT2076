using System;

namespace Programs{
    internal class AbstractClass{
        public static void Main(string[] args){
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle(10, 20);
            shapes[1] = new Circle(10);
            shapes[2] = new Triangle(10, 20, 30);

            foreach(Shape shape in shapes){
                shape.Print();
            }
        }
    }
}
public abstract class Shape{
    public abstract double Area();
    public abstract double Perimeter();

    public void Print(){
        Console.WriteLine("Area: {0}", Area());
        Console.WriteLine("Perimeter: {0}", Perimeter());
    }
}

public class Rectangle : Shape{
    private double length;
    private double width;

    public Rectangle(double length, double width){
        this.length = length;
        this.width = width;
    }

    public override double Area(){
        return length*width;
    }

    public override double Perimeter(){
        return 2*(length + width);
    }
}

public class Circle : Shape{
    private double radius;

    public Circle(double radius){
        this.radius = radius;
    }

    public override double Area(){
        return Math.PI*radius*radius;
    }

    public override double Perimeter(){
        return 2*Math.PI*radius;
    }
}

public class Triangle : Shape{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3){
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double Area(){
        double s = (side1 + side2 + side3)/2;
        return Math.Sqrt(s*(s - side1)*(s - side2)*(s - side3));
    }

    public override double Perimeter(){
        return side1 + side2 + side3;
    }
}

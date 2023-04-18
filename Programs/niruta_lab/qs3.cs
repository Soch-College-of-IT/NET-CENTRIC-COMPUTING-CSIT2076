using System;

class Program {
    static void Main(string[] args) {

        Console.WriteLine("Enter your age: ");

        int age = int.Parse(Console.ReadLine());


        if (age >= 18) 
        {

            Console.WriteLine("You can get citizenship and vote.");

        }
        else if (age >= 16) 
        {

            Console.WriteLine("You can get citizenship but can't vote.");

        }
        else 
        {

            Console.WriteLine("You can't get citizenship.");
        }
    }
}
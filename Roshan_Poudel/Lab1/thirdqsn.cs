using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18) {
            Console.WriteLine("You can get citizenship and vote.");
        }
        else if (age >= 16) {
            Console.WriteLine("You can get citizenship but cannot vote.");
        }
        else {
            Console.WriteLine("You cannot get citizenship.");
        }
    }
}
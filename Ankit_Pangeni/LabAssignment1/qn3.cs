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


/*

In this code, we have used an if-else statement to check for the different age conditions.
 If the age is greater than or equal to 18, then the person can get citizenship and vote. If the age is greater than or equal to 16 but less than 18, 
then the person can get citizenship but cannot vote. If the age is less than 16, then the person cannot get citizenship. 
We chose to use an if-else statement because it is a simple and efficient way to handle multiple conditions in a program. 
It allows us to check for different conditions and execute different blocks of code based on those conditions.

*/
//Write a program, for the given condition with the appropriate approach (loop, if, switch),
//also explain why did you use the specific approach
//a. Age >= 18 “Person can get citizenship and vote”
//b. Age >= 16 “Person can get citizenship but cannot vote”
//c. Age < 16 “Person cannot get citizenship”



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Person can get citizenship and vote");
        }
        else if (age >= 16)
        {
            Console.WriteLine("Person can get citizenship but cannot vote");
        }
        else
        {
            Console.WriteLine("Person cannot get citizenship");
        }
    }
}
/*This program first prompts the user to enter their age, and then uses a series of if-else statements to check the age and print the appropriate message to the console. If the age is greater than or equal to 18, the program prints the message "Person can get citizenship and vote". If the age is between 16 and 18 (inclusive), the program prints the message "Person can get citizenship but cannot vote". Otherwise, if the age is less than 16, the program prints the message "Person cannot get citizenship".

The if-else approach is a suitable choice for this problem because it allows us to check the input age against multiple conditions and execute the appropriate code block based on the result. Additionally, it is easy to read and understand, making it suitable for small programs like this one.*/







using System;

class Ifelse
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible for citizenship and voting.");
        }
        else if (age >= 16)
        {
            Console.WriteLine("You are eligible for citizenship, but not voting.");
        }
        else
        {
            Console.WriteLine("You are not eligible for citizenship or voting.");
        }
    }
}

//For this program if/else is suitable thats why i used ifelse instead of for loop and switch 

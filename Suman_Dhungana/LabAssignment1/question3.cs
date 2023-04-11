using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You can get citizenship and voter id");
        }
        else if (age >= 16)
        {
            Console.WriteLine("You can get citizenship but cannot voter id");
        }
        else
        {
            Console.WriteLine("You cannot get citizenship");
        }
    }
}

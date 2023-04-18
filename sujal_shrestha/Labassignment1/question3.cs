using System;

class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

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

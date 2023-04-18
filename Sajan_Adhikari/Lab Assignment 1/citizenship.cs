using System;

namespace CitizenshipAndVoting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int age = 0;
                while (age <= 0)
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0)
                    {
                        Console.WriteLine("Age must be a positive integer. Please try again.");
                    }
                }

                if (age >= 18)
                {
                    Console.WriteLine("Person can get citizenship and vote");
                }
                else
                {
                    switch (age)
                    {
                        case int n when n >= 16:
                            Console.WriteLine("Person can get citizenship but cannot vote");
                            break;
                        default:
                            Console.WriteLine("Person cannot get citizenship");
                            break;
                    }
                }

                Console.Write("Do you want to check for another person? (y/n): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}

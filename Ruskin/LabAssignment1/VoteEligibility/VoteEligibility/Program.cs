using System;

namespace VoteEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  your age: ");
            int age = int.Parse(Console.ReadLine());
            
            //if elese condition to check for the different age conditions

            if (age >=  18)
            {
                Console.WriteLine("You are eligible to get citizenship and you can vote!");
            }
            else if (age >= 16)
            {
                Console.WriteLine("You are eligible to get citizenship but you cannot vote!");
            }
            else
            {
                Console.WriteLine("You are not eligible to get citizenship!");
            }
        }
    }
}

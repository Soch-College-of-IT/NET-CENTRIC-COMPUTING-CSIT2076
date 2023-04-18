using System;

namespace CitizenshipChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter person's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Person can get citizenship and vote.");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Person can get citizenship but cannot vote.");
            }
            else
            {
                Console.WriteLine("Person cannot get citizenship.");
            }

            Console.ReadLine();
        }
    }
}

/*
We used if-else statements in this case because it allows us to easily express 
the different conditions and their corresponding outcomes in a clear and concise
 manner. The if-else statements provide a straightforward way to handle multiple
  conditions and execute different blocks of code based on the value of the input age.
*/
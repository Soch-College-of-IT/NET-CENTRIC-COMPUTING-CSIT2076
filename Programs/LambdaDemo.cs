using System;
using System.Collections.Generic;


namespace Programs
{
    class Dog{
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {
            // Lambda expression

            Func<int,int> square = x => x*x;
            Console.WriteLine(square(5));

            // List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            // List<int> evenNumbers = list.FindAll(x => x % 2 == 0);

            // foreach (var num in evenNumbers)
            // {
            //     Console.WriteLine(num);
            // }

            // // Another example
            // List<Dog> dogs = new List<Dog>(){
            //     new Dog { Name = "Rover", Age = 3 },
            //     new Dog { Name = "Fido", Age = 5 },
            //     new Dog { Name = "Rex", Age = 1 },
            // };

            // var names = dogs.Select(x=>x.name);
            // foreach (var name in names)
            // {
            //     Console.WriteLine(name);
            // }           
        }
    }
}
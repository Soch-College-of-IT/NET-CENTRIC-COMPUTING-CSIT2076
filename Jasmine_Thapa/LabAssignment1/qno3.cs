﻿

using System;


class Program
{
    static void Main(string[] args)

    {
        Console.Write("Enter age: ");

        int age = int.Parse(Console.ReadLine()); ;

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





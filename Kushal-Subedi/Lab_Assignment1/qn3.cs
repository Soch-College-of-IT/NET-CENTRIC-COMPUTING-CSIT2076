// QN - 3

// Voting Age Checker

using System;

class EligibleCandadate {
static void Main(string[] args){
    int age;
    Console.WriteLine("Enter your age to check if you are eligible to vote or not");
    age=int.Parse(Console.ReadLine());
    if (age >=16 && age <18){
        Console.WriteLine("You cannot vote but you can get Citizenship");
    } else if (age>=18){
        Console.WriteLine("You Can vote");
    }
    else {
        Console.WriteLine("you cannot vote !!");
    }
}

}
  
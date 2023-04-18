//QN-2
// Check wether the year is Leap Year or Not ?

using System;

class CheckLeapYear{
    static void Main(){
        int year;
        Console.WriteLine("Enter a year to check if it is a leap year or not");
        year = Convert.ToInt32(Console.ReadLine());
        if(year%4==0){
            if(year%100==0){
                if(year%400==0){
                    Console.WriteLine("The year {0} is a leap year", year);
                }
                else{
                    Console.WriteLine("The year {0} is not a leap year", year);
                }
            }
            else{
                Console.WriteLine("The year {0} is a leap year", year);
            }
        }
        else{
            Console.WriteLine("The year {0} is not a leap year", year);
        }
    }
}
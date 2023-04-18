using system;

namespace leap_year
{
    // Q2) Program for the given year is leap or not


        
        public static void Main()
        {
            int check_year;
            Console.Write("\n\n");
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            check_year = Convert.ToInt32(Console.ReadLine());// Asign input value at check_year variable

            
             if ((check_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", check_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", check_year);
            Console.ReadLine();
        }
        



}

 
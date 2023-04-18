using system;
namespace voter
{

     // Q3) Program for according to the age the citizens are able to vote or not
     internal class voter
     {
        public static void Main()
        {
            int age;
            Console.Write("\n\n");
            Console.Write("Enter your Age:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");
            Console.Write("Your Age:");
            age = Convert.ToInt32(Console.ReadLine()); ;

            if (age <16)
            {
                Console.WriteLine("You are child");
            }
            else if (age <18) 
            {
                Console.WriteLine("You have Citizenship but you are not eligible for vote");
            }
            else { 
                Console.WriteLine("Youe are eligible for vote");
             
            }
            Console.ReadLine();
        


        

         }

     }

        
}
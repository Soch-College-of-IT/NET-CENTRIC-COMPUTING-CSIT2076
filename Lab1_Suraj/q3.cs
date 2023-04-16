  using System;

  namespace surajgautam
  {
      class Program
      {
         
          static void Main(string[] args)
          {
             
              Console.Write("Enter age: ");

              int age = Convert.ToInt32(Console.ReadLine());

             
              if (age > 100)
  {
     
      Console.Write("Are you willing to vote? (Y/N): ");
      string response = Console.ReadLine();

      if (response.ToUpper() == "Y")
      {
         Console.WriteLine("You must be a very healthy person!");
          if (age >= 18)
          {
              Console.WriteLine("You can get citizenship and vote");
          }
          else if (age >= 16)
          {
              Console.WriteLine("You can get citizenship but cannot vote");
          }
          else
          {
              Console.WriteLine("You cannot get citizenship");
          }
      }
      else
      {
          Console.WriteLine("use your voting right .");
      }
  }
  else if (age >= 18)
  {
      Console.WriteLine("You can get citizenship and vote");
  }
  else if (age >= 16)
  {
      Console.WriteLine("You can get citizenship but cannot vote");
  }
  else
  {
      Console.WriteLine("You cannot get citizenship");
  }


              Console.ReadLine();
          }
      }
  }

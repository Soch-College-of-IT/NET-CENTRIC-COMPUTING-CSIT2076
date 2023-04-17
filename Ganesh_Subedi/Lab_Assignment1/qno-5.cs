using System;

namespace QuizApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz Application!");
            Console.WriteLine("--------------------------------");


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nInstructions:");
            Console.WriteLine("Answer the following questions with 1, 2, 3, or 4.");
            Console.WriteLine("Press any key to start...\n");
            Console.ReadKey();


            int score = 0;

            Console.WriteLine("Question 1: Who is the primeminister of Nepal?");
            Console.WriteLine("1) Kp sharma oli");
            Console.WriteLine("2) Sherbadhur deuwa");
            Console.WriteLine("3) Puspa kamal dahal parchandra");
            Console.WriteLine("4) janardan sharma");
            Console.Write("Your answer: ");
            string answer1 = Console.ReadLine();

           
            if (int.Parse(answer1)==3)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

         
            Console.WriteLine("\nQuestion 2: when is independence day celebrated in nepal?");
            Console.WriteLine("1) january 13");
            Console.WriteLine("2) april 6");
            Console.WriteLine("3) september 20");
            Console.WriteLine("4) march 20");
            Console.Write("Your answer: ");
            string answer2 = Console.ReadLine();

          
            if (int.Parse(answer2) == 3)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("\nQuestion 3: What is the largest mammal on Earth?");
            Console.WriteLine("1) Elephant");
            Console.WriteLine("2) Rhinoceros");
            Console.WriteLine("3) Blue whale");
            Console.WriteLine("4) Giraffe");
            Console.Write("Your answer: ");
            string answer3 = Console.ReadLine();

          
            if (int.Parse(answer3) == 3)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

          
            Console.WriteLine("\nQuiz Results for " + name);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total Questions: 3");
            Console.WriteLine("Correct Answers: " + score);
            Console.WriteLine("Incorrect Answers: " + (3 - score));

            double percentageScore = (double)score / 3 * 100;
            
            Console.WriteLine("Percentage Score: " + percentageScore.ToString("F2") + "%");

            // Thank you message
            Console.WriteLine("\nThank you for taking the quiz!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

  // explanation 
            /* initially the program display a welcome message and asking the user to enter their name.
             we declare a variable score whose value is set to 0 initially
             3 question are asked  and their corresponding answer are checked by using if condition  
             The user's answer is checked using int.Parse() to convert the string to an integer, and compared with the correct answer using an if statement.
             If the answer is correct, the program displays "Correct!" and increments the score variable . else, it displays "Incorrect!".
            
              at last the program displays the user's quiz results, including the total questions, correct answers, incorrect answers, and percentage score. 
              A thank you message is displayed.
            
            

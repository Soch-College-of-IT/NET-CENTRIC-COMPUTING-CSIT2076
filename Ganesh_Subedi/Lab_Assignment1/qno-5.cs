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

            // Question 1
            Console.WriteLine("Question 1: Who is the primeminister of Nepal?");
            Console.WriteLine("1) Kp sharma oli");
            Console.WriteLine("2) Sherbadhur deuwa");
            Console.WriteLine("3) Puspa kamal dahal parchandra");
            Console.WriteLine("4) janardan sharma");
            Console.Write("Your answer: ");
            string answer1 = Console.ReadLine();

            // Check answer 1
            if (answer1.ToLower() == "3")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            // Question 2
            Console.WriteLine("\nQuestion 2: when is independence day celebrated in nepal?");
            Console.WriteLine("1) january 13");
            Console.WriteLine("2) april 6");
            Console.WriteLine("3) september 20");
            Console.WriteLine("4) march 20");
            Console.Write("Your answer: ");
            string answer2 = Console.ReadLine();

            // Check answer 2
            if (answer2.ToLower() == "3")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            // Question 3
            Console.WriteLine("\nQuestion 3: What is the largest mammal on Earth?");
            Console.WriteLine("1) Elephant");
            Console.WriteLine("2) Rhinoceros");
            Console.WriteLine("3) Blue whale");
            Console.WriteLine("4) Giraffe");
            Console.Write("Your answer: ");
            string answer3 = Console.ReadLine();

            // Check answer 3
            if (answer3.ToLower() == "3")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            // Display quiz results
            Console.WriteLine("\nQuiz Results for " + name);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total Questions: 3");
            Console.WriteLine("Correct Answers: " + score);
            Console.WriteLine("Incorrect Answers: " + (3 - score));

            // Calculate and display percentage score
            double percentageScore = (double)score / 3 * 100;
            Console.WriteLine("Percentage Score: " + percentageScore.ToString("F2") + "%");

            // Thank you message
            Console.WriteLine("\nThank you for taking the quiz!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

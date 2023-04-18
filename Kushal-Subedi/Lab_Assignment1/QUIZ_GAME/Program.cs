using System;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[]
            {
                "What is the capital of France?",
                "What is the largest planet in our solar system?",
                "What is the capital of Nepal?"
            };

            string[,] options = new string[,]
            {
                {"a. Berlin", "b. Madrid", "c. Paris"},
                {"a. Saturn", "b. Jupiter", "c. Uranus"},
                {"a. Pokhara", "b. Kathmandu", "c. Jhapa"}
            };

            string[] answers = new string[]
            {
                "c",
                "b",
                "b"
            };

            int score = 0;

            Console.WriteLine("Welcome to the quiz game! Please select the correct option for the following questions:");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\n{i + 1}. {questions[i]}");

                for (int j = 0; j < options.GetLength(1); j++)
                {
                    Console.WriteLine(options[i, j]);
                }

                string answer = Console.ReadLine().ToLower();

                if (answer == answers[i])
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }

            Console.WriteLine($"\nQuiz complete! You got {score} out of {questions.Length} questions correct.");
            Console.ReadLine();
        }
    }
}

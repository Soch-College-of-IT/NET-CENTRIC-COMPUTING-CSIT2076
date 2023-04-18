using System;

namespace QuizApplication
{
    class Quiz
    {
        // Properties
        public string Name { get; set; } 
        public int Score { get; set; } 

        // Constructor
        public Quiz(string name)
        {
            Name = name;
            Score = 0;
        }

        // Methods
        public void Question(string question, string[] options, int correctAnswer)
        {
            Console.WriteLine(question);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();

            if (int.TryParse(answer, out int userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    Score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("\nQuiz Results for " + Name);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total Questions: 3");
            Console.WriteLine("Correct Answers: " + Score);
            Console.WriteLine("Incorrect Answers: " + (3 - Score));

            double percentageScore = (double)Score / 3 * 100;
            Console.WriteLine("Percentage Score: " + percentageScore.ToString("F2") + "%");
        }

        public void DisplayThankYouMessage()
        {
            Console.WriteLine("\nThank you for taking the quiz!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Quiz quiz = new Quiz(name);

            // Question 1
            quiz.Question("Question 1: Who is the prime minister of Nepal?",
                new string[] { "Kp Sharma Oli", "Sher Bahadur Deuba", "Pushpa Kamal Dahal Prachanda", "Janardan Sharma" },
                3);

            // Question 2
            quiz.Question("Question 2: When is Independence Day celebrated in Nepal?",
                new string[] { "January 13", "April 6", "September 20", "March 20" },
                3);

            // Question 3
            quiz.Question("Question 3: What is the largest mammal on Earth?",
                new string[] { "Elephant", "Rhinoceros", "Blue Whale", "Giraffe" },
                3);

            quiz.DisplayResults();
            quiz.DisplayThankYouMessage();
        }
    }
}

/* explanation  in above get and set properties Stores the name of the person participate in quiz taker and  score

 there is a class quiz  which  has methods for asking questions, displaying quiz results, and thanking the person. 
 
 The Question method displays a question  and takes the user's answer as input, checks if it's correct, and updates the score . 
 
 
 The DisplayResults method displays the quiz taker's name, total questions, correct answers, incorrect answers, and percentage score.
 
The DisplayThankYouMessage method displays a thank you message to the person .

The Main Program class takes inputs as name pf person  and  creates an instance of the Quiz class, 

asks three questions with options, displays the quiz results, and shows a thank you message.


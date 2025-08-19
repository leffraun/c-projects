
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{

    private static void Main(string[] args)
    {
        //we are creating a quiz 
        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Let's start the quiz.");
        int score = 0;
        int quizrounds = 5;
        string[] questions =
        {
            "What is the capital of France?",
            "What is 2 + 2?",
            "What is the largest planet in our solar system?",
            "Who wrote 'To Kill a Mockingbird'?",
            "What is the boiling point of water in Celsius?"

        };
        string[] answers =
        {
            "Paris",
            "4",
            "Jupiter",
            "Harper Lee",
            "100"
        };
        for (int i = 0; i < quizrounds; i++)
        {
            Console.WriteLine($"Round {i + 1}: {questions[i]}");
            string userAnswer = Console.ReadLine();
            if(userAnswer.Trim().Equals(answers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is: {answers[i]}");
            }



        }
        Console.WriteLine($"Quiz completed! Your score is {score} out of {quizrounds}.");
    }
}
    






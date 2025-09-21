using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the \"DO YOU KNOW ME BETTER.\" quiz");
        Console.WriteLine("let's start the quiz");
        int quizpoints = 0;
        string[] questions = { "what color does manha like?","what food does she like?","what drama is her fav?","what language does she like the best?"};
        string[] options1 = { "green", "blue", "yellow","white" };
        string[] options2 = { "steak", "french fries", "lazagna" ,"affogato"};
        string[] options3 = { "none", "coffee prince", "to the beautiful you", "imitation"};
        string[] options4 = {"english", "french", "spanish", "german"};
        int[] answers = { 1, 2, 3, 3 };
        //string[] answers = {"green","french fries","to the beautiful you","spanish" };
        for (int i = 0; i < questions.Length; i++) {
            Console.WriteLine(i+1+". "+questions[i]);
            if (i == 0)
            {

                for (int j = 0; j < options1.Length; j++)
                {
                    Console.WriteLine($"\t{j+1}. {options1[j]}");
                }
               
            }
            else if (i == 1)
            {
                for (int j = 0; j < options1.Length; j++)
                    Console.WriteLine($"\t{j + 1}. {options2[j]}");

            }
            else if (i == 2)
            {
                for (int j = 0; j < options1.Length; j++)
                    Console.WriteLine($"\t{j + 1}. {options3[j]}");

            }
            else if (i == 3) {
                for (int j = 0; j < options1.Length; j++)
                    Console.WriteLine($"\t{j + 1}. {options4[j]}");


            }
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans == answers[i])
            {
                Console.WriteLine("correct answer");
                quizpoints+=10;
            }
            else {
                Console.WriteLine("wrong answer");
            }
        }
       Console.WriteLine("you have scored "+quizpoints+"/40 points");
    }
}

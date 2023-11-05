using System;
using System.Collections.Generic;
using System.Threading;

class reflectingActivity
{
    static void Main(string[] args) {   //Starting message
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();

        //Random prompt is pulled        
        string[] JMprompts = new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        //Timer i didnt know how to implement it from another class but felt bad leaving that portion blank
        Random JMrandom = new Random();
        int JMduration = 60; // seconds
        DateTime JMendTime = DateTime.Now.AddSeconds(JMduration);

        //Looping through prompts
        while (DateTime.Now < JMendTime) {
            string JMprompt = JMprompts[JMrandom.Next(JMprompts.Length)];
            Console.WriteLine(JMprompt);
            Console.WriteLine();

            string[] JMquestions = new string[] {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            foreach (string JMquestion in JMquestions) {
                Console.Write($"{JMquestion} ");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}


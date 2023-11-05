using System;
using System.Threading;

class listingActivity{
    static void Main(string[] args)
    {
        // Opening message
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." );

        // Creates arrays of prompts and selects one at random
        string[] JMprompts = new string[] { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
        Random JMrandom = new Random();
        int JMindex = JMrandom.Next(JMprompts.Length);
        Console.WriteLine(JMprompts[JMindex]);

        // Waits 10 seconds to give user time to think about prompt, not really working (yet)
        Console.WriteLine("You have 10 seconds to think about the prompt. ");
        Thread.Sleep(10000);

        // The user begins listing items
        Console.WriteLine("Begin listing items: ");

        // Loops through each response entered by user and adds a counter variable
        int JMcount = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                break;
            }
            JMcount++;
        }

        // Message telling user how many times they entered
        Console.WriteLine("You entered {0} items.", JMcount);
    }
}

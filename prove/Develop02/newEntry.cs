using System;

public class Entry {
       public string JMmessages  = "";
       public string JMresponses= "";
       public string JMdate = DateTime.Now.ToString("dd-MM-yyyy");


       public void Display() {
        Console.WriteLine($"Date: {JMdate} - Prompt: {JMmessages}");
        Console.WriteLine(char.ToUpper(JMresponses[0]) + JMresponses.Substring(1));

        }
    
    }
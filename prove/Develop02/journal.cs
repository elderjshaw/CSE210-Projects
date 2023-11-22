using System;
using System.Collections.Generic;

public class Journal{

    public string JMuserName = "";
    public List<Entry> JMentrie = new List<Entry>();
    
    public void Display() {

        Console.WriteLine($"Name: "+char.ToUpper(JMuserName[0]) + JMuserName.Substring(1));
        Console.WriteLine($"Entries:");

            foreach (Entry elementEntry in JMentrie) {
         elementEntry.Display();
        }
    }

    }
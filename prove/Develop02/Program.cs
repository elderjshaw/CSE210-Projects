using System;
using System.Collections.Generic;
using System.IO; 
class Program {
    static void Main(string[] args) {        
            Console.Write("Enter your name: ");
            string JMname = Console.ReadLine();   
            Journal JMuserJournal = new Journal();

            //Convert users fist letter of the string to capital letter
            JMuserJournal.JMuserName = char.ToUpper(JMname[0]) + JMname.Substring(1);
            
            List<string> JMstorageList = new List<string>();
       
       //Text Files
       //filename = "myFile.csv";

        bool JMexit = false;
        while(!JMexit) {
    
            List<string> JMpromptList = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            };


//menu
            Console.WriteLine("Please select one of the choices. ");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            Console.Write("What would you like to do?");
            string JMuserFile= "No";
            string answerFileToLoad;
            string JMchoose = Console.ReadLine();
            

            switch (JMchoose) {

                    case "1":

                    Random random = new Random();
                    int num = random.Next(0, 6);
                    Entry JMentry1 = new Entry();
                    JMentry1.JMmessages = JMpromptList[num];
                    Console.WriteLine(JMentry1.JMmessages);
                    Console.Write("Please enter your response: ");
                    string JMentryResponse = Console.ReadLine();
                    JMentry1.JMresponses = char.ToUpper(JMentryResponse[0]) + JMentryResponse.Substring(1);
                    JMuserJournal.JMentrie.Add(JMentry1);
                                        
                    //Display Entry information
                    break;

                case "2":
                    if(JMuserFile == "Yes") {
                    foreach (string item in JMstorageList)
                    {
                        Console.WriteLine(item);
                    }
                     JMuserJournal.Display();

                    Console.WriteLine("To save the current list, please choose option to Save.");
                    }
                    
                    else if(JMuserFile == "No") {
                    Console.WriteLine("------------------------------------------------------");
                    JMuserJournal.Display();
                    Console.WriteLine("------------------------------------------------------");

                    Console.WriteLine("To save the current list, please save it.");

                    };

                    break;

                case "3":
                
                    JMuserFile= "No";
                    //Get file and load from the outline
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    answerFileToLoad = Console.ReadLine();
                    string filename = answerFileToLoad;
                    
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines) {
                            Console.WriteLine(line);
                            JMstorageList.Add(line);                            
                    }

                    Console.WriteLine("File loaded.");
                    
                    JMuserFile= "Yes";
                    break;


                case "4":

                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    string answerFileToSave = Console.ReadLine();
                    
                    using (StreamWriter outputFile = new StreamWriter(answerFileToSave)) {  
                        outputFile.WriteLine("------------------------------------------------------");
                        outputFile.WriteLine($"Name: {JMuserJournal.JMuserName}");

                        foreach (Entry entry in JMuserJournal.JMentrie) {

                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: "+entry.JMmessages);
                        outputFile.WriteLine($"{entry.JMresponses}");
                        
                        }
                        outputFile.WriteLine("------------------------------------------------------");
                        
                    };

                    break;

                case "5":
                    JMexit = true;
                    break;                
                
                default:
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        
            }
           

        
        
    }
}
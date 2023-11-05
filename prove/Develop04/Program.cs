using System;

class Program : Menu
{
    static void Main(string[] args)
    {

        //Call to the Menu Class to start an activity.
        Menu activity = new Menu();
        Boolean starting = true;
        string calm = "return value";

        do
        {
            //Start the relaxation program 
            Console.WriteLine("Welcome to the wonderful world of relaxation!");
            Console.WriteLine("What relaxation activity would you like to do?");
            Console.WriteLine("(Enter a number based on which activity you want)");
            Console.WriteLine("(1. Breathing, 2. Reflecting, 3. Listing, 4. Thinking)");
            Console.WriteLine("If you wish to quit, enter 9.");

            //Call the relax method to determine which activity is run.       
            activity.Relax(calm);
            if (calm == "f")
            {
                starting = false;
            }
            else
            {
                starting = true;
            }
        }while(starting != false);
        
    }


}

/*
Inheritance programming
Abstraction ( what is being represented? )
Encapsulation ( what is being hidden?    )

Inheritance - the ability for one class to obtain the attributes and methods of another classs directly, without having to type them.
it follows the same idea of people inheriting certain characteristics from their parents.

Student : Person
new student = new person
Student student = new Student();
name = student

private   (unchangable data)
public    (Anyone has access)
protected (getters and setters)

class -
    Attributes and behaviours
    What is a class without Attributes?
        Interface - it only does things (action/verb)
    What is a class without Behaviours?
        Structure - only contains things (all are public)

Assignment
Input - 

3 files
*/
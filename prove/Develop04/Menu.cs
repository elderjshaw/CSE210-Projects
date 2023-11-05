/*
Relaxation Activity Program
c2023
*/
using System;
using System.Threading;
using System.Diagnostics;
using System.Net.Quic;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;


public class Menu
{



    public string Relax(string truth)
    {
        
        var DEchoice = Console.ReadLine();
        int DEact = Convert.ToInt32(DEchoice);

        if (DEact == 1)
        {
            //Start the Breathing Activity
            BreathingActivity breath = new BreathingActivity();
            truth = "t";
            return truth;
        }
        if (DEact == 2)
        {
            //Start the Reflecting Activity
            truth = "t";
            return truth;
        }
        if (DEact == 3)
        {
            //Start the Listing Activity
            truth = "t";
            return truth;
        }
        if (DEact == 4)
        {
            //Start the Thinking Activity
            truth = "t";
            return truth;
        }
        if (DEact == 9)
        {
            truth = "f";
            return truth;
        }
        else
        {
            Console.WriteLine("You have requested an activity that doesn't exist, try again.");
            truth = "t";
            return truth;
        }


        string DEgetTime = Console.ReadLine();
        int DEsetTime = Convert.ToInt32(DEgetTime);



    }

    protected static void Timer(int DEtime) 
    {
        DateTime DEcurrentTime = DateTime.Now;
        var DEtimer = new System.Timers.Timer(DEtime);
        DEtimer.Start();
        var DEstopTime = DateTime.Now + new TimeSpan(DEtime);
        

        if (DEcurrentTime >= DEstopTime)
        {
            DEtimer.Stop();
        }
        else
        {
            TimeSpan span = DEstopTime.Subtract(DEcurrentTime);
        }


        
    }


   public static void SpinnerLoad()
   {
        //Displays a loading indicator
        string loading = ("Timer paused....Loading..");
   }

   
}
/* dateime compare timer*/
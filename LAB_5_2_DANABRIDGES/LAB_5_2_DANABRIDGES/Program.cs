using System;
using System.Collections;

namespace LAB_5_2_DANABRIDGES
{
    class Program



        
    { 
        enum WeekDays
        {   Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        };










        static void Main(string[] args)
        {
            ArrayList tasklist = new ArrayList();
           
            foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("enter task for" + days);
                string task = days + Console.ReadLine();
                tasklist.Add(task);

            }


            foreach (string task in tasklist)
            {
                Console.WriteLine(task);
            }



        }
    }
}

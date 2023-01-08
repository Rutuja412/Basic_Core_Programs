using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void Checkyear()
        {
            Console.WriteLine("Enter Year You Want to check:");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is Leap Year ");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is Leap Year ");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not Leap Year ");
            }
            else
            {
                Console.WriteLine(year + " is not Leap Year ");
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class OddEven
    {
        public void Number()
        {
            int i;
            Console.WriteLine("Enter a number :");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is Even number");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Entered number is Odd number ");
               
            }
        }
    }
}

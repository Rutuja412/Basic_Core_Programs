using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            double value = Math.Pow(2, n);
            Console.WriteLine("Result : {0}", value);
            Console.ReadLine();
        }
    }
}

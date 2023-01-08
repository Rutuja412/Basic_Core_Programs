using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {

            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float s = 1 / 1;
            for (int i = 2; i <= n; i++)
            {
                s = s + 1 / (float)i;
            }
            Console.WriteLine("The sum of harmonic numbers {0} : ", +s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class PrimeFactors
    {
        public void Prime()
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fators are :");
            for (int i=0; i<n; i++) 
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

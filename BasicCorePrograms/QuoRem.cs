using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class QuoRem
    {
        public void Compute()
        {
            int number, divisor, quotient, remainder;
            Console.WriteLine("Enter a number you want to check:");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter divisor:");
            divisor=int.Parse(Console.ReadLine());

            quotient=number/divisor;
            remainder=number%divisor;

            Console.WriteLine("Quotient is: {0}", +quotient);
            Console.WriteLine("Remainder is :{0}", +remainder);
        }
    }
}

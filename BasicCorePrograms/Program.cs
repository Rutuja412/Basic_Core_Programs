using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            Console.WriteLine("-----FlipCoin Program-------");
            FlipCoin flipCoin = new FlipCoin();
            flipCoin.Flipcoinsimulation();
            Console.WriteLine("--------Leap Year Program--------");
            LeapYear leapYear=new LeapYear();
            leapYear.Checkyear();
            Console.WriteLine("---------Power of Two--------");
            PowerOfTwo powerOfTwo=new PowerOfTwo();
            powerOfTwo.Power();
            Console.WriteLine("-------Harmonic Number-----");
            HarmonicNumber harmonicNumber=new HarmonicNumber();
            harmonicNumber.Harmonic();
            Console.WriteLine("-----Prime Factors-----");
            PrimeFactors primeFactors=new PrimeFactors();
            primeFactors.Prime();
            
        }
    }
}

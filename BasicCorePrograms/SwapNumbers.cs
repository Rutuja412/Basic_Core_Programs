using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class SwapNumbers
    {
        public void Swapping()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter second number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter swapping :");
            Console.Write("\nFirst number :" + num1);
            Console.Write("\nSecond number :" + num2);
            Console.Read();
        }
    }
}

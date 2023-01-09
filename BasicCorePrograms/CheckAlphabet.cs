using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class CheckAlphabet
    {
        public void Vowel()
        {
            Console.Write("Enter Character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + " is vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is Consonant");
                    break;

            }
        }
    }
}

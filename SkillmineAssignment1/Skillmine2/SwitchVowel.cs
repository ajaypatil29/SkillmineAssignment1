using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class SwitchVowel
    {
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("Enter the Char:");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A': 
                case 'E':
                case 'I':
                case 'O':
                case 'u':Console.WriteLine("Vowel");

                    break;
                default:Console.WriteLine("Consonent");
                    break;



            }
        }
    }
}

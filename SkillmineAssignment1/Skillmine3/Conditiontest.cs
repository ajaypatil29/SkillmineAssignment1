using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Conditiontest
    {//Vowel or consonent using Ladder
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch =='a')
            {
                Console.WriteLine("vowel");
            }
            else if (ch=='e')
            {
                Console.WriteLine("vowel");
            }
            else if(ch=='i')
            {
                Console.WriteLine("vowel");
            }
            else if ( ch=='o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch=='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }
    }
  
}

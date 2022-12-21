using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class CountOddEvenString
    {
        static void Main(string []args)
        {
            char[] senstense = new char[20];

            int i, vowels = 0, conso = 0, special = 0, n;
            Console.WriteLine("enter the length");
            n = int.Parse(Console.ReadLine());
            for ( i = 0; i < n; i++)
            {
                senstense[i] = Convert.ToChar(Console.ReadLine());
            }
            for ( i = 0; senstense [i] !='\n' ; i++)
            {

            }
        }
    }
}

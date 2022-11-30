using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Conditiontest2
    {//without using ladder method
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("enter the char:");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch=='a'||ch=='e'||ch=='i'||ch =='o'||ch =='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}

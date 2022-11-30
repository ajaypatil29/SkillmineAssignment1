using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Conditiontest3cs
    {
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("Enter The character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'o' || ch == 'u') 
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
                
        }
    }
    class Conditiontest4
    {
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("enter the char:");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch=='A')
            {
                Console.WriteLine("Vowel");

            }
            else if (ch == 'E')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'I')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'O')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'U')
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



using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Logicaltest2
    {
        static void Main(string []args)
        {
            char ch;
            Console.WriteLine("Enter the Character");
            ch = Convert.ToChar(Console.ReadLine());
            if ((ch>='A' && ch<='Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("Alphabate");

            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Number");
            }
            else
            {
                Console.WriteLine("Spacial Char");
            }
        }
    }
}

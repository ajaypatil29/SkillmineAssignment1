using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Numberofdigit
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine ());
            int Count = 0;
            while (num>0)
            {
                int digit = num % 10;
                Count++;
                num = num / 10;

            }
            Console.WriteLine("Odd Numbers:" + Count);
        }
    }
}

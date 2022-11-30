using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class DayandDate
    {
       static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter the date ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("monday");

            }
            else if (num == 2) 
            {
                Console.WriteLine("tuesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("wensday");
            }
            else if (num == 4)
            {
                Console.WriteLine("thirsday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("satday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Sonday");
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}

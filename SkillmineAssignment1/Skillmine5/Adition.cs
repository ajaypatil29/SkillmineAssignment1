using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Adition
    {
        static void Main(string []args)
        {
            int firstdigit, lastdigit, num;
            int sum = 0;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());

            lastdigit = num % 10;
            firstdigit = num;
            while (num>=10)
            {
                num = num / 10;

            }
            firstdigit = num;
            sum = firstdigit + lastdigit;
            Console.WriteLine("Sum of first and last digit" + sum);

        }
    }
}

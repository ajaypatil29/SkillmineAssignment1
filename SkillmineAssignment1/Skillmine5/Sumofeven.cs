using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Sumofeven
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num!=0)
            {
                int digit = num % 10;
                if (digit %2==0)
                {
                    sum = sum + digit;
                    digit = num / 10;
                    Console.WriteLine(sum);
                    break;

                }
                
                else
                {
                    digit = num / 10;
                }

            }
        }
    }
}

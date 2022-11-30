using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class MaxNumber
    { static void Main(string []args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num3");
            num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if (num1>num2)
            {
                if (num1 > num3)
                    Console.WriteLine(num1 + " is Greater number");
                else 
                    Console .WriteLine(num3 + " is Greater number");
            }
            else if (num2>num1)

            {
                if (num2> num3)
                    Console.WriteLine(num2 + " is Greater number");

            }
            else
            {
                Console.WriteLine(num3 + " is Greater number");
            }

        }
    }
}

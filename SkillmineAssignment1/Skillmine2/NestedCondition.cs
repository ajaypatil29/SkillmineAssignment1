using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class NestedCondition
    {
        static void Main(string []args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter the num1:");
                num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num1:");
                num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num1:");
                num3= int.Parse(Console.ReadLine());
            string result = num1 > num2 && num1 > num3 ? num1 + " is greater number" : num2 > num1 && num2 > num3 ? num2 + "is greater number" : num3 + "is greater number";
            {
                Console.WriteLine(result);

            }
        }
    }
}

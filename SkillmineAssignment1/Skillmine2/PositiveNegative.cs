using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class PositiveNegative
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            string result = num > 0 ? num  + " is Positive Number" : num < 0 ? num + "  is Negative Number" : "Number is 0";
            Console.WriteLine(result);




        }
    }
}

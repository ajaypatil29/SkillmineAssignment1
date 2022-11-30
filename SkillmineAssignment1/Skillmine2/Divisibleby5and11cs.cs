using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Divisibleby5and11cs
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            string result = num % 5 == 0 ? "divisible by 5" : num % 11 == 0 ? "divisible by 11" : "Not divisible by 5& 11";
            Console.WriteLine(result);


        }
    }
}

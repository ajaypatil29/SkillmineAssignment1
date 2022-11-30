using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Userinput
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number:");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + 5);


        }
    }
}

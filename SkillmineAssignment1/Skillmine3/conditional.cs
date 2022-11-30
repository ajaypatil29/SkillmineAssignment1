using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Conditional
    {
        static void Main(string []args)
        {
            int num1;
            int num2;
            Console .WriteLine ("eneter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter the num2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(false);
            else 
               {
                Console.WriteLine(true);
            }
               

        }
    }
}

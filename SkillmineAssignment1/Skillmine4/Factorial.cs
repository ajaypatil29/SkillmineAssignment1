using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class Factorial
    {
        static void Main(string[]args)
        {
            int num = int.Parse(Console.ReadLine());
            int fact=1;
            for (int i=1;i<=num;i++)
                
            {
                fact =fact  * i;

            }
            Console.WriteLine("factorial of number=" + fact);

        }
    }
}

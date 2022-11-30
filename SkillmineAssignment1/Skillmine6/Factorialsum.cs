using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject6
{
    class Factorialsum
    {
        static void Main(string []args)
        {
            int fact = 1;
            int sum = 0;
            
            for (int i=1;1<=5;i++)
            {
                while (i>=0)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                int temp = sum;
                Console.WriteLine("sum" + temp);


            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Sumof1to10
    {
        static void Main(string []args)
        {
            int i = 1;
            int sum = 0;
            while (i<=10)
            {
                sum = sum + i;
                i++;
                
            }
            Console.WriteLine("sum=" + sum);

        }
    }
}

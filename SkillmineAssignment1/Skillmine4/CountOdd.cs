using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class CountOdd
    {
        static void Main(string []args)
        {
            int i;
            int sum = 0;
            int num = int.Parse(Console.ReadLine());
            for (i=1;i<=num;i++)
                if (i%2!=0)
                {
                    sum++;
                }
            Console.WriteLine("sum=" + sum);

        }
    }
}

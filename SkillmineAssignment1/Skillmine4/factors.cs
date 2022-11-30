using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class factors
    {
        static void Main(string []args)
        {
            int num;
            int i;
            int sum = 0;
            
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            for (i=1;i<=num;i++)
                if (num%i==0)     
            {
                    sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}

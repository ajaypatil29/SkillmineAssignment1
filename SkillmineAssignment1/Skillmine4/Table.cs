using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class Table
    {
        static void Main(string []args)
        {
            int Num;
            int i;
            Console.WriteLine("Enter the Number=");
            Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of Given Number");
            for (i = Num; i <= Num * 10; i++)
                
            if (i%Num==0)
            {
                Console.WriteLine(i);
            }

        }
    }
}

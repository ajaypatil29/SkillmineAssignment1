using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject6
{
    class Table
    {
        static void Main(string []args)
        {
            
            for (int i=1;i<=10;i++)
            {
                for (int j=1;j<=5;j++)
                {
                    Console.Write(j*i);
                }
                Console.WriteLine();
            }


        }
    }
}

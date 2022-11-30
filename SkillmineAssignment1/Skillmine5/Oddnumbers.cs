using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Oddnumbers
    {
        static void Main(string []args)
        {
            int i = 120;
            while (i>=81)
            {
                if( i%2!=0)
                {
                    Console.WriteLine(i);
                    i--;
                }
                else
                {
                    i--;
                }
               
            }
        }
    }
}

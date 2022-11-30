using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class Oddnumbers
    {
        static void Main(string []args)
        {
            int i;
            for (i=120; i>=81;i--)
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
        }
    }
}

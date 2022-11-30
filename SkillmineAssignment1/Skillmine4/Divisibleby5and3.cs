using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject4
{
    class Divisibleby5and3
    {
        static void Main(string []args)
        {
            int i;
            for (i=1;i <= 50;i++)
                if(i%3==0 || i%5==0)
            {
                    Console.WriteLine(i);
            }

        }
    }
}

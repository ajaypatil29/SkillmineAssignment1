using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Divisibleby5
    {
        static void Main(string[] args)
        {
            int i;
            for ( i=1;i<=50;i++)
            {
                if (i % 5 == 0)
                    continue;
                    Console.WriteLine(i);

            }
            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Countodd
    {
        static void Main(string []args)
        {
            int i;
            int num;
            int even = 0;
            int odd = 0;
            int count = 0;
            Console.WriteLine("enter");
            num = int.Parse(Console.ReadLine());
            for (i=1;i<=num;i++)
            {
               if (i%2!=0)
               {


                    odd++;
                   
                

               }
                





            }
            Console.WriteLine(odd);
        }
    }
}

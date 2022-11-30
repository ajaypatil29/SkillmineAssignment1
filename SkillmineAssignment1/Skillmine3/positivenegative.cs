using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Positivenegative
    {
        static void Main(string []args)
        {
            int Num;
            Console.WriteLine ("Enter The number:");
            Num = int.Parse(Console.ReadLine());
            if (Num >0 )
            {
                Console.WriteLine("positive");
            }
            else if (Num< 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("0");

            }
        }
    }
}

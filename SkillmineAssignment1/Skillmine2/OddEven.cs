using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class OddEven
    {
        static void Main(string[]args)
        {
            int number;
            

            Console.WriteLine("enter the number:");
                number= int.Parse(Console.ReadLine());
           

            switch (number%2==0 )

            {
                case true : Console.WriteLine("Even");
                break;
                case false: Console.WriteLine("Odd");
                break;
                default: Console.WriteLine("invalid input");
                    break;



            }


        }
    }
}

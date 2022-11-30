using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Trimorphic
    {
        static void Main(string []args)
        {
            int num;
            int digit;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            int cube = (num * num* num);
            Console.WriteLine("Cube of given Number=" + cube );
            while (cube>0)
            {
                digit = cube  % 10;
                Console.WriteLine("Digit="+digit);
               

                if (digit == num)
                {
                    Console.WriteLine("Trimorphic num");
                }
                else
                {
                    Console.WriteLine("not Trimorphic num");
                }
                break;
            }
           


     
           

            
                

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Spynumber
    {
        static void Main(string []args)
        {
            int num;
            
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int multi = 1;

            while (num>0)
            {
                int digit = num % 10;
                sum1 = sum1 + digit;
                multi = multi * digit;
                num = num / 10;
               

               

                
            }
           if (sum1==multi )
            {
                Console.WriteLine("number is spy number");
            }
           else
            {
                Console.WriteLine("number is not spy number");
            }
            
            
            
        



            

        }
              
    }
}

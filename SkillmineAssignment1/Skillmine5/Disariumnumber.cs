using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Disariumnumber
    {
      static void Main(string []args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            int digit;
            int original = num;
            int sum= 0;
            int count=0;
            while(num>0)
            {
              
                num = num / 10;
                count++; 
             
            }
            
                num = original;
                while (num>0)
                {
                    int power = 1;
                    int r = num % 10;
                    for (int i=1;1<=count; i++)
                    {
                        power = power * r;

                    }
                    {
                        sum = sum + power;
                        count--;
                        num = num / 10;
                    }
                    if (original ==sum )
                    {
                        Console.WriteLine("disarium number");

                    }
                    else
                    {
                        Console.WriteLine("disarium number");
                    }
                }
            
            





        }
    }
}

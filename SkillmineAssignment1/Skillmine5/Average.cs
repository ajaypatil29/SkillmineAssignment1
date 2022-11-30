using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Average
    {
        static void Main(string []args)
        {
            int sum = 0;
            int count = 0;
            int num;
            for ( num=1;num<=20;num ++)
            {
                bool isprime =true;
                for (int i=2;i<num;i++)
                {
                    if (num%i==0)
                    {
                        isprime = false;
                            break; 
                    }
                }
                if(isprime==true)
                {
                    
                    sum = sum + num;
                 
                }
                Console.WriteLine(sum );



            }
        }
    }
}

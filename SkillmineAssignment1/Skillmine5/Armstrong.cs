using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Armstrong
    {
        static void Main(string []args)
        {
            int num;
           

            int rem;
            int cube; ;
            int result = 0;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num!=0)
            {

                rem = num % 10;
                cube = rem * rem * rem;
                result = result + cube;
                num = num / 10;
                
                
            }
            num = temp;
            if (num  ==result)
            {
                Console.WriteLine("armstrong number");
            }
            else
            {
                Console.WriteLine(" not armstrong number");
            }

            
            



        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Whiledemo
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            int sum = 0;


            while (num>0)
            {
                int digit = num % 10;
                if (digit %2==0)
                {
                    sum = sum + digit;
                    num = num / 10;
                }
                else 
                {
                    num = num / 10;
                }

                
                


            }
            Console.WriteLine(sum);

        }

    }
    class Odddigit
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                int Digit = num % 10;
                if (Digit %2!=0)
                {
                    Console.WriteLine(Digit );
                    num++;
                    num = num / 10;

                }
                else
                {
                    num = num / 10;
                }
                

            }
        }
    }

}

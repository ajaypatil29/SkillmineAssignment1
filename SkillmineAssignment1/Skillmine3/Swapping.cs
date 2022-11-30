using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Swapping
    {
        static void Main(string []args)
        {
            int num1; int num2;
            Console.WriteLine("Enter The Num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 +" "+ num2) ;
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + " " + num2);

            


        }
    }
}

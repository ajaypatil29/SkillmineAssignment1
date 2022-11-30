using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Calculator
    {
        static void Main(string []args)
        {
            int num1;
            int num2;
            char op;

            Console.WriteLine("enter the num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Substraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            Console.WriteLine("Enter Number For Operation");
            op = Convert.ToChar (Console.ReadLine());
            switch (op )
            {
                case '1': Console.WriteLine("Adition=" + (num1 + num2));
                    break;
                case '2':
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case '3':
                    Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;
                case '4':
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;
                default:Console.WriteLine("Invalid Operation");
                    break;
            }


        }
    }
}

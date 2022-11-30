using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject5
{
    class Calculator
    {
        static void Main(string []args)
        {
            int num1; 
            int num2;
            char ch;
           
            do
            {
                Console.WriteLine("Enter the number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the choice from below operation");
                Console.WriteLine("1) Addition\n2)substraction\n3)multiplication\n4)Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("Substaction" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("Division=" + num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");

                        break;

                }
                Console.WriteLine("Do you Want to continue .......");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
          


        }
    }
}

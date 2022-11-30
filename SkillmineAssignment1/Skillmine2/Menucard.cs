using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Menucard
    {
        static void Main(string[] args)
        {
            char Menu;
            int quantity;
            int Tea = 30;
            int coffee = 40;
            int Pepsy = 20;
            int Thumpsup = 45;
            Console.WriteLine("Menu Card");
            
            Console.WriteLine("(1) Tea=30rs");
            Console.WriteLine("(2) Coffee=40rs");
            Console.WriteLine("(3) Pepsy=20rs");
            Console.WriteLine("(4) Thumps up=45rs");
            Console.WriteLine("Enter Number of Menu you want to order");

            Menu = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the Quantity:");
            quantity   = int.Parse(Console.ReadLine());
            switch (Menu )
            {
                case'1':Console.WriteLine("Bill=" + (Tea * quantity));
                    break;
                case '2': Console.WriteLine("Bill=" + (coffee  * quantity));
                    break;
                case '3':
                    Console.WriteLine("Bill=" + (Pepsy  * quantity));
                    break;
                case '4':
                    Console.WriteLine("Bill=" + (Thumpsup * quantity));

                    break;
                default:Console.WriteLine("You have Selected invalid menu");
                    break;




            }
            Console.WriteLine("Thank you for Your Order");
         










        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Switchdemo
    {
        static void Main(string []args)
        {
            string  city;    
            
            Console.WriteLine("Enter the city name");
            city = Console.ReadLine();
            switch (city)
            {
                case "Pune": Console.WriteLine("Welcome to Pune");
                    break;
                case "Mumbai": Console.WriteLine("Welcome to mumbai");
                    break;
                case "Delhi": Console.WriteLine("welcome to delhi");
                    break;
                default: Console.WriteLine("invalid input");
                    break;

                        

            }


        }
    }
}

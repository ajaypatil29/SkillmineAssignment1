using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Percentage
    {
        static void Main(string[] args)
        {//marks out of 100
            int Eng;
            int Maths;
            int History;
            int Hindi;
            int science;

            Console.WriteLine("enter the marks of Eng");
            Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of Maths");
            Maths  = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of History");
            History  = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of Hindi");
            Hindi  = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of science");
            science  = int.Parse(Console.ReadLine());

            int per = (500 / (Eng + Maths + History + Hindi + science)) * 100;

            if (per>70)
            {
                Console.WriteLine("Distinction");

            }
            else if (per <60 && per>50)
            {
                Console.WriteLine("First class");
            }
            else if (per<50 && per>35)
            {
                Console.WriteLine("2ns class");
            }
            else 
            {
                Console.WriteLine("fail");
            }
        }
        

    }
}

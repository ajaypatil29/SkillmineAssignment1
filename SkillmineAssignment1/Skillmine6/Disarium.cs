using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject6
{
    class Disarium
    {
        static void Main(string []args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine ());
            int countdigit = 0;
            int temp = n;
            int temp1 = n;
            while(n>0)
            {
                int digit = n % 10;
                n = n / 10;
                countdigit++;

            }
            n = temp;
            int sum = 0;
            while(n>0)
            {
                int digit = n % 10;
                int power = 1;
                for (int i = 1; i <countdigit ; i++)
                {
                    power = power * digit;

                }
                sum = sum + power;
                n = n / 10;
                countdigit--;

            }
            if (temp1==sum )
            {
                Console.WriteLine("It is a disarium number");
            }
            else
            {
                Console.WriteLine("It is a not disarium number");
            }
        }
    }
}

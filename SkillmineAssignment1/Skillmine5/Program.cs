using System;

namespace Skillmineproject5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            int i = 1;
            while (i <= 20)


            {
                if (i % 2 != 0)
                    sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum of Odd Numbers="+sum);

        }
    }
}

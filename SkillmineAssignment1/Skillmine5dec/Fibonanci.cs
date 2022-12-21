using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Fibonanci
    {
       static void Main(string []args)
        {
            Console.WriteLine("enter the range");
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int num2 = 1;
            int num3;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num);
                
                num3 = num + num2;
                num = num2;
                num2 = num3;
                
            }
           

        }
    }
}

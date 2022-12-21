using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class SumofArray
    {
        public void Finds(int[]a)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if(num== a[i] + a[j])
                    {
                        Console.WriteLine($"({a[i]},{a[j]})");
                    }
                }

            }
        }
        static void Main(string []args)
        {
            int[] arr = { 4, 5, 7, 9, 1, 5, 3,2 };
            SumofArray b = new SumofArray();
            b.Finds(arr);

        }
    }
}

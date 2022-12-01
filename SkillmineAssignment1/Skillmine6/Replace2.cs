using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Replace2
    {
        public void Negative(int[]a)
        {
            for (int i = 0; i <a.Length; i++)
            {
                if(a[i]>0)
                {
                    Console.WriteLine(a[i]);
                }
                else if (a[i]<0&&a[i-1]>0)
                {
                    Console.WriteLine((a[i - 1]) * (a[i - 1]));
                }
                else
                {
                    Console.WriteLine(a[i-2]);
                }
            }
        }
        static void Main(string []args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the number");
            for (int i = 0; i <6; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Replace2 b = new Replace2();
            b.Negative(arr);
        }
    }
}

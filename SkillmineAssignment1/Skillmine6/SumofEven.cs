using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class SumofEven
    {
        public int SumofEven1(int[]a)
        {
            int sum = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string []args)
        {
            int[] arr = { 4, 8, 7, 2, 5,8,2 };
            SumofEven b = new SumofEven();
            Console.WriteLine("sum from array" + b.SumofEven1(arr));

        }
        
        

    }
}

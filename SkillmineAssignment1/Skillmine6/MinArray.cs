using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class MinArray
    {
        public int Minarray1(int[]a)
        {
            int min = a[0];
            for (int i = 0; i <a.Length; i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
                
            }
            return min;


        }

        static void Main(string []args)
        {
            int[] arr = { 1, 2, 5, 7, 6, 9, 0, 45 };
            MinArray b = new MinArray();
            Console.WriteLine("Min Value=" + b.Minarray1(arr));
        }
    }
}

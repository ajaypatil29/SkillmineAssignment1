using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Array3
    {
        public void  Even(int[]a)
        {
            int evennum = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine("Even="+a[i]);
                }

            }
            
           
        }
        public void Odd(int[]b)
        {
            for (int i = 0; i <b.Length; i++)
            {
                if(b[i]%2!=0)
                {
                    Console.WriteLine("Odd"+b[i]);
                }
            }
        }
        static void Main(string []args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array3 a = new Array3();
            a.Even(arr);
            Array3 c = new Array3();
            c.Odd(arr);
        }
    }
}

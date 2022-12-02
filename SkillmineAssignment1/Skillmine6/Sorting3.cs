using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Sorting3
    {
        public int[] sort1(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i;j<a.Length/2;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;


        }
        static void Main (string []args)
        {
            int[] arr = { 1, 2, 3, 5,7,6 };
            Console.WriteLine(string.Join(" ", arr));
            Sorting3 b = new Sorting3();
            Console.WriteLine("//////"+string.Join(" ", b.sort1(arr)));
            

        }
    }
}

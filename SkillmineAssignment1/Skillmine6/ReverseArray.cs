using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class ReverseArray
    {
        public int[] Revers(int[]a)
        {
            int j = a.Length - 1;
            for (int i = 0; i <a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                temp = a[i];
                j--;

            }
            return a;
        }
        static void Main(string []args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(" ", arr));
            ReverseArray b = new ReverseArray();
           int[] myarray= b.Revers(arr);
            Console.WriteLine(string.Join(" ", myarray));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Sorting
    {
        public int[] mysort(int[]a)
        {
            for (int i = 0; i <a.Length; i++)
            { 
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;
        }
        static void Main(string[]args)
        {
            int[]arr= { 8, 3, 5, 1, 9 };
            Console.WriteLine(string.Join(" ", arr));
            Sorting b = new Sorting();
            Console.WriteLine("......." + string.Join("  ",b.mysort(arr)));
        }
        
        
    }

    class Dessending
    {
        public int[] mysort2(int[]a)
       
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, 1, 9 };
            Console.WriteLine(string.Join(" ", arr));
            Dessending  b = new Dessending ();
            Console.WriteLine("......." + string.Join("  ", b.mysort2(arr)));
        }
    }
}

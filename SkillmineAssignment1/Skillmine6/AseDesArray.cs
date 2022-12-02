using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class AseDesArray
    {
        public int[] Display(int[]a)
        {
            int c;
            for(int i=0;i<a.Length;i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i<a.Length/2)
                    {
                        if(a[i]>a[j])
                        {
                            c = a[j];
                            a[j] = a[i];
                            a[i] = c;
                        }
                    }
                    else
                    {
                        if (a[i] < a[j])
                        {
                            c = a[j];
                            a[j] = a[i];
                            a[i] = c;
                        }
                    }
                }
                
            }
            return a;

        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 9, 4, 6, 7, 3, 8};
            AseDesArray b = new AseDesArray();
            Console.WriteLine(string.Join(" ", arr));
            b.Display(arr);
            int[] ad = b.Display(arr);
            for (int i = 0; i < ad.Length; i++)
            {
                Console.Write(ad[i] + "  ");
            }
            Console.WriteLine();
    }   }
}

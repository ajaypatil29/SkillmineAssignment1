using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class CompareTwoArray
    {
        public void Compare(int[] a)
        {
            for (int i = 0; i <a.Length ; i++)
            {
                for (int j = 0; j < a.Length ; j++)
                {
                    if(a[i]+a[j]==5)
                    {

                    }
                }
            }
        }
        static void Main(string []args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] arr1 = { 5, 3, 8, 6 };

            CompareTwoArray b = new CompareTwoArray();
            b.Compare(arr);
            CompareTwoArray c = new CompareTwoArray();
            c.Compare(arr1);
        }
           

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class CountOdd
    { 
        public int CountOdd1(int []a)
        { int count = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i]%2!=0)
                {
                    count++;

                }
                

            }
            return count;
        }
        static void Main(string []args)
        {
            int[]arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CountOdd b = new CountOdd();
            Console.WriteLine("Count of Odds" + b.CountOdd1(arr));
        }
    }
}

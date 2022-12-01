using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class AtlernateArray
    {
        public void  Alternate(int[]a)
        {
            for (int i = 0; i <a.Length; i++)
            {
                
                if(i==1||i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }

            }
        }

        static void Main(string []args)
        {
            int[] arr = new int[6];
            Console.WriteLine("enter the number");
            for (int i = 0; i < 6; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            AtlernateArray b = new AtlernateArray();
            b.Alternate(arr);
           

        }
    }
}

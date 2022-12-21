using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class ShiftArrayElement
    {
        public void Shift(int[]a)
        {
            int i;
            for ( i = 0; i <a.Length; i++)
            {
                for (int j = i+1; j <a.Length ; j++)
                {
                    if(a[j]==0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);



            }

        }
        public void Shiftlast(int []x)
        {
            int i;
            for (i = x.Length-1 ; i >=1; i--)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (x[j] != 0)
                    {
                        int temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
                Console.WriteLine(x[i]);



            }
        }
        static void Main(string []args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            ShiftArrayElement b = new ShiftArrayElement();
            b.Shift(arr);
            Console.WriteLine("--------------------------");
            ShiftArrayElement c = new ShiftArrayElement();
            c.Shiftlast(arr);
        }
    }
}

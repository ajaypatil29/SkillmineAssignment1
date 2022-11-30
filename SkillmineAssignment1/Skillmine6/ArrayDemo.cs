using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class ArrayDemo
    {
        public void DisplayEven(int[]arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                if(arr[i]%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string []args)
        {
            int[]a=new int[5];
            Console.WriteLine("enter the array element");
            for (int i= 0; i <a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            ArrayDemo myobj = new ArrayDemo();
            myobj.DisplayEven(a);
        /*    Console.WriteLine(myobj.DisplayEven(a));*/
            

        }
    }
}

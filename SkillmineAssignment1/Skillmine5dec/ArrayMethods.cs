using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class ArrayMethods
    {
        static void Main(string []args)
        {
            int[] arr = new int[6];
            int[] arr2 = new int[3];
            for (int i = 0; i < arr.Length ; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("////////////////////");
            //Assending
            Array.Sort(arr);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            //reverse
            Console.WriteLine( "////////////////////");
            Array.Reverse(arr);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("////////////////////");
            //Sort from perticular Posistion
            Array.Sort(arr, 1, 3);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("////////////////////");
            //Coppy array
            Array.Copy(arr, arr2, 3);
            foreach (var a in arr2)
            {
                Console.WriteLine("copy="+a);
            }
            Console.WriteLine("////////////////////");
            //Clear
            Array.Clear(arr, 1, 3);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

        }
    }
}

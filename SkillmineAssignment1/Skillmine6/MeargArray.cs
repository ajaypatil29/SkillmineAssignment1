using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class MeargArray
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 3, 2 };
            int[] arr2 = { 1, 2, 7, 4, 6 };

            int[] arr3 = new int[arr.Length + arr2.Length];
            Console.WriteLine(arr3.Length);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i]);
                }
                /*for (int j = 0; j < arr3.Length; j++)
                {
                    Console.Write(arr[i]);
                }*/
            }
            Console.WriteLine();

        }    
        
    }
}

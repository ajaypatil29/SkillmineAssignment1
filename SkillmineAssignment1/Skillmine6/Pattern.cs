using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Pattern
    {
        
        static void Main(string []args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] a =new  int[3, 3];
            Console.WriteLine("enter the array element");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("///////////////");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("///////////////");
            for (int i=0;i<=a.GetUpperBound(0);i++)
            {
                for (int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i, j] + " ");


                }
                Console.WriteLine();
            }
            

        }
    }
}

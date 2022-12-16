using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class TwoDarray
    {
        public void Array(int[,]a)
        {
            for (int i = 0; i <a.GetLength(0) ; i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string []args)
        {
            { 
                int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 7, 5, 3 } };
                TwoDarray a = new TwoDarray();  
                a.Array(arr);
            }
        }
    }
}

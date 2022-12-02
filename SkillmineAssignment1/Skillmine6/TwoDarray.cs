using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class TwoDarray
    { 
        public void SumofRow(int[,]a)
        {
            
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");


                }
                Console.Write(" = " + sum);
                Console.WriteLine();
            }

        }
           
        static void Main(string []args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            TwoDarray b = new TwoDarray();
            b.SumofRow(arr);

        }
    }

    class TwoDarray2
    {
        public void SumofColumn(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[j,i];
                    Console.Write(a[j,i] + "  ");

                }
                Console.Write(" =" + sum);
                Console.WriteLine();
            }
        }
        static void Main(string []args)
        {
            int[,]arr= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            TwoDarray2 b = new TwoDarray2();
            b.SumofColumn(arr);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class FindMax
    { 
        public void FindMaxValue(int[,]a)
        {
            
            for (int i=0;i<a.GetLength(0);i++)             
            {
                int max = a[0, i];
                for (int j=0;j<a.GetLength(1);j++)
                {
                    if(a[j,i]>max)
                    {
                        max = a[j, i];
                    }
                }
                Console.Write("Max" + max);
                Console.WriteLine();

            }
        }
        static void Main(string []args)
        {
            int[,] arr = { { 4, 1, 2 }, { 5, 6, 2 }, { 8, 5, 6 } };
            FindMax b = new FindMax();
            b.FindMaxValue(arr);

        }
    }

    class Findmax2
    {
        public void FindmaxvalueRow(int[,] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.Length; j++)
                {
                    
                    if (a[i, j] > max)
                    {
                        max = a[i, j];

                    }
                    Console.Write("Max=" + max);
                    Console.WriteLine();
                }

            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 4, 1, 2 }, { 5, 6, 2 }, { 8, 5, 6 } };
            Findmax2 b = new Findmax2();
            b.FindmaxvalueRow(arr);
        }
    }
}

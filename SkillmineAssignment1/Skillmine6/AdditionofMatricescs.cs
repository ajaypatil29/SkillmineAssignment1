using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class AdditionofMatricescs
    {
        static void  Main(string []args)
        {
            int[,] num1 = new int[3,3];
            int[,] num2 = new int[3, 3];
            int[,] num3 = new int[3, 3];
            Console.WriteLine("enter the first Array element");
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element{0},{1}", i, j);
                    num1[i, j] = int.Parse(Console.ReadLine());

                }


            }
            Console.WriteLine("enter the second Array element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element{0},{1}", i, j);
                    num2[i, j] = int.Parse(Console.ReadLine());

                }


            }
            Console.WriteLine("First Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num1[i, j]);
                }
                Console.WriteLine();
                    
            }
            Console.WriteLine("Second Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num3[i, j] = num1[i, j] + num2[i,j];
                }

            }
            Console.WriteLine("Addition");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }
    }
}

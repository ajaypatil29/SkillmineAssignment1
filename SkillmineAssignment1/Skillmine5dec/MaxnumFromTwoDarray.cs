using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class MaxnumFromTwoDarray
    {
        public void Find(int[,] a)
        {
          
           
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    if (a[i, j] > max) 
                    {
                        max = a[i,j];
                        
                       
                    }
                  
                   

                }
                Console.WriteLine("Max value="+max );
               
                
            }
            
        }
        static void Main(string []args)
        {
            /*int[,] arr = { { 5,2,22},
                            {4,7,6 },
                           {7,8,9 } };
            MaxnumFromTwoDarray b = new MaxnumFromTwoDarray();
            b.Find(arr);*/

            int x,y;
            Console.WriteLine("enter the rows");
            
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the column");
            y = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[x, y];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength (1); j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            MaxnumFromTwoDarray c = new MaxnumFromTwoDarray();
            c.Find(arr1);
        }
    }
}

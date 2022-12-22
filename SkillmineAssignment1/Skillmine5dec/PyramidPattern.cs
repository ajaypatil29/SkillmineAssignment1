using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class PyramidPattern
    {
        static void  Main(string []args)
        {
            int k = 1;
            for (int i = 1; i <=4; i++)
            {
                for (int j = 4; j >=1; j--)
                {
                    if(i<j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($" {k++}");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}

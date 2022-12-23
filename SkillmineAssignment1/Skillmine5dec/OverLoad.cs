using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    public class calculation
    {
       
            public int Operation(int a, int b)
            {
                return a + b;
            }
            public int Operation(int a, int b,int c)
            {
                return a + b-c;
            }
            public int Operation(int a, int b,int d,int s)
            {
                return a + b - d * s;
            }
        
        static void Main(string []args)
        {
            calculation c1 = new calculation();
            c1.Operation(1, 2);
            Console.WriteLine(c1.Operation(1, 2,3,4));
           
        }

    }

}

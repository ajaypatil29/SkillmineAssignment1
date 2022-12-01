using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Replaceby0
    {public void  Replace(int[]a)
        {
            for (int i = 0; i <a.Length ; i++)
            { if(a[i]%3==0)
                {
                    Console.WriteLine(a[i] = 0);
                }
            else
                {
                    Console.WriteLine(a[i] );
                }

            }
           
        }
        static void Main(string []args)
        {
            int[] arr = { 1, 3, 4, 5, 9, 6, 25, 21, 87, };
            Replaceby0 b = new Replaceby0();
            b.Replace(arr);
        }
    }
}

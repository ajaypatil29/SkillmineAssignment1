using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem12
    {
        public void Frequent(char[]a)
        {
            int count = 0;
            int c;
            for (int i = 0; i <a.Length ; i++)
            {
                for (int j = 1; j <a.Length ; j++)
                {
                    if(a[i]==a[j])
                    {
                        count++;

                    }

                }
                
               
            }
            Console.WriteLine(count);
        }
        static void Main(string []args)
        {
            string str = "Enterprenure";
            char[] ch = str.ToCharArray();
            Problem12 b = new Problem12();
            b.Frequent(ch);
          

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem10
    {
        public void Reverse(char []a)
        {
            for (int i = a.Length -1; i >-1; i--)
            {
                Console.Write(a[i]);
            }
        }
        static void Main(string []args)
        {
            string str = "Wrong number";
            char[] ch = str.ToCharArray();
            Problem10 b = new Problem10();
            b.Reverse(ch);
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem11
    {
        public void ReversWord(string []a)
        {
            for (int i = a.Length -1; i >-1; i--)
            {
                Console.Write(a[i]+" ");
            }
        }
        static void Main(string []args)
        {
            string str = "we all are playing cricket";
            string[] s1 = str.Split(" ");
            Problem11 b = new Problem11();
            b.ReversWord(s1);
        }
    }
}

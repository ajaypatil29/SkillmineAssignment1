using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem1
    {
        static void Main(string []args)
        {
            string str = "HELLO$WORLD";
            string []s1 = str.Split("$");
            foreach (string item in s1)
            {
                Console.WriteLine(item );
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem6
    {
        static void Main(string []args)
        {
            string str = "I collected all the pens and gave all the pens to Jay";
            string s1 = str.Replace("all", "");
            Console.WriteLine(str);
            Console.WriteLine(s1);
        }
    }
}

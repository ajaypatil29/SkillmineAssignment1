using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    
    class Problem5
    {
        static void Main(string []args)
        {
            string str = "I play cricket";
            string[] c1 = str.Split(" ");
            int count = c1.Length;
            Console.WriteLine( count );
        }
        
        
    }
}

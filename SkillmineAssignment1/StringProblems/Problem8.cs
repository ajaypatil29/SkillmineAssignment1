using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem8
    {
        public void Toggle(char []a)
        {
            for (int i = 0; i <a.Length ; i++)
            {
                if (a[i] > 'a' || a[i] < 'z')
                {
                    a[i] = (char)(a[i] - 32);
                }
                else if (a[i] > 'A' || a[i] < 'A')
                {
                    a[i] = (char)(a[i] +2);
                }
            }
        }
        static void Main(string []args)
        {
            string str = "i aM Ajay ";
            char[] ch = str.ToCharArray();
            Problem8 c = new Problem8();
            c.Toggle(ch);
            Console.WriteLine(ch);
           
        }
    }
}

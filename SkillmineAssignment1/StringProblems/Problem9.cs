using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem9
    {
        public void Count(char[] a)
        {
            int countV = 0;
            int countC = 0;
            for (int i = 0; i <a.Length ; i++)
            {
                if(a[i]=='a'|| a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' )
                {
                    countV++;
                }
                else if (a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    countV++;
                }
                else
                {
                    countC++;
                }
            }
            Console.WriteLine("Vowel count="+countV );
            Console.WriteLine("consonent count=" + countC );
        }
        static void Main(string []args)
        {
            string str = "EnterprEnure";
            char[] ch = str.ToCharArray();
            Problem9 b = new Problem9();
            b.Count(ch);

        }
    }
}

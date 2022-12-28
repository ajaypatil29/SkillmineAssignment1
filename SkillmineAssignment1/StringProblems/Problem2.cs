using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.StringProblems
{
    class Problem2
    {
        public void Occuranc(char []a)
        {
            int count=0;
            char c = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < a.Length ; i++)
            {
                
                
                    if(c==a[i])
                    {
                        count++;
                    }

                
               
            }
            Console.WriteLine(count);
        }
        static void Main(string []args)
        {
            string str = "ajay";
            char[] ch = str.ToCharArray();
            Problem2 a = new Problem2();
            a.Occuranc(ch);

        }
    }
}

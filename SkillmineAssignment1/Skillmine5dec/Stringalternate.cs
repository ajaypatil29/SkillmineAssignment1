using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Stringalternate
    {
        public void Alter(char []a)
        {
            for (int i = 1; i <a.Length ; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
        }
        static void Main(string []args)
        {
            string s1 = Console.ReadLine();
            char[] ch = s1.ToCharArray();
            Stringalternate b = new Stringalternate();
            b.Alter(ch);

        }
    }
}

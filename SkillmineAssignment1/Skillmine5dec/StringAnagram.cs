using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class StringAnagram
    {
       
        static void Main(string []args)
        {
            Console.WriteLine("Enter the first word");
            string s1 = Console.ReadLine();
            char[] ch = s1.ToCharArray();
           
            Console.WriteLine("Enter the Second word");
            string s2 = Console.ReadLine();
            char[] ch2 = s2.ToCharArray();
            
            Array.Sort(ch);
            Array.Sort(ch2);

            string new1 = new string(ch);
            string new2 = new string(ch2);
            Console.WriteLine("result");
            if(new1 ==new2 )
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }

        }
    }
}

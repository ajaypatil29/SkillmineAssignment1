using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class StringMethods
    {
        static void  Main(string []args)
        {
            string s1 = "Hello Good Morning All  ";
            string s2 = "Wellcome to C#";
            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);
            bool result=s1.StartsWith("Hello");
            Console.WriteLine(result );
            bool result2 = s2.EndsWith("C#");
            Console.WriteLine(result2 );
            bool r = s1.Contains("All");
            Console.WriteLine(r);
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());
            Char[] ch = s1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }
            s1.Trim();
            s1.TrimEnd();
            s1.TrimStart();

            string a1 = "Test";
            string a2 = "test";
            bool result1 = a1.Equals(a2);
            Console.WriteLine(result1 );
            int res = a1.CompareTo(a2);
            Console.WriteLine(res );
            char[] ch1 = { 'a', 'b', 'c', 'd' };
            string x = new string(ch1);
            Console.WriteLine(x);
            char[] ch3 = a2.ToCharArray();
            foreach (var item in ch3)
            {
                Console.WriteLine(item );
            }
            
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Palindrome24
    {
        public void Palindrome(char []a)
        {
            bool flag = false;
            for (int i = 0,  j = a.Length - 1; i <a.Length /2; i++)
            {
                if(a[i]==a[j])
                {
                    flag = true;
                }
            }
            if(flag==true )
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
        static void  Main(string []args)
        {
            string  num = Console.ReadLine();
            Palindrome24 b = new Palindrome24();
            char[] ch = num.ToCharArray();
            
            b.Palindrome(ch);
        }
    }
}

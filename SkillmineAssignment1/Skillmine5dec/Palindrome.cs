using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Palindrome
    {
        public void Array(char[] a)
        {
            bool flag = false;
            for (int i = 0, j = a.Length - 1; i < a.Length / 2; i++)
            {
                if (a[i] == a[j])
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
                Console.WriteLine("not palindrome");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Palindrome b = new Palindrome();
            b.Array(ch);

        }

    }
}

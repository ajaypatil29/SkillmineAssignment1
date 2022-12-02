using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Charsort
    {
        public char[] mysort2(char[]a)
        {
            for(char i='A';i<a.Length;i++)
            {
                for(char j=i;j<a.Length;j++)
                {
                    if (a[i]<a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp; 
                    }
                }
            }
            return a;
        }
        static void Main(string []args)
        {
            char[] arr = { 'B', 'E', 'C', 'A' };
            Console.WriteLine(string.Join(" ", arr));
            Charsort c = new Charsort();
            c.mysort2(arr);
            Console.WriteLine(string.Join(" ", c.mysort2(arr)));
        }
    }
}

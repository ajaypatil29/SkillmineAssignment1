using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Arrays
{
    class ToggleArray
    {
        public char[]changeArrey(char[]ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]>='A'&&ch [i] <='Z')
                {
                    ch[i] = (char)(ch[i] + 2);
                }
            }
            return ch;

        }
        static void Main(string []args)
        {
            char[] c = { 'A', 'B', 'C', 'D' };
            Console.WriteLine(string.Join(" ",c));
            ToggleArray t = new ToggleArray ();
            char[] mytoggle = t.changeArrey(c);
            Console.WriteLine(string.Join(" ", mytoggle));
            
        }
    }
}

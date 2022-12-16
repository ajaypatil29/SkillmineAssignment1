using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class ToggleString
    {
       public void  Togggle(string sc)
        {
            char[] c = sc.ToCharArray();
            for (int i = 0; i <c.Length ; i++)
            {
                if(c[i]>'a' && c[i]<'z')
                {
                    c[i] = (char )(c[i] - 32);
                }
               else  if (c[i] >= 'A' &&  c[i] <= 'Z')
                {
                    c[i] = (char)(c[i] + 32);
                }
            }
            string str = new string(c);
            Console.WriteLine(str );
        }
        static void Main(string []args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();


            ToggleString o = new ToggleString();
            o.Togggle(str);





        }
    }
}

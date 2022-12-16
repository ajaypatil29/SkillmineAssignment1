using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Stringbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            sb.Append("welcome to session");
            Console.WriteLine(sb);
            double price = 45000;
            sb.AppendFormat("price is {0:C}", price);
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length );
           
        }
    }
}

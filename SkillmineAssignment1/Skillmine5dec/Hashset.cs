using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Hashset
    {
        static void Main(string []args)
        {
            HashSet<int> list1 = new HashSet<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);

            list1.Remove(20);
            foreach (var item in list1 )
            {
                Console.WriteLine(item );
            }
        }
       
    }
}

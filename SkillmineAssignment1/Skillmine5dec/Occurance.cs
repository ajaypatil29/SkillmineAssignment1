using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Occurance
    {
        public void  Arrays(string []a)
        {
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            int count = 0;
            for (int i = 0; i <a.Length ; i++)
            {
                if(a[i]==word )
                {
                    count++;
                }
            }
            Console.WriteLine(count );
        }
        static void  Main(String []args)
        {
            Console.WriteLine("enter the sentence");
            string str = Console.ReadLine();
            string[] str1 = str.Split();
            Occurance b= new Occurance();
            b.Arrays(str1);


        }
    }
}

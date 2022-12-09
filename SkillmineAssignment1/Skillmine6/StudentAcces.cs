using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class StudentAcces
    {
        private int Roll_no = 123;
        internal  string Name = "Yash";
        protected int id = 456;

        static void Main(string []args)
        {
            StudentAcces a = new StudentAcces();
            Console.WriteLine(a.Roll_no);
            Console.WriteLine(a.Name);
            
        }
    }
    class Studentinfo:StudentAcces 
    {
        static void Main(string []args)
        {
            StudentAcces b = new StudentAcces();
            Console.WriteLine(b.Name);
            Studentinfo  c = new Studentinfo ();
            Console.WriteLine(c.id);

        }
    }
}

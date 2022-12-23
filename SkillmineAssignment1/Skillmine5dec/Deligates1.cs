using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate int Mydel1(int n1,int n2);
    public delegate string Mydel2(string s);
    public class Test
    {
        public int M1(int a, int b)
       {
            return a + b;
        
        }
        public string M2(String Name)
        {
            return Name.ToUpper();
        }
    }

    class Deligates1
    {
        static void  Main(string []args)
        {
            Test t1 = new Test();
            Mydel1 d1 = new Mydel1(t1.M1);
            Mydel2 d2 = new Mydel2(t1.M2);

            int sum = d1.Invoke(25, 36);
            Console.WriteLine(sum);
            string str = d2.Invoke("ajay");
                Console.WriteLine(str);

        }
    }
}

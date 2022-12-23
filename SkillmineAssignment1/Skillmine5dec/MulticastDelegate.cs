using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate int MyDel1(int n1, int n2);
    public delegate string MyDel2(string s);
    public class Test1
    {
        public int ME1(int a, int b)
        {
            return a + b;

        }
        public int ME3(int a, int b)
        {
            return a * b;

        }
        public int ME4(int a, int b)
        {
            return a - b;

        }

        public string ME2(String Name)
        {
            return Name.ToUpper();
        }
    }

    class MulticastDelegate
    {
        static void Main(string[] args)
        {
            Test1 t1 = new Test1();
            MyDel1 d1 = new MyDel1(t1.ME1);
            d1 += new MyDel1(t1.ME3);
            d1 += new MyDel1(t1.ME4);
            Delegate[] list = d1.GetInvocationList();
            foreach (Delegate  item in list )
            {
                Console.WriteLine(item.Method );
                Console.WriteLine(item.DynamicInvoke(12,32));
            }
            MyDel2 d2 = new MyDel2(t1.ME2);

           
            string str = d2.Invoke("ajay");
            Console.WriteLine(str);

        }
    }
}

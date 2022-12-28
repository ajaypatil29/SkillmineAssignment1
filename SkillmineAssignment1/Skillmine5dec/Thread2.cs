using System;
using System.Collections.Generic;
using System.Threading;

namespace SkillmineAssignment1.Skillmine5dec
{
    public class Test6
    {
        public void M1()
        {
           
            
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            
           
        }
        public void M2()
        {
            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Thread2
    {
        static void Main(string []args)
        {
            Test6 test = new Test6();
            Thread t1 = new Thread(new ThreadStart(test.M1));
            Thread t2 = new Thread(new ThreadStart(test.M2));
            Thread t3 = new Thread(new ThreadStart(test.M1));

            t1.Start();
            t1.Join();
            t3.Start();
            

        }
       
    }
}

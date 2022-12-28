using System;
using System.Threading;

namespace SkillmineAssignment1.Skillmine5dec
{
    public class Test5
    {
        public void M1()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void M2()
        {
            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }

    class Thread5
    {
        static void Main(string []args)
        {
            Test5 test = new Test5();
            Thread t1 = new Thread(new ThreadStart(test.M1));
            Thread t2 = new Thread(new ThreadStart(test.M2));

            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            
            
        }
    }
}

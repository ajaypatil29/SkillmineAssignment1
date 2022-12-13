using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
   public  class ExtensionMethod
    {
       
        
            public void M1()
            {
                Console.WriteLine("M1");

            }
            public void M2()
            {
                Console.WriteLine("M2");
            }
        

      

    }
    public static class ExtensionClass
    {
        public static void M3(this ExtensionMethod  t1)
        {
            Console.WriteLine("M3");
        }
    }

    public class Programm1
    { 
        static void Main(string []args)
        {
            ExtensionMethod t1 = new ExtensionMethod();
            t1.M1();
            t1.M1();
            t1.M2();
            
        }
    }

}

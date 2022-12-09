using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class AccesmodifierDemo
    {
        private int x = 10;
        internal int y = 20;
        protected int z = 30;
        

       

        static void Main(string []args)
        {
            AccesmodifierDemo b = new AccesmodifierDemo();
            Console.WriteLine(b.x);
            Console.WriteLine(b.y);
            Console.WriteLine(b.z);
          

        }

    }
    class Accessinfo:AccesmodifierDemo 
    {
        static void Main(string []args)
        {
            AccesmodifierDemo c = new AccesmodifierDemo();
            Console.WriteLine(c.y);
            Accessinfo d = new Accessinfo();
            Console.WriteLine(d.z);
            
        }
        
       
    }



}

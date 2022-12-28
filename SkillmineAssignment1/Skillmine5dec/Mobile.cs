using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate string  Mydell(string str);
    public class Activity
    {
        public event Mydell Calling;
        public event Mydell messaging;
        public string  Call(string str)
        {
           return  Calling(str);
        }
        
        public string  Message(string str )
        {
           return  messaging(str );
        }
    }
    public class Results
    {
        public static void Callresult()
        {
            Console.WriteLine("poor connection");
        }
       public  static void  Mesresult()
        {
            Console.WriteLine("Not valid number");
        }
    }

    class Mobile
    {
        static void Main(string []args)
        {
            Activity a = new Activity();
            a.Calling += new Mydell(a.Call);
            a.messaging += new Mydell(a.Message );
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                
            }
           
        }
    }
}

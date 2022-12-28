using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate void Mydel();
    public class Stud
    {
        public event Mydel Pass;
        public event Mydel Fail;
        public void Accept(int marks,int b)
        {
            if(marks >=b)
            {
                Pass();

            }
            else
            {
                Fail ();
            }

        }
    }
    public class Message
    {
        public void PassMes()
        {
            Console.WriteLine("you are pass !!");
        }
        public void FailMess()
        {
            Console.WriteLine("you are Fail");
        }
    }

    class EventDelegate
    {
        static void Main(string []args)
        {
            Stud s1 = new Stud();
            Message m = new Message();
            s1.Pass += new Mydel(m.PassMes);
            s1.Fail += new Mydel(m.FailMess);
            Console.WriteLine("enter your marks");
            int marks = int.Parse(Console.ReadLine());
           /* s1.Accept(marks);*/
            
        }
    }
}

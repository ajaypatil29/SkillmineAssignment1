using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
   public class Throw:Exception 
    {
        public Throw (string message ):base (message)
        {

        }
    }
    public class Even
    {
        int num;

        public void AcceptNum(int num)
        {
            if(num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                throw new Exception("not even num ,try again");
            }
        }
    }
    public class Numbers
    {
        static void Main(string []args)
        {
            Even A = new Even();
            try
            {
                A.AcceptNum(4);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }
        

    }




}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
   public  class MarksException:Exception 
    {
        public MarksException(string message):base(message)
        {
           
        }
       
       

    }
    public class stud
    {
        string Name;

        public void AcceptMarks(string Name)
        {

           
            if (string.IsNullOrEmpty(Name ))
            {
                throw new MarksException("Name is required");
            }
            else
            {
                this.Name = Name;

            }
            Console.WriteLine(Name);
        }
    }   
    public class Marks
    {
        static void Main(string[] args)
        {
            stud s = new stud();
            try
            {
                s.AcceptMarks("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }
    }
}

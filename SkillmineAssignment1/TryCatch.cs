using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1
{
    class TryCatch
    {
        

      
        static void  Main(String []args)
        {
            try
            {
                int a = 4, b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int[] arr = new int[5];
                arr[6] = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
            finally
            {
                Console.WriteLine("end of the process");
            }
             
           
        }
       

    }
}

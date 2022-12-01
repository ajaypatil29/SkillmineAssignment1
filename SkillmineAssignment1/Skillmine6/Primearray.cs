using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Primearray
    {  public void Prime1(int []a)
        {
            
            for (int i = 0; i <a.Length; i++)
            {
                
                if (a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        
        
        
        static void Main(string []args)
        {

            int[] myarr = { 1, 4, 5, 8, 9 };
            
            Primearray c = new Primearray();
            c.Prime1(myarr);
            
           
        }  
    }
}

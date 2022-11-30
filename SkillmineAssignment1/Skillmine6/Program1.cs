using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Method
{
    class Program1
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            if (num1>num2 )
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
        static void Main(string []args)
        {
            Program1 max = new Program1();
            Console.WriteLine(max.FindMax(10, 20));
            

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class RevrsePalindrome
    {
        public void Check(int []a)
        {
            bool flag = false;
            for (int i = 0, j = a.Length - 1; i < a.Length / 2; i++)
            {
                if(a[i]==a[j])
                {
                    flag = true;
                    
                }
                
            }
            if (flag == true )
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
        static void Main(string []args)
        {
            int num = 7325;
            int temp = num;
            int r = 0;
            int result=0;
            int add = 0;
            while (num>0)
            {
                r = r * 10;
                r = r + num % 10;
                result = r;
                num = num / 10;
            }
            Console.WriteLine(result );

            add = temp + result;
            int[] arr = new int[add];
            Console.WriteLine(add );
            RevrsePalindrome b = new RevrsePalindrome();
            b.Check(arr);
            
        }
        
    }
}

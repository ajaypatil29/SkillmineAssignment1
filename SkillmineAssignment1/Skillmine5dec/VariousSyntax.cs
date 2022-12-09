using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    class VariousSyntax
    {
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void cal(int a,int b,out int sum,out int sub,out int Multi)
        {
            sum = a + b;
            sub = a - b;
            Multi = a * b;
        }
        static void AcceptNames(params string []Names)
        {
            Console.WriteLine("values to print ="+Names.Length );
            for (int i = 0; i <Names.Length ; i++)
            {
                Console.WriteLine(Names[i]);
            }
        }
        static void AcceptNum(params int []num )
        {
            Console.WriteLine("values to print =" + num .Length);
            for (int i = 0; i < num .Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        static void Cal()
        {
            var z = 10 + 50;
        }


        
        static void  Main(string []aargs)
        {
            int a = 10;int b = 20,sum,sub,Multi;
            Console.WriteLine($"before call swap a={a},b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"after call swap a={a},b={b}");
            cal(a, b, out sum, out sub, out Multi);
            Console.WriteLine(sum);
            Console.WriteLine(sub );
            Console.WriteLine(Multi);
            AcceptNames("ajay ");
            AcceptNames("ajay", "jay");
            AcceptNames(" raj", "jay", "ajay");
            AcceptNum(1, 2);
            AcceptNum(1, 5, 8, 6);
           
           


        }


    }
}

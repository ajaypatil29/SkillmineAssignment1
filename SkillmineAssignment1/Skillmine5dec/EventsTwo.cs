using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate int mydel(int n1, int n2);
    public class Operations
    {
        public int Add(int a,int b)
        {
            return a + b;

        }
        public int Sub(int a, int b)
        {
            return a - b;

        }
        public int Multi(int a,int b)
        {
            return a * b;
        }
    }
    public class Helper
    {
        public event mydel Addition;
        public event mydel Substraction;
        public event mydel Multiplication;
        public int A1(int a,int b)
        {
            return Addition(a, b);
        }
        public int A2(int a, int b)
        {
            return Substraction (a, b);
        }
        public int A3(int a, int b)
        {
            return Multiplication (a, b);
        }
    }

    class EventsTwo
    {
        static void Main(string []args)
        {
            Operations op = new Operations();
            Helper h = new Helper();
            h.Addition += new mydel(op.Add);
            h.Substraction  += new mydel(op.Sub);
            h.Multiplication  += new mydel(op.Multi);

            Console.WriteLine("enter two number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            int opn = int.Parse(Console.ReadLine());

            switch (opn)
            {
                case 1:int sum = h.A1(a, b);
                    Console.WriteLine("Addition="+sum);
                    break;
                case 2:
                    int sub = h.A2(a, b);
                    Console.WriteLine("Substraction="+sub);
                    break;
                case 3:
                    int mul = h.A1(a, b);
                    Console.WriteLine("Mulltiplication="+mul);
                    break;
                default: Console.WriteLine("no output");
                    break;
            }


        }
    }
}
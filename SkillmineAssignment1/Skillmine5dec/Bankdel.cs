using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public delegate void Trdel();
    public class bank
    {
        public event Trdel insuficient;
        public event Trdel zero;


        public double Balance;
        public bank(double Balance)
        {
            this.Balance = Balance;
        }
        public double Credit(double a)
        {
            double b = this.Balance + a;
            return b;

        }
        public double Debit(double a)
        {
            if (this.Balance < a)
            {

                insuficient();




            }
            else
            {
                double b = this.Balance - a;
                if (b == 0)
                {
                    zero();
                }
                return b;


            }
            return this.Balance;
        }
       

    }
    public static class Massegs
    {
        public static void Lessbalance()
        {
            Console.WriteLine("inssuficient Balance");

        }

        public static void Zerobalance()
        {
            Console.WriteLine("zero Balance");
        }

    }
    public class Bankdel
    {
        static void Main(string[] args)
        {

            bank x = new bank(7000);
            x.insuficient += new Trdel(Massegs.Lessbalance);
            x.zero += new Trdel(Massegs.Zerobalance);
            Console.WriteLine("Select Transactions option from bellow ");
            Console.WriteLine("1.Credit\n2.Debit");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("enter amount");
            int c = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("account balance=" + x.Credit(c));

                    break;
                case 2:
                    Console.WriteLine("account balance=" + x.Debit(c));
                    x.Debit(c);
                    break;
                default:
                    Console.WriteLine(" Wrong entry !!! transaction canceled");
                    break;
            }


        }

    }


}
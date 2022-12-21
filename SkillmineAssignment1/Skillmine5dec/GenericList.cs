using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class Product
    {
        private string name1;
        private int id1;
        private double price1;


        public string Name1 { get => name1; set => name1 = value; }
        public int Id1 { get => id1; set => id1 = value; }
        public double Price1 { get => price1; set => price1 = value; }

        public override string ToString()
        {
            return $"{Id1}--{Name1}--{Price1 }";
        }

    }
    public class Book
    {
        public static void Main(string[] args)
        {
            List<Product> l = new List<Product>()
           {
               new Product{Id1=1,Name1="watch",Price1=2500},
               new Product{Id1=2,Name1="mobile",Price1=5000},
               new Product{Id1=3,Name1="laptop",Price1=7500},

           };

            foreach (Product a in l)
            {
                if (a.Price1 > 3000)
                    Console.WriteLine($"{a.Id1 }--{a.Name1 }--{a.Price1 }");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
  public enum Productss { Furniture,Mobiles}
    public class prod
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Productss Productss;
    }


    class ProductGen
    {
        static void  Main(string []args)
        {
            List<prod> List3 = new List<prod>()
            {
                new prod {Productss=Productss.Furniture ,Name ="Table",Price =1234},
                 new prod {Productss=Productss.Furniture ,Name ="Chair",Price =534},
                  new prod {Productss=Productss.Furniture ,Name ="Sofa",Price =4234},
                   new prod {Productss=Productss.Furniture ,Name ="Study table",Price =2234},
                   new prod {Productss =Productss.Mobiles ,Name ="Samsung",Price =7894},
                    new prod {Productss =Productss.Mobiles ,Name ="Iphone",Price =7894},
                     new prod {Productss =Productss.Mobiles ,Name ="Oppo",Price =7894}
            };
            foreach (prod  c in List3 )
            {
                Console.WriteLine($"Product Type={c.Productss },\tName of Product={c.Name },\tPrice of Product={c.Price }");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            foreach (prod  d in List3 )
            {
                if(d.Productss ==Productss.Furniture)
                {
                    Console.WriteLine($"Product Type={d.Productss },\tName of Product={d.Name },\tPrice of Product={d.Price }");
                }

            }
                        
        }
    }
}

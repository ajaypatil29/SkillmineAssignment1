using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public enum Catagery { Drama,Comedy, suspens }
    public class Author
    {
        public string NameAuthour { get; set; }
       
        public Catagery Catagery;
        public List<books> list2 = new List<books>();
    }
    public class books
    {
        public int price { get; set; }
        public string  Name { get; set; }
        
    }


    class BookGen
    {
        static void Main(string []args)
        {
            List<Author> List1 = new List<Author>()
            {
                new Author {Catagery =Catagery.Drama ,NameAuthour ="abc", list2={ new books { Name="ABC",price =123} } },
                new Author {Catagery =Catagery.Drama ,NameAuthour ="abc", list2={ new books { Name="ABCD",price =1234} } },
                new Author {Catagery =Catagery.Comedy  ,NameAuthour ="pqr", list2={ new books { Name="PQR",price =234} } },
                new Author {Catagery =Catagery.Comedy ,NameAuthour ="pqr", list2={ new books { Name="PQRS",price =2345} } },
                 new Author {Catagery =Catagery.suspens   ,NameAuthour ="xyz", list2={ new books { Name="XYZ",price =534} } },
                new Author {Catagery =Catagery.suspens  ,NameAuthour ="xyz", list2={ new books { Name="XYZA",price =4545} } },

            };
            foreach (Author  c in List1)
            {
                Console.WriteLine($"Catagery={c.Catagery}," +
                    $"\tName Of Author={c.NameAuthour }");

                foreach (books   d in c.list2 )
                {
                    Console.WriteLine($"\tBook Name={d.Name },Price={d.price }");
                }
               
            }
            Console.WriteLine("___________________________________________________________________________________");
            foreach (Author  e in List1 )
            {
                if(e.Catagery ==Catagery.Comedy )
                {
                    Console.WriteLine($"Catagery={e.Catagery}," +
                    $"\tName Of Author={e.NameAuthour }");

                    foreach (books d in e.list2)
                    {
                        Console.WriteLine($"\tBook Name={d.Name },Price={d.price }");
                    }
                }
            }

        }
    }
}

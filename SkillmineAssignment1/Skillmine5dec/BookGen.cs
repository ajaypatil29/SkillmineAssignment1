using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public enum Catagery { Drama,Comedy, suspens }
    public class Author
    {
        public string NameAuthour { get; set; }
       
        
        
    }
    public class books
    {
        public int price { get; set; }
        public string  Name { get; set; }
        public Catagery Catagery;
        public List<Author> list3 = new List<Author>();
    }


    class BookGen
    {
        static void Main(string []args)
        {
            List<books >list4=new List<books> ()          
            {
                new books  {Catagery =Catagery.Drama ,  Name="ABC",price =123,list3={ new Author { NameAuthour ="abc"} } } ,
                new books  {Catagery =Catagery.Drama ,  Name="ABCD",price =153,list3={ new Author { NameAuthour ="abc"} } } ,
                new books  {Catagery =Catagery.Comedy  ,  Name="PQR",price =145,list3={ new Author { NameAuthour ="abc"} } } ,
                new books  {Catagery =Catagery.Comedy  ,  Name="PQRS",price =453,list3={ new Author { NameAuthour ="pqr"} } } ,
                new books  {Catagery =Catagery.suspens  ,  Name="XYZ",price =253,list3={ new Author { NameAuthour ="pqr"} } } ,
                new books  {Catagery =Catagery.suspens  ,  Name="XYZa",price =223,list3={ new Author { NameAuthour ="pqr"} } } ,



            };
            foreach (books   c in list4 )
            {
                Console.WriteLine($"Catagery={c.Catagery }," +
                    $"\tName Of book={c.Name  }," +
                    $"Price={c.price }");

                foreach (Author    d in c.list3 )
                {
                    Console.WriteLine($"\tAuthor Name={d.NameAuthour}");
                }
               
            }
            Console.WriteLine("___________________________________________________________________________________");
            foreach (books   e in list4 )
            {
                if(e.Catagery ==Catagery.Comedy )
                {
                    Console.WriteLine($"Catagery={e.Catagery}," +
                    $"\tName Of Author={e.Name }," +
                    $"Price={e.price }");

                    foreach (Author  d in e.list3)
                    {
                        Console.WriteLine($"\tAuthor Name={d.NameAuthour}");
                    }
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class GenericMethod
    {
        int id;
        int name;
        int price;
        public GenericMethod(int id,int name,int price)
        {
            
        }
        static void  Main(string []args)
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            foreach (var item in list1 )
            {
                Console.WriteLine(item );
            }
            Console.WriteLine("---------------------------------");
            List<string> list2 = new List<string>();
            list2.Add("ajay");
            list2.Add("patil");
            foreach (var item in list2 )
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            /*List<Product> list3 = new List<Product>();
            list3.Add(new Product { name = "XYZ", Price = "123" });*/
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            foreach (var item in stack1 )
            {
                Console.WriteLine(item );
            }
            Console.WriteLine("-----------------");
            Queue<string> q = new Queue<string>();
            q.Enqueue("ABC");
            q.Enqueue("pqr");
            q.Enqueue("xyz");
            foreach (var item in q)
            {
                Console.WriteLine(  item);
            }
            Console.WriteLine("-----------------");
            SortedDictionary<int, double> s1 = new SortedDictionary<int, double>();
            s1.Add(1, 22.2);
            s1.Add(12, 56.25);
            foreach (KeyValuePair<int,double > item in s1 )
            {
                Console.WriteLine(item.Key+"  "+item.Value  );
            }



        }
        
    }

    public class Mygeneric<T>
    {
        private T data;
        public void Add(T data)
        {
            this.data = data;

        }
        public T print()
        {
            return data;

        }
    }
    public class Programm
    {
        static void Main(string[] args)
        {
            Mygeneric<int> obj = new Mygeneric<int>();
            obj.Add(10);
            Console.WriteLine(obj.print());

            Mygeneric<string> ob2 = new Mygeneric<string>();
            ob2.Add("String");
            Console.WriteLine(ob2.print());
        }
    }


}

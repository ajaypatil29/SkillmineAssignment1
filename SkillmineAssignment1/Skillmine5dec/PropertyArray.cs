using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public class PropertyArray
    {
        
        

            private int id;
            private string Name;
            private int salary;

            public int Id { get => id; set => id = value; }
            public string Name1 { get => Name; set => Name = value; }
            public int Salary { get => salary; set => salary = value; }

       /* public override string ToString()
        {
            return $"{Id }---{Name1 }---{salary }";
        }*/


        static void Main(string[] args)
        {
            PropertyArray[] product = new PropertyArray[]
                {
                new PropertyArray {Id=101,Name1 ="AJAY",Salary =12345},
                new PropertyArray {Id=102,Name1 ="JAY",Salary =123454},
                 new PropertyArray {Id=103,Name1 ="RAJ",Salary =22345},
                };
            foreach (var item in product)
            {
                Console.WriteLine($"{item.Id }----{item.Name1 }---{item.salary }");
            }

        }
    }
   

}

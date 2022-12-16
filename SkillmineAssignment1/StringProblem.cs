using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1
{
    class StringProblem
    {
        public void Max(int[]a)
        {
            int max = 0;
            for (int i = 0; i <a.Length  ; i++)
            {
                for (int j = 0; j <a.Length ; j++)
                {
                    if(a[i]>max )
                    {
                        max = a[i];
                       
                    }
                   

                }
                


            }
            Console.WriteLine(" Max=" + max);
        }
        static void Main(string []args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            StringProblem b = new StringProblem();
            b.Max(arr);

        }
    }

    public class Employee
    {
        private  int id;
        private string  name;
        private int salary;
        static int count;
        
        public int ID { get; set; }
        public string  Name { get; set; }
        public int Salary { get; set; }
        public static int Count { get => count; set => count = value; }

        public override string ToString()
        {
            return $"Id--{id},Name--{name  },Salary--{salary }";
        }
        static void Main(string []args)
        {
            Count++;
            Employee [] a = new Employee[] { 
            new Employee {ID=Count ,Name ="xyz",Salary =12345 },
            new Employee {ID=Count ,Name ="abc",Salary =125345 }
            };

            foreach (var item in a)
            {
                Console.WriteLine($"{item.ID },{item.Name },{item.Salary }");
            }


            
        }
    }

}

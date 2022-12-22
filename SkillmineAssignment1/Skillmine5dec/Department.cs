using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public enum Departments { HR, Production, testing }

    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Departments Departments;

    }



    class Department
    {
        static void Main(string[] args)
        {
            List<employee> list1 = new List<employee>()
            {
                new employee { Departments = Departments.HR, Id = 1, Name = "Ajay", Salary = 12345 },
                new employee { Departments = Departments.testing, Id = 2, Name = "jay", Salary = 52345 },
                new employee { Departments = Departments.Production, Id = 3, Name = "Raj", Salary = 123545 },
                new employee { Departments = Departments.HR, Id = 1, Name = "Abc", Salary = 12345 },
                new employee { Departments = Departments.testing, Id = 2, Name = "pqr", Salary = 52345 },
                new employee { Departments = Departments.Production, Id = 3, Name = "xyz", Salary = 123545 },

            };
            foreach (employee  c in list1)
            {
                
                
                
                    Console.WriteLine($"\tDept={c.Departments},Id={c.Id },Name={c.Name },Salary={c.Salary }");
                
                
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (employee c in list1)
            {

                if (c.Departments == Departments.HR)
                {
                    Console.WriteLine($"\tDept={c.Departments},Id={c.Id },Name={c.Name },Salary={c.Salary }");
                }

            }
        }
    }
}

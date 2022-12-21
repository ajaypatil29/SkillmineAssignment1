using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    class check : IComparer
    {
        
        public int Compare(object x, object y)
        {
            EmployeeC e1 = (EmployeeC)x;
            EmployeeC e2 = (EmployeeC)y;
            if(e1.Salary >e2.Salary )
            {
                return 1;

            }
            else if(e1.Salary<e2.Salary )
            {
                return -1;

            }
            else
            {
                return 0;
            }
            
            
        }

    }

    class EmployeeC :IComparable
    {
        private string name;
        private int salary;
        public EmployeeC(string name,int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        public int CompareTo(object obj)
        {
            EmployeeC e3 = (EmployeeC )obj;
            if(this.Salary>e3.Salary )
            {
                return 1;

            }
            else if(this.Salary<e3.Salary )
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Name}---{Salary }";
        }
    }
    public class Team:IEnumerable 
    {
        private EmployeeC[] employee;
        public Team ()
        {
            employee = new EmployeeC[3];
            employee[0] = new EmployeeC("xyz", 15000);
            employee[1] = new EmployeeC("abc", 20000);
            employee[2] = new EmployeeC("pqr", 25000);
        }

        public IEnumerator GetEnumerator()
        {
            return employee.GetEnumerator();
        }
    }
    public class program
    { 
        static void  Main(string []args)
        {
            Team team = new Team();
            foreach (EmployeeC  E in team )
            {
                Console.WriteLine(E);
            }

            EmployeeC    employee1 = new EmployeeC("xyz", 15000);
            EmployeeC employee2 = new EmployeeC("abc", 20000);
            EmployeeC employee3 = new EmployeeC("pqr", 25000);
            int result = employee1.CompareTo(employee3);
            if(result==1)
            {
                Console.WriteLine("employee1 has more salary than employee3");
            }
            else if(result ==-1)
            {
                Console.WriteLine("employee1 has less salary than employee3");
            }
            else
            {
                Console.WriteLine("employee1 has same salary as employee3");
            }
            
            if (result == 1)
            {
                Console.WriteLine("employee1 has more salary than employee3");
            }
            else if (result == -1)
            {
                Console.WriteLine("employee1 has less salary than employee3");
            }
            else
            {
                Console.WriteLine("employee1 has same salary as employee3");
            }
        
        }

    }



}

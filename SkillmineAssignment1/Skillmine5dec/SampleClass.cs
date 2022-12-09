using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    public class Employee
    {
        protected  int empid;
        protected string empname;
        protected double basic, hra, da, pf, gross;
        protected  static int count ;
        public Employee(string empname,double basic)
        {
            count++;
            empid = count;
            
            this.empname = empname;
            this.basic = basic;
        }
        public virtual void calculatesalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        public override string ToString()
        {
            return $"Employee ID{empid },Employee Name={empname},Gross salary of Employee={gross}";
        }
        public double Getgrosssalary()
        {
            return gross;
        }
    }

   public class SalesManager:Employee
    {
        protected  int Bonus;
        public SalesManager(string empname, double basic,int Bonus) :base(empname,basic)
        {
            this.Bonus = Bonus;
        }
        public override void calculatesalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da+Bonus ) - pf;
        }
        public override string ToString()
        {
            return $"Employee ID={empid },Employee Name={empname},Gross salary of SalesManager={gross}rs";
        }
        public double Getgrosssalary()
        {
            return gross;
        }
    }

    public class Manager : SalesManager
    {
        public int food;
        public Manager(string empname,int basic,int Bonus,int food):base(empname,basic,Bonus )
        {
            this.food = food;
        }
        public override void calculatesalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + Bonus+food) - pf;
        }
        public override string ToString()
        {
            return $"Employee ID={empid },Employee Name={empname},Gross salary of Manager={gross}rs";
        }
        public double Getgrosssalary()
        {
            return gross;
        }

    }

    //when we dont have acces of base class that time we can use New key word to reappet the process
   /* public new void calculatesalary()
    {
        hra = basic * 0.40;
        da = basic * 0.20;
        pf = basic * 0.12;
        gross = (basic + hra + da + Bonus + food) - pf;
    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    public class Student
    {
        protected string Name;
        protected  int Roll_no;
        protected  int Physics;
        protected  int Chem;
        protected int Maths;
        protected  int Total;
        protected  Double Per;
        private static int count=150;
        private const int X= 500;
        private readonly int Y;

        public Student(string Name, int Physics, int Chem, int Maths)
        {
            count++;
            Roll_no = count;
            this.Name = Name;
            this.Physics = Physics;
            this.Chem = Chem;
            this.Maths = Maths;
           
            


        }
        public static int GetCount()
        {
            return count;
        }

        public virtual  void Calculate()
        {
            Total = Physics + Chem + Maths;
            Per = (Total * 100) / 300;

        }
        public override string ToString()
        {
            return $"Roll no={Roll_no },Name Of student={Name },Total Marks Obtained={Total},Total Percentage Obtained={Per},x={X },Y={Y}";
        }
        public double GetPercentage()
        {
            return Per;
        }



    }
    public class Engineer : Student
    {
        private int CET;
        public Engineer(string Name,int Physics,int Chem,int Maths,int CET):base(Name,Physics,Chem,Maths )
        {
            this.CET = CET;
        }
        public override  void Calculate()
        {
            Total = Physics + Chem + Maths;
            Per = (Total * 100) / 300.00;

        }
        public override string ToString()
        {
            return $"Roll no={Roll_no },Name Of student={Name },Total Marks Obtained={Total},Total Percentage Obtained={Per},CET ={CET}";
        }
        public double GetPercentage()
        {
            return Per;
        }
    }

}

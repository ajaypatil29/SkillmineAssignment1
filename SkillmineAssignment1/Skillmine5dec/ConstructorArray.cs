using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5dec
{
    public enum Standard { first,second,third}
    class ConstructorArray
    {
       
        private int rollno;
        private string name;
        private int marks;
        private Standard stand;

        public ConstructorArray(int rollno,string name,int marks, Standard stand  )
        {
            this.rollno = rollno;
            this.name = name;
            this.marks = marks;
            this.stand = stand;
                       
        }
        public override string ToString()
        {
            return $"{rollno }--{name }--{marks}--{stand }";

        }

        static void Main(string []args)
        {
            ConstructorArray[] product = new ConstructorArray[]
            {
                new ConstructorArray (111,"XYZ",75,Standard.first ),
                new ConstructorArray (112,"XY45Z",76,Standard.second )
                ,new ConstructorArray (113,"1XYZ",77,Standard.third )

        };
            foreach (var item in product )
            {
                Console.WriteLine(item );
            }
        }
    }
    
}

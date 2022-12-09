using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Studentacces1
    {
        int id;
        string Name;
        int maths;
        int English;
        int Sci;
        double Per;
        public int Id
        {
            set
            {
                id = value;

            }
            get
            {
                return id;
            }

        }
        public string Name1
        {
            set
            {
                Name = value;

            }
            get
            {
                return Name;
            }
        }
        public int Maths2
        {
            set
            {
                maths = value;

            }
            get
            {
                return maths;
            }
        }
        public int Eng
        {
            set
            {
                English = value;

            }
            get
            {
                return English;
            }
        }
        public int Science
        {
            set
            {
                Sci = value;

            }
            get
            {
                return Sci;
            }
        }
        public void Show()
        {
            Console.WriteLine("Percentage="+Per);
        }
        public void Calculate()
        {
            Per = ((Maths2 + English + Science) * 100) / 300.0;
            Show();
        }




    }
    class StudentInfo
    {

        static void Main(string[] args)
        {
            Studentacces1 a = new Studentacces1();
            a.Id = 123;
            a.Name1 = "Jay";
            a.Maths2 = 75;
            a.Eng = 88;
            a.Science = 75;           
            Console.WriteLine(" Student ID="+a.Id + "Student Name " + a.Name1 + " Maths=" + a.Maths2 + " English=" + a.Eng + " Science=" + a.Science + " ");
            a.Calculate();
        }

    }
}
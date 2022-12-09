using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine6
{
    class Thisuse
    {
        int x;
        int result;
        public Thisuse(int x)
        {
            this.x = x;
            
        }
        public void Show()
        {
            Console.WriteLine(result );
        }
        public void Calculatecube()
        {
            result = x * x * x;
            this.Show();
        }
        static void Main(string []args)
        {
            Thisuse t = new Thisuse(45);
            t.Show();
            
        }
    }
}

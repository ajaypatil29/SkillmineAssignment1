using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    abstract public class Shape
    {
        public abstract void Calculation();
    }
    public class circle : Shape
    {
        private int r;
        double area;
        public circle(int r)
        {
            this.r = r;
        }

        public override void Calculation()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"Area={area }";
        }
    }
    public class Rectangle : Shape
    {
        private int L;
        private int W;
        private int Area;
        public Rectangle(int L, int W)
        {
            
            this.L = L;
            this.W = W;
        }

        public override void Calculation()
        {
            Area = L * W;
        }
        public override string ToString()
        {
            return $"Area={Area }";
        }
    }
    public class Triangle : Shape
    {
        private int L;
        private int B;
        private double Area;
        public Triangle(int L, int B)
        {
            
            this.L = L;
            this.B = B;
        }

        public override void Calculation()
        {
            Area = 0.5 * L * B;
        }
        public override string ToString()
        {
            return $"Area={Area }";
        }
    }
}

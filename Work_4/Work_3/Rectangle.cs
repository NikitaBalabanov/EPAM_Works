using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3
{
    class Rectangle
    {
        private double a;
        private double b;
        private double c;

        public double GetLength()
        {
            return a+b+c;
        }
        public double GetArea()
        {
            double p = (a + b + c) / 2;
            double A = Math.Sqrt(p * (p - a)*(p - b)*(p - c));
            return A;
        }

        public Rectangle(double a, double b, double c) 
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
    }
}

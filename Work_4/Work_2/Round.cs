using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    class Round
    {
        public double X;
        public double Y;
        private double r;

        public double GetLength()
        {
            return 2 * Math.PI * r;
        }
        public double GetArea()
        {
            return Math.PI * r * r;
        }

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value >= 0)
                {
                    r = value;
                }
                else
                {
                    ///hhhh
                }
            }
        }
    }
}

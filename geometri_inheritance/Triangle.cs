using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri_inheritance
{
    class Triangle : Figure
    {
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public override double GetArea()
        {
            return 0.5 * SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}

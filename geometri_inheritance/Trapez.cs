using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri_inheritance
{
    class Trapez : Square
    {
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        private double sideD;

        public double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }
        private double height;
        /// <summary>
        /// The length of the height
        /// </summary>
        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public Trapez() { }

        public override double GetArea()
        {
            return 0.5 * (SideA + SideC) * GetHeight();
        }

        private double GetHeight()
        {
            double s = (SideA + SideB - SideC + SideD) / 2;
            Height = (2 / (SideA - SideC)) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            return Height;
        }

        public override double GetPerimeter()
        {
            return 0;
        }
    }
}

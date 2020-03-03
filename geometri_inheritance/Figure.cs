using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri_inheritance
{
    class Figure
    {
        private double sideA;
        /// <summary>
        /// The length of side A
        /// </summary>
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        private double sideB;
        /// <summary>
        /// The length of side B
        /// </summary>
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        private double angle;
        /// <summary>
        /// The angle of the figure
        /// </summary>
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        private string name;
        /// <summary>
        /// The name of the figure
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Figure() { }
        /// <summary>
        /// Calculates the area of the given figure
        /// </summary>
        /// <returns></returns>
        public virtual double GetArea()
        {
            return SideA * SideA;
        }

        /// <summary>
        /// Calculates the perimeter of the given figure
        /// </summary>
        /// <returns></returns>
        public virtual double GetPerimeter()
        {
            return 4 * SideA;
        }
    }
}

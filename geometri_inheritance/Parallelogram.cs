using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri_inheritance
{
    class Parallelogram : Square
    {
        public Parallelogram() { }

        public override double GetArea()
        {
            return SideA * SideB * Math.Sin((Angle * (Math.PI) / 180));
        }

        public override double GetPerimeter()
        {
            return 0;
        }
    }
}

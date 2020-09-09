using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle : Shape
    {
         
        public Triangle(double w, double h) : base(w, h)
        {

        }


        public double Areacalc()
        {
            double area = (width * height)/ 2;

            return area;
        }

        public double            TriangelOmkrets()
        {
            double PowHypotenusa = (width * width) + (height * height);
            double Hypotenusa = Math.Sqrt(PowHypotenusa);
            double Omkrets = width + height + Hypotenusa;
            return Omkrets;
        }

    }
}

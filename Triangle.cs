using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle : IShape
    {
        double width, height;   
        public Triangle(double w, double h) 
        {
            height = h;
            width = w;
        }


        public double Area()
        {
            double area = (width * height)/ 2;

            return area;
        }

        public  double  Omkrets()
        {
            double PowHypotenusa = (width * width) + (height * height);
            double Hypotenusa = Math.Sqrt(PowHypotenusa);
            double Omkrets = width + height + Hypotenusa;
            return Omkrets;
        }

    }
}

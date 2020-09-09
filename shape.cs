using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Shape
    {
        protected double width;
        protected double height;

        public Shape(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }

        }
        public double Height
        {
            get { return height; }
            set { width = value; }
        }

        public double TriangelOmkrets()
        {
            double PowHypotenusa = (width * width) + (height * height);
            double Hypotenusa = Math.Sqrt(PowHypotenusa);
            double Omkrets = width + height + Hypotenusa;
            return Omkrets;






        }
}

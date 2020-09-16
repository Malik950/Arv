using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangle : IShape
    {
        double width, height;
        public Rectangle(double w, double h) 
        {
            height = h;
            width = w;
        } 

        
        public double Area()
        {
            double area = width * height;

            return area;
        }

        public double Omkrets()
        {
            double Omkrets = width + width + height + height;
            return Omkrets;
        }
    }

    
}

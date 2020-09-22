using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Circle : IShape
    {
        double radie;

        public Circle(double r)
        {
            radie = r;
        }

        public double Area()
        {
            double area = Math.PI * radie * radie;

            return area;
            
        }

        public double Omkrets()
        {
           double omkrets = Math.PI * (radie*2);

            return omkrets;

        }

        
       

            
    }
}

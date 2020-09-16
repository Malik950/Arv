using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Circle : IShape
    {
        double width, height;
        public Circle(double w, double h) 
        {
            width = w;
            height = h;
        }

    }
}

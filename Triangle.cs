using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle : Shape
    {
         
        public Triangle(int w, int h) : base(w, h)
        {

        }


        public int Areacalc()
        {
            int area = width * height;

            return area;
        }
    }
}

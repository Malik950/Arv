using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Shape
    {
        protected int width;
        protected int height;

        public Shape(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }

        }
        public int Height
        {
            get { return height; }
            set { width = value; }
        }


    }
}

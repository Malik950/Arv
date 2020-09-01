using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class shape
    {
        protected int width;
        protected int height;

        public shape(int w, int h)
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
            get { return width; }
            set { width = value; }
        }


    }
}

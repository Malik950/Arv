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
            get;
            set;

        }
        public double Height
        {
            get;
            set;
        }

        public virtual void Area()
        {
            return  0;
        }

        public virtual void Circumference()
        {
            return  0;
        }
        
    }

 }

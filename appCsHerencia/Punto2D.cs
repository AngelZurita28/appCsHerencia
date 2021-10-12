using System;
using System.Collections.Generic;
using System.Text;

namespace appHerencia
{
    class Punto2D : Punto
    {
        protected double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Punto2D() : base()
        {
            y = 0;
        }
        public Punto2D(double x, double y) : base(x)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return base.ToString() + " Y=" + y;
        }
    }
}
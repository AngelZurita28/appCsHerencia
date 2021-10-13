using System;
using System.Collections.Generic;
using System.Text;

namespace appHerencia
{
    class Punto3D : Punto2D
    {
        protected double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
        public double Distancia(Punto3D p)
        {
            double d = 0;
            double dx = x - p.x;
            double dy = y - p.y;
            double dz = z - p.z;
            double cdx = Math.Pow(dx, 2);
            double cdy = Math.Pow(dy, 2);
            double cdz = Math.Pow(dz, 2);
            d = Math.Sqrt(cdx + cdy + cdz);

            return d;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace appHerencia
{
    class Punto3D : Punto2D
    {
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        private double distance;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
            distance = Math.Sqrt(Math.Pow(x - y, 2));
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z + "\nDistancia de X a Y= " + distance;
        }
    }
}
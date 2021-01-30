using System;

namespace InterfaceSegregation
{
    class Sphere : Shape3DInterface
    {
        public double Radius { get; set; }

        public Sphere(double r)
        {
            this.Radius = r;
        }

        public double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }
        

        public double Volume()
        {
            return Math.PI * Math.Pow(Radius, 3) * (4.0 / 3.0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Sphere : IShape3D, ManageInterfaces
    {
        private double radius;

        public Sphere(double r)
        {
            this.radius = r;
        }

        public double Calculate()
        {
            return this.Volume();
        }

        public double Volume()
        {
            return Math.PI * Math.Pow(radius, 3) * (4.0 / 3.0);
        }
    }
}

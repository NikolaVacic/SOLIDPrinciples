using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Cube : IShape3D, ManageInterfaces
    {
        private double a;

        public Cube(double a)
        {
            this.a = a;
        }

        public double Calculate()
        {
            return this.Volume();
        }

        public double getA()
        {
            return this.a;
        }

        public double Volume()
        {
            return a * a * a;
        }
    }
}

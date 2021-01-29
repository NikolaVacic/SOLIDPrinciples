using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitute
{

    // Circle nasledjuje Shape da bih mogao da kreiram niz objekata tipa Shape u koji cu smestati i Circle-e i Square-ove

    class Circle : IShape
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double getR() { return radius; }

        public override double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double volume()
        {
            return Math.PI * 2 * radius;
        }

    }
}

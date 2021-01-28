using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblity
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
    }
}

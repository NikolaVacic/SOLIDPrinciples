using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitute
{
    
    // Square nasledjuje Shape da bih mogao da kreiram niz objekata tipa Shape u koji cu smestati i Circle-e i Square-ove

    class Square : IShape
    {
        private double a;

        public Square(double side)
        {
            this.a = side;
        }

        public double getA() { return a; }

        public override double area()
        {
            return a * a;
        }

        public override double volume() {
            return 4 * a;
        }
    }
}

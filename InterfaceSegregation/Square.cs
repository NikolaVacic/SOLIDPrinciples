using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    
    // Square implementira IShape da bih mogao da kreiram niz objekata tipa IShape u koji cu smestati 
    // i Circle-e i Square-ove

    class Square : IShape, ManageInterfaces
    {
        private double a;

        public Square(double side)
        {
            this.a = side;
        }

        public double getA() { return a; }

        public double area()
        {
            return a * a;
        }

        public double Perimeter() {
            return 4 * a;
        }

        public double Calculate()
        {
            return this.area();
        }
    }
}

﻿
//! Circle nasledjuje IShape da bi mogli kreirati listu objekata tipa IShape u koje cemo smestati i krugove i kvadrate

namespace LiskovSubstitute
{
    class Circle : IShape, Shape2DInterface
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            this.Radius = r;
        }

        public double Area()
        {
            return System.Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return System.Math.PI * 2 * Radius;
        }
    }
}

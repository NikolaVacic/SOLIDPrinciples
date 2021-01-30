
//! Square nasledjuje IShape da bi mogli kreirati listu objekata tipa IShape u koje cemo smestati i krugove i kvadrate

namespace OpenClosed
{
    class Square : IShape, Shape2DInterface
    {
        public double A { get; set; }

        public Square(double side)
        {
            this.A = side;
        }

        public double Area()
        {
            return A * A;
        }

        public double Perimeter()
        {
            return 4 * A;
        }
    }
}

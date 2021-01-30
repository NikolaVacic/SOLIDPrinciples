
//! Square nasledjuje IShape da bi mogli kreirati listu objekata tipa IShape u koje cemo smestati i krugove i kvadrate

namespace SingleResponsiblity
{
    class Square : IShape
    {
        public double A { get; set; }

        public Square(double side)
        {
            this.A = side;
        }

    }
}

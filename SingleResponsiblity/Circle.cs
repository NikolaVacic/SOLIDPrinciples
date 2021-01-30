
//! Circle nasledjuje IShape da bi mogli kreirati listu objekata tipa IShape u koje cemo smestati i krugove i kvadrate

namespace SingleResponsiblity
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            this.Radius = r;
        }

    }
}

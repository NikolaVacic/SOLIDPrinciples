namespace InterfaceSegregation
{
    class Cube : Shape3DInterface
    {

        public double A { get; set; }

        public Cube(double a)
        {
            this.A = a;
        }

        public double Volume()
        {
            return A * A * A;
        }

        public double Area()
        {
            return 6 * A * A;
        }
    }

}
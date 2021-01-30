using System.Collections.Generic;


namespace InterfaceSegregation
{
    class AreaCalculator : Calculator
    {
        protected List<IShape> niz;    // lista objekata tipa Circle, Square, Sphere ili Cube

        public AreaCalculator(List<IShape> list)
        {
            this.niz = list;
        }

        public double Sum()
        {
            double sum = 0;

            foreach (Shape2DInterface shape in niz)
            {
                sum += shape.Area();
            }

            return sum;
        }





    }
}

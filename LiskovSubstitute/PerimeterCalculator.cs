using System.Collections.Generic;

namespace LiskovSubstitute
{
    class PerimeterCalculator : AreaCalculator
    {
        public PerimeterCalculator(List<IShape> list) : base(list) { }


        public override double Sum() {

            double perimeter = 0;
            foreach (Shape2DInterface shape in niz) {
                perimeter += shape.Perimeter();
            }
            return perimeter;

        }
    }
}

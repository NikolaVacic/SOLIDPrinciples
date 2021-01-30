using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class VolumeCalculator : Calculator
    {
        private List<Shape3DInterface> niz;

        public VolumeCalculator(List<Shape3DInterface> n)
        {
            this.niz = n;
        }

        public double Sum()
        {
            double sum = 0;

            foreach (var shape in niz)
                sum += shape.Volume();

            return sum;
        }
    }
}

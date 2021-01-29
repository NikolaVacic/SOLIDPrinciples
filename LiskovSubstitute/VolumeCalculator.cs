using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitute
{
    class VolumeCalculator : AreaCalculator
    {
        public VolumeCalculator(List<IShape> list) : base(list) { }


        public override double Sum() {

            double volume = 0;
            foreach (IShape shape in niz) {
                volume += shape.volume();
            }
            return volume;

        }
    }
}

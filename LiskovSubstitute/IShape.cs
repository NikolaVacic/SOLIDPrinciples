using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Potreban je jedan interfejs ili apstraktna klasa.


namespace LiskovSubstitute
{
    abstract class IShape
    {

        public abstract double area();
        public abstract double volume();
    }
}

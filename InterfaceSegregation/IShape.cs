using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Potreban je jedan interfejs ili apstraktna klasa.


namespace InterfaceSegregation
{
    // IShape je interfejs za 2D objekte

    interface IShape
    {
        // funkcija za povrsinu 2D figure
        double area();

        // funckija za Obim 2D figure
        double Perimeter();
    }
}

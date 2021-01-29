using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    // Ovaj interfejs ce omoguciti da se svi oblici stave u jednu listu/niz.
    interface ManageInterfaces
    {
        // ova funkcija ce racunati povrsinu ako bude pozvana nad 2D objektima, odnosno zapreminu ako bude pozvana nad 3D
        double Calculate();
    }
}

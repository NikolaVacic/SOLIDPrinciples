using System.Collections.Generic;

//! Ova klasa racuna povrsinu svih 2D figura u nizu. 

namespace LiskovSubstitute
{
    class AreaCalculator
    {
        protected List<IShape> niz;    // lista objekata tipa Circle ili Square

        public AreaCalculator(List<IShape> list)
        {
            this.niz = list;
        }

        
        public virtual double Sum()
        {
            double sum = 0;

            foreach (Shape2DInterface shape in niz)
            {
                //! Mnogo je bolje kreirati interfejs sa metodamo koje zelimo omoguciti i obezbediti logiku unutar 
                //! klasa koje implementiraju taj interfejs
                //! time ako zelimo da prosirimo IShape klasu nekim novom figurom nema potrebe menjati AreaCalculator klasu

                sum += shape.Area();


            }
            return sum;
        }
    }
}

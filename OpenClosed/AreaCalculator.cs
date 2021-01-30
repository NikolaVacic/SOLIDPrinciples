using System;
using System.Collections.Generic;
using static System.Math;

//! Ova klasa racuna povrsinu svih 2D figura u nizu. 

namespace OpenClosed
{
    class AreaCalculator
    {
        private List<IShape> niz;    // lista objekata tipa Circle ili Square

        public AreaCalculator(List<IShape> list)
        {
            this.niz = list;
        }

        // Ova funkcija nije napisana na odgovarajuci nacin.
        // Problem sa ovom funkcijom je taj sto ako zelimo da omogucimo nove figure kao npr kvadrat ili trougao
        // moramo menjati dosta logike unutar funkcije. Moramo dodavati nove if-ove itd...

        // Necu zakomentarisati ovu funckiju vec cu je samo nazvati SumWrong
        public double SumWrong()
        {
            double sum = 0;

            foreach (IShape shape in niz)
            {
                if (shape.GetType() == typeof(Square))
                    sum += Pow(((Square)shape).A, 2);
                if (shape.GetType() == typeof(Circle))
                    sum += Math.PI * Pow(((Circle)shape).Radius, 2);
            }
            return sum;
        }

        // Ovako bi trebalo da izgleda funkcija
        public double Sum()
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

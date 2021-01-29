using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


// nad ovom klasom pokazujemo princip Single Responsiblity
// ova klasa ce racunati povrsinu niza Shape-ova, ali ova klasa ne treba outputovati izrazunatu povrsinu


namespace LiskovSubstitute
{
    class AreaCalculator
    {
        protected List<IShape> niz;    // lista objekata tipa Circle ili Square

        public AreaCalculator(List<IShape> list)
        {
            this.niz = list;
        }

        // Ova funkcija nije napisana na odgovarajuci nacin.
        // Problem sa ovom funkcijom je taj sto ako zelimo da omogucimo nove figure kao npr kvadrat ili trougao
        // moramo menjati dosta logike unutar funkcije. Moramo dodavati nove if-ove itd...

        // Necu zakomentarisati ovu funckiju vec cu je samo nazvati areaWrong
        public double areaWrong()
        {
            double sum = 0;

            foreach (IShape shape in niz)
            {
                if (shape.GetType() == typeof(Square))
                    sum += Pow(((Square)shape).getA(), 2);
                if (shape.GetType() == typeof(Circle))
                    sum += Math.PI * Pow(((Circle)shape).getR(), 2);
            }
            return sum;
        }

        // Ovako bi trebalo da izgleda funkcija
        public virtual double Sum()
        {
            double sum = 0;

            foreach (IShape shape in niz)
            {
                // mnogo je bolje deklarisati apstraktnu metodu unutar IShape apstraktne klase/interfejsa i onda
                // pozivati tu metodu nad svakom figurom niza, a logiku za racunanje povrsine uraditi unutar klase.
                sum += shape.area();
            
                // time ako zelimo da prosirimo IShape klasu nekim novom figurom nema potrebe menjati AreaCalculator klasu
            }

            return sum;
        }





    }
}

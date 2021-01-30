using System;
using System.Collections.Generic;
using static System.Math;


//! Nad ovom klasom pokazujemo princip Single Responsiblity
//! Ova klasa ce racunati povrsinu niza Shape-ova, ali ova klasa ne treba outputovati izrazunatu povrsinu


namespace SingleResponsiblity
{
    class AreaCalculator
    {
        private List<IShape> niz;          //! lista objekata tipa Circle ili Square

        public AreaCalculator(List<IShape> list)
        {
            this.niz = list;
        }

        //! Ovo nije idealan nacin za pisanje ove funkcije ali popravljanje ove funkcije ce biti zadatak sledeceg principa open-closed

        public double Sum()
        {
            double sum = 0;

            foreach (IShape shape in niz) {
                if (shape.GetType() == typeof(Square))
                    sum += Pow(((Square)shape).A, 2);
                if (shape.GetType() == typeof(Circle))
                    sum += Math.PI * Pow(((Circle)shape).Radius,2);
            }
            return sum;
        }


        //! Ukoliko bi zeleli da ova klasa radi output onda bi prekrsili princip SingleResponsiblity

        //! Ova funkcija bi prekrsila princip SingleResponsibility principa jer ova klasa ima zadatak da samo
        //! racuna povrsinu, ne da daje output. Sta ako korisnik zeli da output bude u fajlu, a ne u konzoli
        
        public void output() {

            Console.WriteLine("Zbir povrsina figura iz niza je:" + this.Sum());

        }

        // Zato je potrebno kreirati novu klasu koja ce se baviti outputom ako nam je output potreban.



    }
}

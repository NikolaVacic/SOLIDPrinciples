using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;




namespace InterfaceSegregation
{
    class Calculator
    {
        protected List<ManageInterfaces> niz;    // lista objekata tipa Circle, Square, Sphere ili Cube

        public Calculator(List<ManageInterfaces> list)
        {
            this.niz = list;
        }

        // Ova funkcija racuna sumu svih tela u nizu. Ako su 3D racuna zapreminu, a ako su 2D racuna povrsinu
        public virtual double Sum()
        {
            double sum = 0;

            foreach (ManageInterfaces shape in niz)
            {
                sum += shape.Calculate();
            }

            return sum;
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ovom klasom izvalicmo output iz AreaCalculatora i time ne krsimo SingleResp princip.

namespace InterfaceSegregation
{
    class SumCalculatorOutputter
    {
        private Calculator ac;

        public SumCalculatorOutputter(Calculator other)
        {
            this.ac = other;
        }

        public void OutputToConsole() {
            Console.WriteLine(ac.Sum());
        }

        public void OutputToFile() {

            System.IO.File.WriteAllText(@"C:\Users\Nikola\Desktop\Nordeus\Materijal\1. Software Design principi\Solid principles code\SingleResponsiblity\InterfaceSegregation\output.txt", (ac.Sum()).ToString());
        }

    }
}

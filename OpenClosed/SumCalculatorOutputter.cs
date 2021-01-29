using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ovom klasom izvalicmo output iz AreaCalculatora i time ne krsimo SingleResp princip.

namespace OpenClosed
{
    class SumCalculatorOutputter
    {
        private AreaCalculator ac;

        public SumCalculatorOutputter(AreaCalculator other)
        {
            this.ac = other;
        }

        public void OutputToConsole() {
            Console.WriteLine($"Suma = {ac.area()}");
        }

        public void OutputToFile() {

            System.IO.File.WriteAllText(@"C:\Users\Nikola\Desktop\Nordeus\Materijal\1. Software Design principi\Solid principles code\SingleResponsiblity\OpenClosed\output.txt", (ac.area()).ToString());
        }

    }
}

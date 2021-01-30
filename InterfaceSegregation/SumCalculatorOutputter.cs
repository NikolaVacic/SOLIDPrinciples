using System;

// ovom klasom izvalicmo output iz AreaCalculatora i time ne krsimo SingleResp princip.

namespace InterfaceSegregation
{
    class SumCalculatorOutputter
    {
        private Calculator cal;

        public SumCalculatorOutputter(Calculator other)
        {
            this.cal = other;
        }

        public void OutputToConsole() {
            Console.WriteLine(cal.Sum());
        }

        public void OutputToFile() {

            System.IO.File.WriteAllText(@"C:\Users\Nikola\Desktop\Nordeus\Materijal\1. Software Design principi\
                Solid principles code\SingleResponsiblity\InterfaceSegregation\output.txt", (cal.Sum()).ToString());
        }

    }
}

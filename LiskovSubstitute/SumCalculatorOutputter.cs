using System;


namespace LiskovSubstitute
{
    class SumCalculatorOutputter
    {
        private AreaCalculator ac;

        public SumCalculatorOutputter(AreaCalculator other)
        {
            this.ac = other;
        }

        public void OutputToConsole() {
            Console.WriteLine($"Suma = {ac.Sum()}");
        }

        public void OutputToFile() {

            System.IO.File.WriteAllText(@"C:\Users\Nikola\Desktop\Nordeus\Materijal\1. Software Design principi\Solid principles code\SingleResponsiblity\LiskovSubstitute\output.txt", (ac.Sum()).ToString());
        }

    }
}

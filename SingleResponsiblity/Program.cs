using System.Collections.Generic;


//! SingleResponsiblity je prvi princip u SOLID akronimu.
//! SingleResponsiblity je princip koji kaze da jedna klasa treba da radi samo jednu stvar.

/*
   U ovom primeru imamo klasu AreaCalculator koja racuna povrsinu prosledjenih 2D geometrijskih figura.
   Da bi ispostovali SingleRespobilty princip ne smemo raditi nista drugo u AreaCalculator klasi osim racunati povrsinu,
   ne smemo na primer stampati output.

   Napomena dolazim iz C++ background-a i tek sam poceo uciti C# tako da ovaj kod verovatno lici na C++ i verovatno
   ne postujem sve C# standarde
*/


namespace SingleResponsiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> nizFigura = new List<IShape>();

            Square s1 = new Square(5);      // povrsina = 5 * 5 = 25
            Circle c1 = new Circle(3);      // povrsina = 9 * pi = 28.26
            Square s2 = new Square(7);      // povrsina = 7 * 7 = 49

            nizFigura.Add(s1);
            nizFigura.Add(c1);
            nizFigura.Add(s2);

            AreaCalculator AC = new AreaCalculator(nizFigura);

            SumCalculatorOutputter sco = new SumCalculatorOutputter(AC);

            sco.OutputToConsole();
            sco.OutputToFile();
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Svi primeri ovih projekata su uzeti sa web stranice:
// https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design



// SingleResposiblity je princip koji kaze da jedna klasa treba da radi samo jednu stvar

// U ovom primeru imamo klasu AreaCalculator koja racuna povrsinu prosledjenih geometrijskih figura.
// Da bi ispostovali SingleRespobilty princip ne smemo raditi nista drugo u AreaCalculator klasi osim racunati povrsinu,
// ne smemo na primer stampati output.

// Ovaj primer nece biti uradjen totalno tacno, da se pokazalo na kojim mestima postoji sansa za popravak koda.

// Napomena dolazim iz C++ background-a i tek sam poceo uciti C# tako da ovaj kod verovatno lici na C++ i verovatno
// ne postujem sve C# standarde


namespace SingleResponsiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> nizFigura = new List<IShape>();

            Square s1 = new Square(5);      // povrsina = 25
            Circle c1 = new Circle(3);      // povrsina = 9 * pi = 28.26
            Square s2 = new Square(8);      // povrsina = 64

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

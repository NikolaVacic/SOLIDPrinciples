using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Svi primeri ovih projekata su uzeti sa web stranice:
// https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design



// Liskov Substitute princip je treci princip u SOLID akronimu
// Ovaj princip kaze da objekat izvedene klase mora biti u stanju da zameni objekat klase iz koje je izveden
// bez ikakvih problema, prepravka ili menjanja ponasanja.

// Nastavak primera iz OpenClosed projekta
// Dodata je klasa VolumeCalculator koja nasledjuje klasu AreaCalculator

// Napomena dolazim iz C++ background-a i tek sam poceo uciti C# tako da ovaj kod verovatno lici na C++ i verovatno
// ne postujem sve C# standarde

namespace LiskovSubstitute
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

            AreaCalculator ac = new AreaCalculator(nizFigura);
            VolumeCalculator vc = new VolumeCalculator(nizFigura);

            // znamo da linija ispod radi
            SumCalculatorOutputter soc = new SumCalculatorOutputter(ac);
            soc.OutputToConsole();

            // da bi Liskov Substitute princip bio zadovoljen i linija ispod mora da radi
            // ubacili smo vc umesto ac i sve radi bez ikakvog menjanja koda. Time je princip zadovoljen.
            SumCalculatorOutputter soc1 = new SumCalculatorOutputter(vc);
            soc1.OutputToConsole();



        }
    }
}

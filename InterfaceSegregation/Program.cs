using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Svi primeri ovih projekata su uzeti sa web stranice:
// https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design


// Interface segregation princip je cetvrti princip u SOLID akronimu
// Ovaj princip kaze da klijenti ne bi trebalo zavisiti od interfejsa koji ne koristi
// Klijenti ne bi trebali biti forsirani da implementiraju metode koje ne koriste

// Nastavak primera iz Liskov Substitute projekta sa malim izmenama. Umesto Apstraktne IShape klase, koristicemo IShape interfejs, cisto zbog naziva principa
// Ako bi se od nas zahtevalo da dodamo nove 3D figure kojima je moguce izracunati i zapreminu imamo dva nacina:
// 1. Mozemo dodati metodu za zapreminu u IShape interfejs, ali to bi znacilo da moramo implementirati te metode za sve objekte,
// cak i za 2D objekte, a 2D objekti nemaju zapreminu, tako da je to los pristup.
// 2. Mozemo kreirati novi interfejs koji ce imati metodu za racunanje zapremine

// Dodajemo interfejs IShape3D i dodajemo figuru Kocku i Sferu. Ako zelimo mozemo implementirati IShape2D interfejs
// za Kocku i Sferu jer 3D figure imaju i obim i povrsinu.

// Dodacemo jos jedan interfejs kojim cemo upravljati interfejsima IShape i IShape3D

// Napomena dolazim iz C++ background-a i tek sam poceo uciti C# tako da ovaj kod verovatno lici na C++ i verovatno
// ne postujem sve C# standarde

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ManageInterfaces> niz2DFigura = new List<ManageInterfaces>();
            List<ManageInterfaces> niz3DFigura = new List<ManageInterfaces>();


            Square s1 = new Square(5);      // povrsina = 25
            Circle c1 = new Circle(3);      // povrsina = 9 * pi = 28.26
            Square s2 = new Square(8);      // povrsina = 64

            Sphere sp1 = new Sphere(2);     // V = 14.14
            Cube cu1 = new Cube(3);         // V = 27 
            Cube cu2 = new Cube(5);         // V = 125

            niz2DFigura.Add(s1);
            niz2DFigura.Add(c1);
            niz2DFigura.Add(s2);

            niz3DFigura.Add(sp1);
            niz3DFigura.Add(cu1);
            niz3DFigura.Add(cu2);

            Calculator ac2 = new Calculator(niz2DFigura);
            Calculator ac3 = new Calculator(niz3DFigura);

            SumCalculatorOutputter sco2 = new SumCalculatorOutputter(ac2);
            SumCalculatorOutputter sco3 = new SumCalculatorOutputter(ac3);

            sco2.OutputToConsole();
            sco3.OutputToConsole();


            
        }
    }
}

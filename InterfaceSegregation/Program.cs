using System.Collections.Generic;

//! Interface segregation princip je cetvrti princip u SOLID akronimu
//! Ovaj princip kaze da klijenti ne bi trebalo zavisiti od interfejsa koji ne koriste
//! Klijenti ne bi trebali biti forsirani da implementiraju metode koje ne koriste

//! Nastavljamo primer iz LiskovSubstitute projekta i dodajemo neke stvari.
//! Recimo da se od nas trazi da omogucimo 3D figure kao npr Kocku i Sferu i treba omoguciti da se njima izracuna zapremina. 
//! Imamo dva nacina za to. Mozemo dodati metodu za racunanje zapremine u Shape2DInterfejs, ali onda bi morali implementirati
//! Zapreminu i za kvadrat i krug, figure koje nemaju zapreminu. Zato je bolje da odvojimo ta dva interfejsa i kreiramo novi
//! sa metodom za racunanje zapremine. 3D figure mogu implementirati i 2D interfejs jer imaju i povrsinu i obim


// Dodacemo jos jedan interfejs kojim cemo upravljati interfejsima IShape i IShape3D

// Napomena dolazim iz C++ background-a i tek sam poceo uciti C# tako da ovaj kod verovatno lici na C++ i verovatno
// ne postujem sve C# standarde

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> niz2DFigura = new List<IShape>();
            
            List<Shape3DInterface> niz3DFigura = new List<Shape3DInterface>();
            
            List<IShape> nizIzmesanihFigura = new List<IShape>();

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

            Calculator ac2 = new AreaCalculator(niz2DFigura);
            Calculator ac3 = new VolumeCalculator(niz3DFigura);


            SumCalculatorOutputter sco2 = new SumCalculatorOutputter(ac2);
            SumCalculatorOutputter sco3 = new SumCalculatorOutputter(ac3);

            sco2.OutputToConsole();
            sco3.OutputToConsole();


            
        }
    }
}

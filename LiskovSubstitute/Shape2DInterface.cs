﻿//! U ovom interfejsu cemo ubaciti funkcije koje ce 2D oblici implemntirati

namespace LiskovSubstitute
{
    interface Shape2DInterface : IShape
    {
        double Area();              //! Funkcija za racunanje povrsine
        double Perimeter();         //! Funkcija za racunanje obima
    }
}
